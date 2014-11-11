namespace Produtividade
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dtvAtendimentos = new System.Windows.Forms.DataGridView();
			this.cAnalista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cNovos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cOutros = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFinalizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProdutividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cRetornos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpDia = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dtvAtendimentos)).BeginInit();
			this.SuspendLayout();
			// 
			// dtvAtendimentos
			// 
			this.dtvAtendimentos.AllowUserToOrderColumns = true;
			this.dtvAtendimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtvAtendimentos.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dtvAtendimentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAnalista,
            this.cNovos,
            this.cOutros,
            this.cFinalizados,
            this.cProdutividade,
            this.cRetornos});
			this.dtvAtendimentos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dtvAtendimentos.Location = new System.Drawing.Point(12, 59);
			this.dtvAtendimentos.Name = "dtvAtendimentos";
			this.dtvAtendimentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvAtendimentos.RowHeadersVisible = false;
			this.dtvAtendimentos.Size = new System.Drawing.Size(596, 242);
			this.dtvAtendimentos.TabIndex = 0;
			this.dtvAtendimentos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvAtendimentos_CellValueChanged);
			// 
			// cAnalista
			// 
			this.cAnalista.HeaderText = "Analista";
			this.cAnalista.Name = "cAnalista";
			this.cAnalista.Width = 180;
			// 
			// cNovos
			// 
			this.cNovos.HeaderText = "Novos";
			this.cNovos.Name = "cNovos";
			this.cNovos.Width = 80;
			// 
			// cOutros
			// 
			this.cOutros.HeaderText = "Finalizado outros";
			this.cOutros.Name = "cOutros";
			this.cOutros.Width = 80;
			// 
			// cFinalizados
			// 
			this.cFinalizados.HeaderText = "Finalizados";
			this.cFinalizados.Name = "cFinalizados";
			this.cFinalizados.Width = 80;
			// 
			// cProdutividade
			// 
			this.cProdutividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cProdutividade.HeaderText = "Produtividade";
			this.cProdutividade.Name = "cProdutividade";
			this.cProdutividade.ReadOnly = true;
			// 
			// cRetornos
			// 
			this.cRetornos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cRetornos.HeaderText = "Retornos";
			this.cRetornos.Name = "cRetornos";
			this.cRetornos.ReadOnly = true;
			// 
			// dtpDia
			// 
			this.dtpDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDia.Location = new System.Drawing.Point(502, 33);
			this.dtpDia.Name = "dtpDia";
			this.dtpDia.Size = new System.Drawing.Size(106, 20);
			this.dtpDia.TabIndex = 1;
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 313);
			this.Controls.Add(this.dtpDia);
			this.Controls.Add(this.dtvAtendimentos);
			this.MinimumSize = new System.Drawing.Size(636, 200);
			this.Name = "frmPrincipal";
			this.Text = "Principal";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtvAtendimentos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtvAtendimentos;
		private System.Windows.Forms.DateTimePicker dtpDia;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAnalista;
		private System.Windows.Forms.DataGridViewTextBoxColumn cNovos;
		private System.Windows.Forms.DataGridViewTextBoxColumn cOutros;
		private System.Windows.Forms.DataGridViewTextBoxColumn cFinalizados;
		private System.Windows.Forms.DataGridViewTextBoxColumn cProdutividade;
		private System.Windows.Forms.DataGridViewTextBoxColumn cRetornos;
	}
}

