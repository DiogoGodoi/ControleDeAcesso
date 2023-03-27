﻿namespace Menu_Inicial
{
	partial class frmMenuInicial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInicial));
			this.panelSlideBar = new System.Windows.Forms.Panel();
			this.btnAlterar = new FontAwesome.Sharp.IconButton();
			this.btnSair = new FontAwesome.Sharp.IconButton();
			this.btnConsultar = new FontAwesome.Sharp.IconButton();
			this.btnSaida = new FontAwesome.Sharp.IconButton();
			this.btnEntrada = new FontAwesome.Sharp.IconButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.panelConteudo = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panelLineFooter = new System.Windows.Forms.Panel();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.lblMain = new System.Windows.Forms.Label();
			this.nav = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelSlideBar.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.panelConteudo.SuspendLayout();
			this.panelFooter.SuspendLayout();
			this.nav.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelSlideBar
			// 
			this.panelSlideBar.BackColor = System.Drawing.Color.Navy;
			this.panelSlideBar.Controls.Add(this.btnAlterar);
			this.panelSlideBar.Controls.Add(this.btnSair);
			this.panelSlideBar.Controls.Add(this.btnConsultar);
			this.panelSlideBar.Controls.Add(this.btnSaida);
			this.panelSlideBar.Controls.Add(this.btnEntrada);
			this.panelSlideBar.Controls.Add(this.panel1);
			this.panelSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSlideBar.Location = new System.Drawing.Point(0, 0);
			this.panelSlideBar.Name = "panelSlideBar";
			this.panelSlideBar.Size = new System.Drawing.Size(140, 502);
			this.panelSlideBar.TabIndex = 13;
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackColor = System.Drawing.Color.Red;
			this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ForeColor = System.Drawing.Color.White;
			this.btnAlterar.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
			this.btnAlterar.IconColor = System.Drawing.Color.White;
			this.btnAlterar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAlterar.IconSize = 30;
			this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterar.Location = new System.Drawing.Point(0, 196);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(140, 40);
			this.btnAlterar.TabIndex = 20;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = false;
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Red;
			this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.IconChar = FontAwesome.Sharp.IconChar.Xmark;
			this.btnSair.IconColor = System.Drawing.Color.White;
			this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSair.IconSize = 30;
			this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSair.Location = new System.Drawing.Point(0, 462);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(140, 40);
			this.btnSair.TabIndex = 19;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.Sair);
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.Red;
			this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.ForeColor = System.Drawing.Color.White;
			this.btnConsultar.IconChar = FontAwesome.Sharp.IconChar.Book;
			this.btnConsultar.IconColor = System.Drawing.Color.White;
			this.btnConsultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnConsultar.IconSize = 30;
			this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConsultar.Location = new System.Drawing.Point(0, 156);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(140, 40);
			this.btnConsultar.TabIndex = 18;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.TelaDeConsulta);
			// 
			// btnSaida
			// 
			this.btnSaida.BackColor = System.Drawing.Color.Red;
			this.btnSaida.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaida.ForeColor = System.Drawing.Color.White;
			this.btnSaida.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
			this.btnSaida.IconColor = System.Drawing.Color.White;
			this.btnSaida.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnSaida.IconSize = 35;
			this.btnSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaida.Location = new System.Drawing.Point(0, 116);
			this.btnSaida.Name = "btnSaida";
			this.btnSaida.Size = new System.Drawing.Size(140, 40);
			this.btnSaida.TabIndex = 16;
			this.btnSaida.Text = "Saída";
			this.btnSaida.UseVisualStyleBackColor = false;
			this.btnSaida.Click += new System.EventHandler(this.TelaDeSaida);
			// 
			// btnEntrada
			// 
			this.btnEntrada.BackColor = System.Drawing.Color.Red;
			this.btnEntrada.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrada.ForeColor = System.Drawing.Color.White;
			this.btnEntrada.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
			this.btnEntrada.IconColor = System.Drawing.Color.White;
			this.btnEntrada.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEntrada.IconSize = 30;
			this.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEntrada.Location = new System.Drawing.Point(0, 76);
			this.btnEntrada.Name = "btnEntrada";
			this.btnEntrada.Size = new System.Drawing.Size(140, 40);
			this.btnEntrada.TabIndex = 15;
			this.btnEntrada.Text = "Entrada";
			this.btnEntrada.UseVisualStyleBackColor = false;
			this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pctLogo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(140, 76);
			this.panel1.TabIndex = 14;
			// 
			// pctLogo
			// 
			this.pctLogo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(0, 0);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(140, 76);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 0;
			this.pctLogo.TabStop = false;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// panelConteudo
			// 
			this.panelConteudo.Controls.Add(this.panel3);
			this.panelConteudo.Controls.Add(this.panel2);
			this.panelConteudo.Controls.Add(this.panelLineFooter);
			this.panelConteudo.Controls.Add(this.panelFooter);
			this.panelConteudo.Controls.Add(this.lblMain);
			this.panelConteudo.Controls.Add(this.nav);
			this.panelConteudo.Controls.Add(this.pictureBox1);
			this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelConteudo.Location = new System.Drawing.Point(140, 0);
			this.panelConteudo.Name = "panelConteudo";
			this.panelConteudo.Size = new System.Drawing.Size(660, 502);
			this.panelConteudo.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(10, 44);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(650, 10);
			this.panel3.TabIndex = 34;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(10, 412);
			this.panel2.TabIndex = 33;
			// 
			// panelLineFooter
			// 
			this.panelLineFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panelLineFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelLineFooter.Location = new System.Drawing.Point(0, 456);
			this.panelLineFooter.Name = "panelLineFooter";
			this.panelLineFooter.Size = new System.Drawing.Size(660, 10);
			this.panelLineFooter.TabIndex = 32;
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
			this.panelFooter.TabIndex = 31;
			// 
			// lblFooter
			// 
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFooter.Location = new System.Drawing.Point(495, 15);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(158, 12);
			this.lblFooter.TabIndex = 0;
			this.lblFooter.Text = "Pta - Serviços terceirizados";
			// 
			// lblMain
			// 
			this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblMain.AutoSize = true;
			this.lblMain.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMain.ForeColor = System.Drawing.Color.Navy;
			this.lblMain.Location = new System.Drawing.Point(119, 95);
			this.lblMain.Name = "lblMain";
			this.lblMain.Size = new System.Drawing.Size(407, 37);
			this.lblMain.TabIndex = 29;
			this.lblMain.Text = "Controle de acesso - PTA";
			this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.lblTitulo);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(660, 44);
			this.nav.TabIndex = 28;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(304, 12);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(63, 22);
			this.lblTitulo.TabIndex = 5;
			this.lblTitulo.Text = "Home";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(186, 156);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(276, 263);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// frmMenuInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 502);
			this.ControlBox = false;
			this.Controls.Add(this.panelConteudo);
			this.Controls.Add(this.panelSlideBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMenuInicial";
			this.Text = "Menu inicial";
			this.Load += new System.EventHandler(this.frmMenuInicial_Load);
			this.panelSlideBar.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.panelConteudo.ResumeLayout(false);
			this.panelConteudo.PerformLayout();
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelSlideBar;
		private System.Windows.Forms.Panel panel1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.PictureBox pctLogo;
		private FontAwesome.Sharp.IconButton btnSair;
		private FontAwesome.Sharp.IconButton btnConsultar;
		private FontAwesome.Sharp.IconButton btnSaida;
		private FontAwesome.Sharp.IconButton btnEntrada;
		private System.Windows.Forms.Panel panelConteudo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblMain;
		private System.Windows.Forms.Panel panelLineFooter;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private FontAwesome.Sharp.IconButton btnAlterar;
	}
}

