﻿namespace Produtividade
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cAnalista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cNovos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cOutros = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cFinalizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cProdutividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cRetornos = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(502, 33);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(106, 20);
			this.dateTimePicker1.TabIndex = 1;
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
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 313);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dtvAtendimentos);
			this.MinimumSize = new System.Drawing.Size(636, 200);
			this.Name = "frmPrincipal";
			this.Text = "Principal";
			((System.ComponentModel.ISupportInitialize)(this.dtvAtendimentos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtvAtendimentos;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAnalista;
		private System.Windows.Forms.DataGridViewTextBoxColumn cNovos;
		private System.Windows.Forms.DataGridViewTextBoxColumn cOutros;
		private System.Windows.Forms.DataGridViewTextBoxColumn cFinalizados;
		private System.Windows.Forms.DataGridViewTextBoxColumn cProdutividade;
		private System.Windows.Forms.DataGridViewTextBoxColumn cRetornos;
	}
}
