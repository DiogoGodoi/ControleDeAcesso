namespace ControleDeAcesso
{
	partial class frmAutenticacao
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutenticacao));
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnEntrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(183, 67);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(135, 71);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 0;
			this.pctLogo.TabStop = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
			this.lblTitulo.Location = new System.Drawing.Point(36, 168);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(417, 32);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Controle de acesso de pessoal";
			// 
			// lblLogin
			// 
			this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblLogin.AutoSize = true;
			this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.Color.Navy;
			this.lblLogin.Location = new System.Drawing.Point(87, 236);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(68, 24);
			this.lblLogin.TabIndex = 2;
			this.lblLogin.Text = "Login";
			// 
			// lblSenha
			// 
			this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSenha.AutoSize = true;
			this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.Color.Navy;
			this.lblSenha.Location = new System.Drawing.Point(87, 290);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(74, 24);
			this.lblSenha.TabIndex = 3;
			this.lblSenha.Text = "Senha";
			// 
			// txtNome
			// 
			this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNome.Location = new System.Drawing.Point(183, 240);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(217, 20);
			this.txtNome.TabIndex = 4;
			// 
			// txtSenha
			// 
			this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSenha.Location = new System.Drawing.Point(183, 294);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(217, 20);
			this.txtSenha.TabIndex = 5;
			// 
			// btnSair
			// 
			this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(279, 357);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(121, 23);
			this.btnSair.TabIndex = 7;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.Sair);
			// 
			// btnEntrar
			// 
			this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEntrar.BackColor = System.Drawing.Color.Navy;
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEntrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.ForeColor = System.Drawing.Color.White;
			this.btnEntrar.Location = new System.Drawing.Point(91, 357);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(121, 23);
			this.btnEntrar.TabIndex = 6;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.Entrar);
			// 
			// frmAutenticacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 450);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.pctLogo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAutenticacao";
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnEntrar;
	}
}

