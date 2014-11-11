using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Produtividade.Forms
{
	public partial class frmConfiguracaoEmail : Form
	{
		XDocument configuracao;
		
		public frmConfiguracaoEmail()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			configuracao.Element("configuracao").Element("email").Value = txtEmail.Text;
			configuracao.Element("configuracao").Element("servidor").Value = txtServidor.Text;
			configuracao.Element("configuracao").Element("porta").Value = txtPorta.Text;
			configuracao.Element("configuracao").Element("senha").Value = txtSenha.Text;
			
			configuracao.Save("config.xml");
			Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmConfiguracaoEmail_Load(object sender, EventArgs e)
		{
			if(File.Exists("config.xml"))
			{
				configuracao = XDocument.Load("config.xml");
				txtEmail.Text = configuracao.Element("configuracao").Element("email").Value;
				txtServidor.Text = configuracao.Element("configuracao").Element("servidor").Value;
				txtPorta.Text = configuracao.Element("configuracao").Element("porta").Value;
				txtSenha.Text = configuracao.Element("configuracao").Element("senha").Value;
			}
			else
			{
				configuracao = new XDocument(new XElement("configuracao"));
				configuracao.Element("configuracao").Add(new XElement("email"));
				configuracao.Element("configuracao").Add(new XElement("servidor"));
				configuracao.Element("configuracao").Add(new XElement("porta"));
				configuracao.Element("configuracao").Add(new XElement("senha"));
			}
		}
	}
}
