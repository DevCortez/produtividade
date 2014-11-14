namespace Produtividade.Forms
{
	partial class frmCadastroMeta
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
			this.dtvMetas = new System.Windows.Forms.DataGridView();
			this.cAnalista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cNovos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cOutros = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFinalizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProdutividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cRetornos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtvMetas)).BeginInit();
			this.SuspendLayout();
			// 
			// dtvMetas
			// 
			this.dtvMetas.AllowUserToOrderColumns = true;
			this.dtvMetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtvMetas.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dtvMetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvMetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAnalista,
            this.cNovos,
            this.cOutros,
            this.cFinalizados,
            this.cProdutividade,
            this.cRetornos});
			this.dtvMetas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dtvMetas.Location = new System.Drawing.Point(21, 28);
			this.dtvMetas.Name = "dtvMetas";
			this.dtvMetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvMetas.RowHeadersVisible = false;
			this.dtvMetas.Size = new System.Drawing.Size(319, 154);
			this.dtvMetas.TabIndex = 1;
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
			// frmCadastroMeta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 207);
			this.Controls.Add(this.dtvMetas);
			this.Name = "frmCadastroMeta";
			this.Text = "Cadastro de metas";
			((System.ComponentModel.ISupportInitialize)(this.dtvMetas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtvMetas;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAnalista;
		private System.Windows.Forms.DataGridViewTextBoxColumn cNovos;
		private System.Windows.Forms.DataGridViewTextBoxColumn cOutros;
		private System.Windows.Forms.DataGridViewTextBoxColumn cFinalizados;
		private System.Windows.Forms.DataGridViewTextBoxColumn cProdutividade;
		private System.Windows.Forms.DataGridViewTextBoxColumn cRetornos;

	}
}