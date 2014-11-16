using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Produtividade.Geral;

namespace Produtividade.Forms
{
	public partial class frmCadastroMeta : Form
	{
		public frmCadastroMeta()
		{
			InitializeComponent();
		}

		private void frmCadastroMeta_Load(object sender, EventArgs e)
		{
			Analistas analistas = new Analistas();
			
			dtvMetas.Rows.Clear();

			foreach(string x in analistas.getNomes())
			{
				dtvMetas.Rows.Add(x, analistas.getMeta(x));				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Analistas analistas = new Analistas();

			foreach(DataGridViewRow x in dtvMetas.Rows)
			{				
				analistas.setMeta(x.Cells["cAnalista"].Value.ToString(), x.Cells["cMeta"].Value.ToString());
			}

			Close();
		}
	}
}
