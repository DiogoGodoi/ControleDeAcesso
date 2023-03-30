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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.radAcessoInterno = new System.Windows.Forms.RadioButton();
			this.radAcessoExterno = new System.Windows.Forms.RadioButton();
			this.nav = new System.Windows.Forms.Panel();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.titulo = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblFooter = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panelLineFooter = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.nav.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.panelFooter.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.BackColor = System.Drawing.Color.White;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Black;
			this.lblTitulo.Location = new System.Drawing.Point(85, 138);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(318, 24);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Controle de acesso de pessoal";
			// 
			// lblLogin
			// 
			this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblLogin.AutoSize = true;
			this.lblLogin.BackColor = System.Drawing.Color.White;
			this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.Color.Black;
			this.lblLogin.Location = new System.Drawing.Point(85, 194);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(68, 24);
			this.lblLogin.TabIndex = 2;
			this.lblLogin.Text = "Login";
			// 
			// lblSenha
			// 
			this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSenha.AutoSize = true;
			this.lblSenha.BackColor = System.Drawing.Color.White;
			this.lblSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.Color.Black;
			this.lblSenha.Location = new System.Drawing.Point(85, 248);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(74, 24);
			this.lblSenha.TabIndex = 3;
			this.lblSenha.Text = "Senha";
			// 
			// txtNome
			// 
			this.txtNome.AcceptsTab = true;
			this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(181, 198);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(222, 16);
			this.txtNome.TabIndex = 4;
			this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtSenha
			// 
			this.txtSenha.AcceptsTab = true;
			this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(181, 252);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(222, 16);
			this.txtSenha.TabIndex = 5;
			this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnSair
			// 
			this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(277, 340);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(126, 23);
			this.btnSair.TabIndex = 7;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.Sair);
			// 
			// btnEntrar
			// 
			this.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEntrar.BackColor = System.Drawing.Color.Navy;
			this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.ForeColor = System.Drawing.Color.White;
			this.btnEntrar.Location = new System.Drawing.Point(89, 340);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(121, 23);
			this.btnEntrar.TabIndex = 6;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.Entrar);
			// 
			// radAcessoInterno
			// 
			this.radAcessoInterno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radAcessoInterno.AutoSize = true;
			this.radAcessoInterno.BackColor = System.Drawing.Color.White;
			this.radAcessoInterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radAcessoInterno.ForeColor = System.Drawing.Color.Black;
			this.radAcessoInterno.Location = new System.Drawing.Point(89, 297);
			this.radAcessoInterno.Name = "radAcessoInterno";
			this.radAcessoInterno.Size = new System.Drawing.Size(122, 19);
			this.radAcessoInterno.TabIndex = 8;
			this.radAcessoInterno.TabStop = true;
			this.radAcessoInterno.Text = "Acesso interno";
			this.radAcessoInterno.UseVisualStyleBackColor = false;
			// 
			// radAcessoExterno
			// 
			this.radAcessoExterno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radAcessoExterno.AutoSize = true;
			this.radAcessoExterno.BackColor = System.Drawing.Color.White;
			this.radAcessoExterno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radAcessoExterno.ForeColor = System.Drawing.Color.Black;
			this.radAcessoExterno.Location = new System.Drawing.Point(273, 297);
			this.radAcessoExterno.Name = "radAcessoExterno";
			this.radAcessoExterno.Size = new System.Drawing.Size(125, 19);
			this.radAcessoExterno.TabIndex = 9;
			this.radAcessoExterno.TabStop = true;
			this.radAcessoExterno.Text = "Acesso externo";
			this.radAcessoExterno.UseVisualStyleBackColor = false;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.pctLogo);
			this.nav.Controls.Add(this.titulo);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(492, 62);
			this.nav.TabIndex = 27;
			// 
			// pctLogo
			// 
			this.pctLogo.BackColor = System.Drawing.Color.White;
			this.pctLogo.Dock = System.Windows.Forms.DockStyle.Left;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(0, 0);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(115, 62);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 4;
			this.pctLogo.TabStop = false;
			// 
			// titulo
			// 
			this.titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.titulo.AutoSize = true;
			this.titulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.ForeColor = System.Drawing.Color.White;
			this.titulo.Location = new System.Drawing.Point(219, 23);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(68, 22);
			this.titulo.TabIndex = 5;
			this.titulo.Text = "Entrar";
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.Navy;
			this.panelFooter.Controls.Add(this.label1);
			this.panelFooter.Controls.Add(this.lblFooter);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.ForeColor = System.Drawing.Color.White;
			this.panelFooter.Location = new System.Drawing.Point(0, 414);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(492, 36);
			this.panelFooter.TabIndex = 31;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(167, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pta - Serviços terceirizados";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFooter
			// 
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFooter.Location = new System.Drawing.Point(499, 15);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(158, 12);
			this.lblFooter.TabIndex = 0;
			this.lblFooter.Text = "Pta - Serviços terceirizados";
			this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Navy;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 342);
			this.panel1.TabIndex = 33;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Navy;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(482, 72);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 332);
			this.panel3.TabIndex = 35;
			// 
			// panelLineFooter
			// 
			this.panelLineFooter.BackColor = System.Drawing.Color.Navy;
			this.panelLineFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelLineFooter.Location = new System.Drawing.Point(0, 404);
			this.panelLineFooter.Name = "panelLineFooter";
			this.panelLineFooter.Size = new System.Drawing.Size(492, 10);
			this.panelLineFooter.TabIndex = 32;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Navy;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(482, 10);
			this.panel2.TabIndex = 34;
			// 
			// frmAutenticacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(492, 450);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelLineFooter);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.radAcessoExterno);
			this.Controls.Add(this.radAcessoInterno);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.lblTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAutenticacao";
			this.Text = "Login";
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.RadioButton radAcessoInterno;
		private System.Windows.Forms.RadioButton radAcessoExterno;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Label titulo;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panelLineFooter;
		private System.Windows.Forms.Panel panel2;
	}
}

