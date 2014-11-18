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
            this.cMeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Location = new System.Drawing.Point(246, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadastroMeta
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(322, 174);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dtvMetas);
            this.KeyPreview = true;
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
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn cAnalista;
		private System.Windows.Forms.DataGridViewTextBoxColumn cMeta;

	}
}