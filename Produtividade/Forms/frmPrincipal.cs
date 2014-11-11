using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produtividade
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void dtvAtendimentos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex == -1)
				return;

			try
			{
				dtvAtendimentos.Rows[e.RowIndex].Cells["cProdutividade"].Value = Convert.ToInt32(dtvAtendimentos.Rows[e.RowIndex].Cells["cFinalizados"].Value.ToString()) + Convert.ToInt32(dtvAtendimentos.Rows[e.RowIndex].Cells["cOutros"].Value.ToString());
			}
			catch { }

			try
			{
				dtvAtendimentos.Rows[e.RowIndex].Cells["cRetornos"].Value = Convert.ToInt32(dtvAtendimentos.Rows[e.RowIndex].Cells["cNovos"].Value.ToString()) - Convert.ToInt32(dtvAtendimentos.Rows[e.RowIndex].Cells["cFinalizados"].Value.ToString());
			}
			catch { }
		}
	}
}
