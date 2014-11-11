namespace Produtividade.Forms
{
	partial class frmConfiguracaoEmail
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtServidor = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblServidor = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblPorta = new System.Windows.Forms.Label();
			this.txtPorta = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(15, 25);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(229, 20);
			this.txtEmail.TabIndex = 0;
			// 
			// txtServidor
			// 
			this.txtServidor.Location = new System.Drawing.Point(16, 104);
			this.txtServidor.Name = "txtServidor";
			this.txtServidor.Size = new System.Drawing.Size(228, 20);
			this.txtServidor.TabIndex = 3;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(12, 9);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(35, 13);
			this.lblEmail.TabIndex = 3;
			this.lblEmail.Text = "E-mail";
			// 
			// lblServidor
			// 
			this.lblServidor.AutoSize = true;
			this.lblServidor.Location = new System.Drawing.Point(13, 88);
			this.lblServidor.Name = "lblServidor";
			this.lblServidor.Size = new System.Drawing.Size(46, 13);
			this.lblServidor.TabIndex = 4;
			this.lblServidor.Text = "Servidor";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(12, 47);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(38, 13);
			this.lblSenha.TabIndex = 5;
			this.lblSenha.Text = "Senha";
			// 
			// btnOk
			// 
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(110, 130);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(53, 23);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancelar.Location = new System.Drawing.Point(169, 130);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// lblPorta
			// 
			this.lblPorta.AutoSize = true;
			this.lblPorta.Location = new System.Drawing.Point(192, 48);
			this.lblPorta.Name = "lblPorta";
			this.lblPorta.Size = new System.Drawing.Size(32, 13);
			this.lblPorta.TabIndex = 8;
			this.lblPorta.Text = "Porta";
			// 
			// txtPorta
			// 
			this.txtPorta.Location = new System.Drawing.Point(195, 64);
			this.txtPorta.Name = "txtPorta";
			this.txtPorta.Size = new System.Drawing.Size(49, 20);
			this.txtPorta.TabIndex = 2;
			this.txtPorta.Text = "25";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(16, 64);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '#';
			this.txtSenha.Size = new System.Drawing.Size(173, 20);
			this.txtSenha.TabIndex = 1;
			// 
			// frmConfiguracaoEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(256, 157);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtPorta);
			this.Controls.Add(this.lblPorta);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblServidor);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtServidor);
			this.Controls.Add(this.txtEmail);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.KeyPreview = true;
			this.Name = "frmConfiguracaoEmail";
			this.Text = "Configuração do email";
			this.Load += new System.EventHandler(this.frmConfiguracaoEmail_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtServidor;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblServidor;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblPorta;
		private System.Windows.Forms.TextBox txtPorta;
		private System.Windows.Forms.TextBox txtSenha;
	}
}