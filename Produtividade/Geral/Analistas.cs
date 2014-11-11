﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Produtividade.Geral
{
	class Analistas
	{
		private XDocument analista;

		public Analistas()
		{					
			if(File.Exists("produtividade.xml"))
				analista = XDocument.Load("produtividade.xml");	
			else
				analista = new XDocument(new XElement("root"));	
		}

		private void salvarDados()
		{
			analista.Save("produtividade.xml");
		}

		public void setProdutividade(string nome, string data, string novos, string outros, string finalizados)
		{
			if( nome.Length == 0 || data.Length == 0 || novos.Length == 0 || outros.Length == 0 || finalizados.Length == 0)
				return;
			
			XElement analistaNode = null;

			analistaNode = analista.Element("root").Element(nome);			

			if(analistaNode == null)
				analista.Element("root").Add(analistaNode = new XElement(nome));
						
			DateTime dia = Convert.ToDateTime(data);
			XElement anoNode = analistaNode.Element("a" + dia.Year.ToString());

			if(anoNode == null)
				analistaNode.Add(anoNode = new XElement("a" + dia.Year.ToString()));




			XElement mesNode = anoNode.Element("m" + dia.Month.ToString());

			if(mesNode == null)
				anoNode.Add(mesNode = new XElement("m" + dia.Month.ToString()));



			XElement diaNode = mesNode.Element("d" + dia.Day.ToString());

			if(diaNode == null)
				mesNode.Add(diaNode = new XElement("d" + dia.Day.ToString()));

			diaNode.SetAttributeValue("novos", novos);
			diaNode.SetAttributeValue("finalizados", finalizados);
			diaNode.SetAttributeValue("outros", outros);

			//analista.Add( analistaNode = new XElement(nome) );

			/*if(analista.Nodes.Count)
				analistaNode = (from XmlNode x in analista.ChildNodes where x.Value == "ok" select x).FirstOrDefault();

			if(analistaNode == null)
				{
					XmlNode buffer = analista.CreateNode("element", nome, "");
					analista.AppendChild(buffer);
				}*/

			salvarDados();
		}
		
		private IEnumerable<string> getNomes()
		{
			List<string> listaNomes = new List<string>();
			
			foreach(XElement x in analista.Elements("root").Elements())
				listaNomes.Add( x.Name.ToString() );

			return listaNomes;
		}

		private Pessoa getDadosDiaPessoa(string pessoa, DateTime data)
		{
			Pessoa x = new Pessoa();

			try
			{
				XElement dadosNode = analista.Elements("root").Elements(pessoa).Elements("a" + data.Year.ToString()).Elements("m" + data.Month.ToString()).Elements("d" + data.Day.ToString()).FirstOrDefault();

				if(dadosNode == null)
					return null;

				x.nome = pessoa;
				x.novos = dadosNode.Attribute("novos").Value;
				x.outros = dadosNode.Attribute("outros").Value;
				x.finalizados = dadosNode.Attribute("finalizados").Value;
			}
			catch
			{
				x = null;
			}

			return x;
		}

		public IEnumerable<Pessoa> getDadosDia(string data)
		{
			DateTime dia = Convert.ToDateTime(data);
			List<Pessoa> listaPessoas = new List<Pessoa>();

			foreach(string nomePessoa in getNomes())
			{
				Pessoa currentPessoa = getDadosDiaPessoa(nomePessoa, dia);
				
				if(currentPessoa == null)
					{
						currentPessoa = new Pessoa();
						currentPessoa.nome = nomePessoa;
					}
				
				listaPessoas.Add(currentPessoa);								
			}

			return listaPessoas;
		}
	}

	class Pessoa
	{
		public string nome;
		public string novos;
		public string outros;
		public string finalizados;

		public Pessoa()
		{
			novos = "0";
			outros = "0";
			finalizados = "0";
		}
	}
}