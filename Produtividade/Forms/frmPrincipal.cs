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
	public partial class frmPrincipal : Form
	{
		private Analistas analistas = new Analistas();
		
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void calcularDados()
		{
			foreach(DataGridViewRow x in dtvAtendimentos.Rows)
			{
				try
				{
					x.Cells["cProdutividade"].Value = Convert.ToInt32(x.Cells["cFinalizados"].Value.ToString()) + Convert.ToInt32(x.Cells["cOutros"].Value.ToString());
					x.Cells["cRetornos"].Value = Convert.ToInt32(x.Cells["cNovos"].Value.ToString()) - Convert.ToInt32(x.Cells["cFinalizados"].Value.ToString());
				} catch {}
			}				
		}
		
		private void dtvAtendimentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex == -1)
				return;

			calcularDados();
			
			try
			{
				analistas.setProdutividade(dtvAtendimentos.Rows[e.RowIndex].Cells["cAnalista"].Value.ToString(),
											dtpDia.Value.ToShortDateString(),
											dtvAtendimentos.Rows[e.RowIndex].Cells["cNovos"].Value.ToString(),
											dtvAtendimentos.Rows[e.RowIndex].Cells["cOutros"].Value.ToString(),
											dtvAtendimentos.Rows[e.RowIndex].Cells["cFinalizados"].Value.ToString());
			}
			catch {}
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			foreach (Pessoa x in analistas.getDadosDia(dtpDia.Value.ToShortDateString()))
			{
				dtvAtendimentos.Rows.Add(x.nome, x.novos, x.outros, x.finalizados);
			}

			calcularDados();
		}

		private void emailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmConfiguracaoEmail configurador = new frmConfiguracaoEmail();
			configurador.Show();
		}
	}
}
