using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
		//private Analistas analistas = new Analistas();
		
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
			Analistas analistas = new Analistas();
			
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

		private void carregarDadosDoDia()
		{
			Analistas analistas = new Analistas();
			
			dtvAtendimentos.Rows.Clear();

			foreach (Pessoa x in analistas.getDadosDia(dtpDia.Value.ToShortDateString()))
			{
				dtvAtendimentos.Rows.Add(x.id, x.nome, x.novos, x.outros, x.finalizados);
			}

			calcularDados();
		}
		
		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			carregarDadosDoDia();
		}

		private void emailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmConfiguracaoEmail configurador = new frmConfiguracaoEmail();
			configurador.ShowDialog(this);
		}

		private void enviarPorEmailToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			pnlLoading.Left = (Width / 2) - (pnlLoading.Width / 2);
			pnlLoading.Top = (Height/2)-(pnlLoading.Height/2);
			pnlLoading.Show();
			pnlLoading.Refresh();

			frmGerenciarAtivos gerenciarAtivos = new frmGerenciarAtivos();
			gerenciarAtivos.ShowDialog(this);

			if(gerenciarAtivos.resultado != 0)
			{
				pnlLoading.Hide();
				return;
			}

			Analistas analistas = new Analistas(); 

			foreach(string x in analistas.getNomes())
			{
				if(analistas.getAtivo(x))
				{
					lblMensagem.Text = "Enviando e-mail para " + x + "...";
					lblMensagem.Refresh();
					
					Relatorio.enviarRelatorio(  x + Configurador.getSuffix(), 
												"Relatorio de produtividade - " + x, 
												Relatorio.gerarRelatorio(dtpDia.Value.ToShortDateString(), 
												x, 
												analistas));
				}
			}
			//Relatorio.enviarRelatorio("eduardo.sqa@alterdata.com.br", "Relatorio de produtividade", Relatorio.gerarRelatorio(dtpDia.Value.ToShortDateString(), "eduardo.sqa", analistas));
			
			pnlLoading.Hide();
		}

		private void metasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmCadastroMeta metas = new frmCadastroMeta();
			metas.ShowDialog(this);
		}

		private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.PageUp && e.Modifiers == Keys.Control)
				dtpDia.Value = dtpDia.Value.AddDays(1);

			if (e.KeyCode == Keys.PageDown && e.Modifiers == Keys.Control)
				dtpDia.Value = dtpDia.Value.AddDays(-1);
		}

		private void dtpDia_ValueChanged(object sender, EventArgs e)
		{
			carregarDadosDoDia();
		}
	}
}
