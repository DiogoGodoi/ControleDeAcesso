﻿namespace Menu_Inicial
{
	partial class frmEntrada
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrada));
			this.lblNomeVisitante = new System.Windows.Forms.Label();
			this.lblNomeVisitado = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.txtNomeVisitado = new System.Windows.Forms.TextBox();
			this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
			this.txtPesoEntrada = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.nav = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panelLineFooter = new System.Windows.Forms.Panel();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pctLogo = new FontAwesome.Sharp.IconPictureBox();
			this.nav.SuspendLayout();
			this.panelFooter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNomeVisitante
			// 
			this.lblNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitante.AutoSize = true;
			this.lblNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitante.ForeColor = System.Drawing.Color.Black;
			this.lblNomeVisitante.Location = new System.Drawing.Point(61, 212);
			this.lblNomeVisitante.Name = "lblNomeVisitante";
			this.lblNomeVisitante.Size = new System.Drawing.Size(137, 17);
			this.lblNomeVisitante.TabIndex = 4;
			this.lblNomeVisitante.Text = "Nome do visitante";
			// 
			// lblNomeVisitado
			// 
			this.lblNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitado.AutoSize = true;
			this.lblNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitado.ForeColor = System.Drawing.Color.Black;
			this.lblNomeVisitado.Location = new System.Drawing.Point(61, 240);
			this.lblNomeVisitado.Name = "lblNomeVisitado";
			this.lblNomeVisitado.Size = new System.Drawing.Size(132, 17);
			this.lblNomeVisitado.TabIndex = 5;
			this.lblNomeVisitado.Text = "Nome do visitado";
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.ForeColor = System.Drawing.Color.Black;
			this.lblPlaca.Location = new System.Drawing.Point(61, 350);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(127, 17);
			this.lblPlaca.TabIndex = 11;
			this.lblPlaca.Text = "Placa do veículo";
			// 
			// lblPeso
			// 
			this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPeso.AutoSize = true;
			this.lblPeso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeso.ForeColor = System.Drawing.Color.Black;
			this.lblPeso.Location = new System.Drawing.Point(61, 322);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(127, 17);
			this.lblPeso.TabIndex = 10;
			this.lblPeso.Text = "Peso de entrada";
			// 
			// lblCnpj
			// 
			this.lblCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCnpj.AutoSize = true;
			this.lblCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCnpj.ForeColor = System.Drawing.Color.Black;
			this.lblCnpj.Location = new System.Drawing.Point(61, 296);
			this.lblCnpj.Name = "lblCnpj";
			this.lblCnpj.Size = new System.Drawing.Size(41, 17);
			this.lblCnpj.TabIndex = 9;
			this.lblCnpj.Text = "Cnpj";
			// 
			// lblCpf
			// 
			this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpf.ForeColor = System.Drawing.Color.Black;
			this.lblCpf.Location = new System.Drawing.Point(61, 268);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(33, 17);
			this.lblCpf.TabIndex = 8;
			this.lblCpf.Text = "Cpf";
			// 
			// txtNomeVisitante
			// 
			this.txtNomeVisitante.AcceptsTab = true;
			this.txtNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitante.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtNomeVisitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomeVisitante.Location = new System.Drawing.Point(208, 212);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(343, 13);
			this.txtNomeVisitante.TabIndex = 12;
			// 
			// txtNomeVisitado
			// 
			this.txtNomeVisitado.AcceptsTab = true;
			this.txtNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtNomeVisitado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomeVisitado.Location = new System.Drawing.Point(208, 240);
			this.txtNomeVisitado.Name = "txtNomeVisitado";
			this.txtNomeVisitado.Size = new System.Drawing.Size(343, 13);
			this.txtNomeVisitado.TabIndex = 13;
			// 
			// txtPlacaVeiculo
			// 
			this.txtPlacaVeiculo.AcceptsTab = true;
			this.txtPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPlacaVeiculo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtPlacaVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPlacaVeiculo.Location = new System.Drawing.Point(208, 350);
			this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
			this.txtPlacaVeiculo.Size = new System.Drawing.Size(343, 13);
			this.txtPlacaVeiculo.TabIndex = 19;
			// 
			// txtPesoEntrada
			// 
			this.txtPesoEntrada.AcceptsTab = true;
			this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoEntrada.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtPesoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPesoEntrada.Location = new System.Drawing.Point(208, 322);
			this.txtPesoEntrada.Name = "txtPesoEntrada";
			this.txtPesoEntrada.Size = new System.Drawing.Size(343, 13);
			this.txtPesoEntrada.TabIndex = 18;
			// 
			// txtCnpj
			// 
			this.txtCnpj.AcceptsTab = true;
			this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCnpj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCnpj.Location = new System.Drawing.Point(208, 296);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(343, 13);
			this.txtCnpj.TabIndex = 17;
			// 
			// txtCpf
			// 
			this.txtCpf.AcceptsTab = true;
			this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCpf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCpf.Location = new System.Drawing.Point(208, 268);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(343, 13);
			this.txtCpf.TabIndex = 16;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCadastrar.BackColor = System.Drawing.Color.Navy;
			this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(301, 398);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
			this.btnCadastrar.TabIndex = 20;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.EfetuarEntrada);
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.lblTitulo);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(660, 61);
			this.nav.TabIndex = 27;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(237, 19);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(186, 22);
			this.lblTitulo.TabIndex = 5;
			this.lblTitulo.Text = "Entrada de pessoal";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelLineFooter
			// 
			this.panelLineFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panelLineFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelLineFooter.Location = new System.Drawing.Point(0, 456);
			this.panelLineFooter.Name = "panelLineFooter";
			this.panelLineFooter.Size = new System.Drawing.Size(660, 10);
			this.panelLineFooter.TabIndex = 30;
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.Navy;
			this.panelFooter.Controls.Add(this.lblFooter);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.ForeColor = System.Drawing.Color.White;
			this.panelFooter.Location = new System.Drawing.Point(0, 466);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(660, 36);
			this.panelFooter.TabIndex = 29;
			// 
			// lblFooter
			// 
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFooter.Location = new System.Drawing.Point(251, 12);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(158, 12);
			this.lblFooter.TabIndex = 1;
			this.lblFooter.Text = "Pta - Serviços terceirizados";
			this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 61);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 395);
			this.panel1.TabIndex = 31;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 10);
			this.panel2.TabIndex = 32;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(650, 71);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 385);
			this.panel3.TabIndex = 34;
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.BackColor = System.Drawing.Color.White;
			this.pctLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.pctLogo.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
			this.pctLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.pctLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.pctLogo.IconSize = 90;
			this.pctLogo.Location = new System.Drawing.Point(301, 98);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(90, 90);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 35;
			this.pctLogo.TabStop = false;
			// 
			// frmEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(660, 502);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelLineFooter);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtPlacaVeiculo);
			this.Controls.Add(this.txtPesoEntrada);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtNomeVisitado);
			this.Controls.Add(this.txtNomeVisitante);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblNomeVisitado);
			this.Controls.Add(this.lblNomeVisitante);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEntrada";
			this.Text = "Entrada";
			this.Load += new System.EventHandler(this.frmEntrada_Load);
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblNomeVisitante;
		private System.Windows.Forms.Label lblNomeVisitado;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.TextBox txtNomeVisitado;
		private System.Windows.Forms.TextBox txtPlacaVeiculo;
		private System.Windows.Forms.TextBox txtPesoEntrada;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel panelLineFooter;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Panel panel3;
		private FontAwesome.Sharp.IconPictureBox pctLogo;
	}
}

