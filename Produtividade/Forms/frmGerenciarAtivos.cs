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
	public partial class frmGerenciarAtivos : Form
	{
		public int resultado;
		
		public frmGerenciarAtivos()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			resultado = 1415;
			Close();
		}

		private void frmGerenciarAtivos_Load(object sender, EventArgs e)
		{
			dtvAtivos.Rows.Clear();
			Analistas analistas = new Analistas();
			
			foreach(string x in analistas.getNomes())
			{
				dtvAtivos.Rows.Add(x, analistas.getAtivo(x));
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Analistas analistas = new Analistas();
			
			foreach(DataGridViewRow x in dtvAtivos.Rows)
			{
				analistas.setAtivo(x.Cells["cAnalista"].Value.ToString(), Convert.ToBoolean(x.Cells["cAtivo"].Value));
			}

			resultado = 0;
			Close();
		}

        private void dtvAtivos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                e.SuppressKeyPress = true;
                btnOk_Click(null, null);
            }            
        }
	}
}
