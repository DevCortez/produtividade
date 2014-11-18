namespace Produtividade.Forms
{
	partial class frmGerenciarAtivos
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.dtvAtivos = new System.Windows.Forms.DataGridView();
			this.cAnalista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtvAtivos)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(239, 144);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "&Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(180, 144);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(53, 23);
			this.btnOk.TabIndex = 9;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// dtvAtivos
			// 
			this.dtvAtivos.AllowUserToAddRows = false;
			this.dtvAtivos.AllowUserToDeleteRows = false;
			this.dtvAtivos.AllowUserToOrderColumns = true;
			this.dtvAtivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtvAtivos.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dtvAtivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvAtivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAnalista,
            this.cAtivo});
			this.dtvAtivos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dtvAtivos.Location = new System.Drawing.Point(12, 12);
			this.dtvAtivos.Name = "dtvAtivos";
			this.dtvAtivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvAtivos.RowHeadersVisible = false;
			this.dtvAtivos.Size = new System.Drawing.Size(291, 126);
			this.dtvAtivos.TabIndex = 8;
			// 
			// cAnalista
			// 
			this.cAnalista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cAnalista.HeaderText = "Analista";
			this.cAnalista.Name = "cAnalista";
			this.cAnalista.ReadOnly = true;
			// 
			// cAtivo
			// 
			this.cAtivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cAtivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cAtivo.HeaderText = "Ativo";
			this.cAtivo.Name = "cAtivo";
			this.cAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.cAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.cAtivo.Width = 90;
			// 
			// frmGerenciarAtivos
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 170);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.dtvAtivos);
			this.KeyPreview = true;
			this.Name = "frmGerenciarAtivos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmGerenciarAtivos";
			this.Load += new System.EventHandler(this.frmGerenciarAtivos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtvAtivos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.DataGridView dtvAtivos;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAnalista;
		private System.Windows.Forms.DataGridViewCheckBoxColumn cAtivo;
	}
}