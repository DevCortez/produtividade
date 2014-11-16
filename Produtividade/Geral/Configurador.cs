using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Produtividade.Geral
{
	class Configurador
	{
		public static string getEmail()
		{
			XDocument configuracoes = XDocument.Load("config.xml");
			return configuracoes.Element("configuracao").Element("email").Value.ToString();
		}

		public static string getEmailPassword()
		{
			XDocument configuracoes = XDocument.Load("config.xml");
			return configuracoes.Element("configuracao").Element("senha").Value.ToString();
		}

		public static int getEmailPort()
		{
			XDocument configuracoes = XDocument.Load("config.xml");
			return Convert.ToInt32(configuracoes.Element("configuracao").Element("porta").Value.ToString());
		}

		public static string getEmailServer()
		{
			XDocument configuracoes = XDocument.Load("config.xml");
			return configuracoes.Element("configuracao").Element("servidor").Value.ToString();
		}

		public static string getSuffix()
		{
			XDocument configuracoes = XDocument.Load("config.xml");
			return configuracoes.Element("configuracao").Element("sufixo").Value.ToString();
		}
	}
}
