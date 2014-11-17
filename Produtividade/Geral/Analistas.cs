using System;
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
				{
					analista.Element("root").Add(analistaNode = new XElement(nome));
					analistaNode.SetAttributeValue("id", nome);
				}
						
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
		
		public IEnumerable<string> getNomes()
		{
			List<string> listaNomes = new List<string>();
			
			foreach(XElement x in analista.Elements("root").Elements())
				listaNomes.Add( x.Name.ToString() );

			return listaNomes;
		}

		public Pessoa getDadosDiaPessoa(string pessoa, DateTime data)
		{
			Pessoa x = new Pessoa();

			try
			{
				XElement dadosNode = analista.Elements("root").Elements(pessoa).Elements("a" + data.Year.ToString()).Elements("m" + data.Month.ToString()).Elements("d" + data.Day.ToString()).FirstOrDefault();

				if(dadosNode == null)
					return null;

				x.nome = pessoa;
				//x.id = dadosNode.Attribute("novos").Value;
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

		public Pessoa getDadosMesPessoa(string pessoa, DateTime data)
		{
			Pessoa x = new Pessoa();

			try
			{
				IEnumerable<XElement> dadosNode = analista.Elements("root").Elements(pessoa).Elements("a" + data.Year.ToString()).Elements("m" + data.Month.ToString());

				if (dadosNode == null)
					return null;


				foreach(XElement currentDia in dadosNode.DescendantNodes())
				{
					x.nome = pessoa;
		
					x.novos = (Convert.ToInt32(x.novos) + Convert.ToInt32((currentDia as XElement).Attribute("novos").Value)).ToString();
					x.outros = (Convert.ToInt32(x.outros) + Convert.ToInt32((currentDia as XElement).Attribute("outros").Value)).ToString();
					x.finalizados = (Convert.ToInt32(x.finalizados) + Convert.ToInt32((currentDia as XElement).Attribute("finalizados").Value)).ToString();
				}
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

		public IEnumerable<Pessoa> getDadosMes(string data)
		{
			DateTime dia = Convert.ToDateTime(data);
			List<Pessoa> listaPessoas = new List<Pessoa>();

			foreach (string nomePessoa in getNomes())
			{
				Pessoa currentPessoa = getDadosMesPessoa(nomePessoa, dia);

				if (currentPessoa == null)
				{
					currentPessoa = new Pessoa();
					currentPessoa.nome = nomePessoa;
				}

				listaPessoas.Add(currentPessoa);
			}

			return listaPessoas;
		}

		public void setMeta(string nome, string meta)
		{
			XElement x = analista.Descendants(nome).FirstOrDefault();

			if(x == null)
				return;

			XElement pMeta = x.Element("meta");

			if(pMeta == null)
				{
					pMeta = new XElement("meta");
					x.Add(pMeta);
				}

			pMeta.Value = meta;			
			salvarDados();
		}
		
		public int getMeta(string nome)
		{
			try
			{
				return Convert.ToInt32(analista.Descendants(nome).Elements("meta").FirstOrDefault().Value);
			}
			catch
			{
				return 0;
			}
		}

		public int getDiasTrabalhados(string nome, DateTime data)
		{
			IEnumerable<XElement> mesNode = analista.Elements("root").Elements(nome).Elements("a" + data.Year.ToString()).Elements("m" + data.Month.ToString());

			int total = 0;

			foreach (XElement x in mesNode.DescendantNodes())
			{
				if (Convert.ToInt32(x.Attribute("novos").Value) > 0 ||
					Convert.ToInt32(x.Attribute("outros").Value) > 0 ||
					Convert.ToInt32(x.Attribute("finalizados").Value) > 0)
					total++;
			}

			return total;
		}

		public IEnumerable<DiaTrabalhado> getListaDiasTrabalhados(string nome, DateTime data)
		{
			IEnumerable<XElement> mesNode = analista.Elements("root").Elements(nome).Elements("a" + data.Year.ToString()).Elements("m" + data.Month.ToString());
			List<DiaTrabalhado> listaDias = new List<DiaTrabalhado>();

		
			foreach (XElement x in mesNode.DescendantNodes())
			{
				if (Convert.ToInt32(x.Attribute("novos").Value) > 0 ||
					Convert.ToInt32(x.Attribute("outros").Value) > 0 ||
					Convert.ToInt32(x.Attribute("finalizados").Value) > 0)
					{
						DiaTrabalhado dia = new DiaTrabalhado();
						dia.novos = x.Attribute("novos").Value;
						dia.outros = x.Attribute("outros").Value;
						dia.finalizados = x.Attribute("finalizados").Value;
						dia.dia = x.Name.ToString().Substring(1, x.Name.ToString().Length-1);
						
						listaDias.Add(dia);
					}
			}

			return listaDias;
		}

		public void setAtivo(string nome, bool ativo)
		{
			XElement x = analista.Descendants(nome).FirstOrDefault();

			if (x == null)
				return;

			XElement pAtivo = x.Element("ativo");

			if (pAtivo == null)
			{
				pAtivo = new XElement("ativo");
				x.Add(pAtivo);
			}

			pAtivo.Value = ativo.ToString();
			salvarDados();
		}

		public bool getAtivo(string nome)
		{
			try
			{
				return Convert.ToBoolean(analista.Descendants(nome).Elements("ativo").FirstOrDefault().Value.ToString());
			}
			catch
			{
				return false;
			}
		}
	}

	class Pessoa
	{
		public string id;
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

	class DiaTrabalhado : Pessoa
	{
		public string dia;
	}
}
