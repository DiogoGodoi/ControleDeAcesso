namespace Menu_Inicial
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
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
			this.txtPesoEntrada = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.nav = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panelLineFooter = new System.Windows.Forms.Panel();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pctLogo = new FontAwesome.Sharp.IconPictureBox();
			this.lblCpf = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.lblTransportadora = new System.Windows.Forms.Label();
			this.txtTransportadora = new System.Windows.Forms.TextBox();
			this.lblNomeVisitado = new System.Windows.Forms.Label();
			this.txtNomeVisitado = new System.Windows.Forms.TextBox();
			this.lblNatureza = new System.Windows.Forms.Label();
			this.radEntrega = new System.Windows.Forms.RadioButton();
			this.radColeta = new System.Windows.Forms.RadioButton();
			this.radVisita = new System.Windows.Forms.RadioButton();
			this.btnCadastrar = new FontAwesome.Sharp.IconButton();
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
			this.lblNomeVisitante.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitante.Location = new System.Drawing.Point(84, 246);
			this.lblNomeVisitante.Name = "lblNomeVisitante";
			this.lblNomeVisitante.Size = new System.Drawing.Size(137, 17);
			this.lblNomeVisitante.TabIndex = 4;
			this.lblNomeVisitante.Text = "Nome do visitante";
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.ForeColor = System.Drawing.Color.Navy;
			this.lblPlaca.Location = new System.Drawing.Point(84, 437);
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
			this.lblPeso.ForeColor = System.Drawing.Color.Navy;
			this.lblPeso.Location = new System.Drawing.Point(84, 409);
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
			this.lblCnpj.ForeColor = System.Drawing.Color.Navy;
			this.lblCnpj.Location = new System.Drawing.Point(84, 327);
			this.lblCnpj.Name = "lblCnpj";
			this.lblCnpj.Size = new System.Drawing.Size(41, 17);
			this.lblCnpj.TabIndex = 9;
			this.lblCnpj.Text = "Cnpj";
			// 
			// txtNomeVisitante
			// 
			this.txtNomeVisitante.AcceptsTab = true;
			this.txtNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitante.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtNomeVisitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeVisitante.Location = new System.Drawing.Point(253, 249);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(296, 16);
			this.txtNomeVisitante.TabIndex = 12;
			this.txtNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPlacaVeiculo
			// 
			this.txtPlacaVeiculo.AcceptsTab = true;
			this.txtPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPlacaVeiculo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtPlacaVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPlacaVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlacaVeiculo.Location = new System.Drawing.Point(253, 440);
			this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
			this.txtPlacaVeiculo.Size = new System.Drawing.Size(296, 16);
			this.txtPlacaVeiculo.TabIndex = 19;
			this.txtPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPesoEntrada
			// 
			this.txtPesoEntrada.AcceptsTab = true;
			this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoEntrada.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtPesoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPesoEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesoEntrada.Location = new System.Drawing.Point(253, 412);
			this.txtPesoEntrada.Name = "txtPesoEntrada";
			this.txtPesoEntrada.Size = new System.Drawing.Size(296, 16);
			this.txtPesoEntrada.TabIndex = 18;
			this.txtPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCnpj
			// 
			this.txtCnpj.AcceptsTab = true;
			this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCnpj.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCnpj.Location = new System.Drawing.Point(253, 330);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(296, 16);
			this.txtCnpj.TabIndex = 17;
			this.txtCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.lblTitulo);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(660, 62);
			this.nav.TabIndex = 27;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(237, 20);
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
			this.panelLineFooter.Location = new System.Drawing.Point(0, 561);
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
			this.panelFooter.Location = new System.Drawing.Point(0, 571);
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
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 499);
			this.panel1.TabIndex = 31;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 10);
			this.panel2.TabIndex = 32;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel3.Location = new System.Drawing.Point(650, 72);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 489);
			this.panel3.TabIndex = 34;
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.BackColor = System.Drawing.Color.White;
			this.pctLogo.ForeColor = System.Drawing.Color.Navy;
			this.pctLogo.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
			this.pctLogo.IconColor = System.Drawing.Color.Navy;
			this.pctLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.pctLogo.IconSize = 90;
			this.pctLogo.Location = new System.Drawing.Point(301, 123);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(90, 90);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 35;
			this.pctLogo.TabStop = false;
			// 
			// lblCpf
			// 
			this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpf.ForeColor = System.Drawing.Color.Navy;
			this.lblCpf.Location = new System.Drawing.Point(84, 274);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(33, 17);
			this.lblCpf.TabIndex = 36;
			this.lblCpf.Text = "Cpf";
			// 
			// txtCpf
			// 
			this.txtCpf.AcceptsTab = true;
			this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCpf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(253, 277);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(296, 16);
			this.txtCpf.TabIndex = 37;
			this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTransportadora
			// 
			this.lblTransportadora.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTransportadora.AutoSize = true;
			this.lblTransportadora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransportadora.ForeColor = System.Drawing.Color.Navy;
			this.lblTransportadora.Location = new System.Drawing.Point(84, 300);
			this.lblTransportadora.Name = "lblTransportadora";
			this.lblTransportadora.Size = new System.Drawing.Size(123, 17);
			this.lblTransportadora.TabIndex = 38;
			this.lblTransportadora.Text = "Transportadora";
			// 
			// txtTransportadora
			// 
			this.txtTransportadora.AcceptsTab = true;
			this.txtTransportadora.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTransportadora.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtTransportadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTransportadora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTransportadora.Location = new System.Drawing.Point(253, 303);
			this.txtTransportadora.Name = "txtTransportadora";
			this.txtTransportadora.Size = new System.Drawing.Size(296, 16);
			this.txtTransportadora.TabIndex = 39;
			this.txtTransportadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblNomeVisitado
			// 
			this.lblNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitado.AutoSize = true;
			this.lblNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitado.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitado.Location = new System.Drawing.Point(84, 382);
			this.lblNomeVisitado.Name = "lblNomeVisitado";
			this.lblNomeVisitado.Size = new System.Drawing.Size(132, 17);
			this.lblNomeVisitado.TabIndex = 40;
			this.lblNomeVisitado.Text = "Nome do visitado";
			// 
			// txtNomeVisitado
			// 
			this.txtNomeVisitado.AcceptsTab = true;
			this.txtNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtNomeVisitado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeVisitado.Location = new System.Drawing.Point(253, 385);
			this.txtNomeVisitado.Name = "txtNomeVisitado";
			this.txtNomeVisitado.Size = new System.Drawing.Size(296, 16);
			this.txtNomeVisitado.TabIndex = 41;
			this.txtNomeVisitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblNatureza
			// 
			this.lblNatureza.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNatureza.AutoSize = true;
			this.lblNatureza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNatureza.ForeColor = System.Drawing.Color.Navy;
			this.lblNatureza.Location = new System.Drawing.Point(84, 356);
			this.lblNatureza.Name = "lblNatureza";
			this.lblNatureza.Size = new System.Drawing.Size(75, 17);
			this.lblNatureza.TabIndex = 42;
			this.lblNatureza.Text = "Natureza";
			// 
			// radEntrega
			// 
			this.radEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radEntrega.AutoSize = true;
			this.radEntrega.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radEntrega.ForeColor = System.Drawing.Color.Navy;
			this.radEntrega.Location = new System.Drawing.Point(253, 356);
			this.radEntrega.Name = "radEntrega";
			this.radEntrega.Size = new System.Drawing.Size(77, 19);
			this.radEntrega.TabIndex = 43;
			this.radEntrega.TabStop = true;
			this.radEntrega.Text = "Entrega";
			this.radEntrega.UseVisualStyleBackColor = true;
			this.radEntrega.CheckedChanged += new System.EventHandler(this.radEntrega_CheckedChanged);
			// 
			// radColeta
			// 
			this.radColeta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radColeta.AutoSize = true;
			this.radColeta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radColeta.ForeColor = System.Drawing.Color.Navy;
			this.radColeta.Location = new System.Drawing.Point(376, 356);
			this.radColeta.Name = "radColeta";
			this.radColeta.Size = new System.Drawing.Size(68, 19);
			this.radColeta.TabIndex = 44;
			this.radColeta.TabStop = true;
			this.radColeta.Text = "Coleta";
			this.radColeta.UseVisualStyleBackColor = true;
			this.radColeta.CheckedChanged += new System.EventHandler(this.radColeta_CheckedChanged);
			// 
			// radVisita
			// 
			this.radVisita.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radVisita.AutoSize = true;
			this.radVisita.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radVisita.ForeColor = System.Drawing.Color.Navy;
			this.radVisita.Location = new System.Drawing.Point(487, 356);
			this.radVisita.Name = "radVisita";
			this.radVisita.Size = new System.Drawing.Size(62, 19);
			this.radVisita.TabIndex = 45;
			this.radVisita.TabStop = true;
			this.radVisita.Text = "Visita";
			this.radVisita.UseVisualStyleBackColor = true;
			this.radVisita.CheckedChanged += new System.EventHandler(this.radVisita_CheckedChanged);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCadastrar.BackColor = System.Drawing.Color.Navy;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.Check;
			this.btnCadastrar.IconColor = System.Drawing.Color.White;
			this.btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnCadastrar.IconSize = 20;
			this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCadastrar.Location = new System.Drawing.Point(288, 479);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
			this.btnCadastrar.TabIndex = 46;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.EfetuarEntrada);
			// 
			// frmEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(660, 607);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.radVisita);
			this.Controls.Add(this.radColeta);
			this.Controls.Add(this.radEntrega);
			this.Controls.Add(this.lblNatureza);
			this.Controls.Add(this.lblNomeVisitado);
			this.Controls.Add(this.txtNomeVisitado);
			this.Controls.Add(this.lblTransportadora);
			this.Controls.Add(this.txtTransportadora);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.lblNomeVisitante);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtNomeVisitante);
			this.Controls.Add(this.panelLineFooter);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.txtPesoEntrada);
			this.Controls.Add(this.txtPlacaVeiculo);
			this.Controls.Add(this.txtCnpj);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEntrada";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.TextBox txtPlacaVeiculo;
		private System.Windows.Forms.TextBox txtPesoEntrada;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel panelLineFooter;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Panel panel3;
		private FontAwesome.Sharp.IconPictureBox pctLogo;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.Label lblTransportadora;
		private System.Windows.Forms.TextBox txtTransportadora;
		private System.Windows.Forms.Label lblNomeVisitado;
		private System.Windows.Forms.TextBox txtNomeVisitado;
		private System.Windows.Forms.Label lblNatureza;
		private System.Windows.Forms.RadioButton radEntrega;
		private System.Windows.Forms.RadioButton radColeta;
		private System.Windows.Forms.RadioButton radVisita;
		private FontAwesome.Sharp.IconButton btnCadastrar;
	}
}

