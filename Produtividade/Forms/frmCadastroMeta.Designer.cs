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
			this.btnOk = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cAnalista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cMeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtvMetas)).BeginInit();
			this.SuspendLayout();
			// 
			// dtvMetas
			// 
			this.dtvMetas.AllowUserToAddRows = false;
			this.dtvMetas.AllowUserToDeleteRows = false;
			this.dtvMetas.AllowUserToOrderColumns = true;
			this.dtvMetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtvMetas.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dtvMetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtvMetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cAnalista,
            this.cMeta});
			this.dtvMetas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dtvMetas.Location = new System.Drawing.Point(12, 12);
			this.dtvMetas.Name = "dtvMetas";
			this.dtvMetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dtvMetas.RowHeadersVisible = false;
			this.dtvMetas.Size = new System.Drawing.Size(298, 128);
			this.dtvMetas.TabIndex = 1;
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(187, 146);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(53, 23);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Location = new System.Drawing.Point(246, 146);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "&Cancelar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cAnalista
			// 
			this.cAnalista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cAnalista.HeaderText = "Analista";
			this.cAnalista.Name = "cAnalista";
			this.cAnalista.ReadOnly = true;
			// 
			// cMeta
			// 
			this.cMeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.cMeta.HeaderText = "Meta diária";
			this.cMeta.Name = "cMeta";
			this.cMeta.Width = 90;
			// 
			// frmCadastroMeta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(322, 174);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.dtvMetas);
			this.Name = "frmCadastroMeta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cadastro de metas";
			this.Load += new System.EventHandler(this.frmCadastroMeta_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtvMetas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtvMetas;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAnalista;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMeta;

	}
}