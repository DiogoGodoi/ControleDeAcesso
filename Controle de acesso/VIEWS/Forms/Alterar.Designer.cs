namespace VIEWS.Forms
{
	partial class frmAlterar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterar));
			this.btnAlterarEntrada = new FontAwesome.Sharp.IconButton();
			this.txtNomeVisitado = new System.Windows.Forms.TextBox();
			this.lblNomeVisitado = new System.Windows.Forms.Label();
			this.txtTransportadora = new System.Windows.Forms.TextBox();
			this.lblTransportadora = new System.Windows.Forms.Label();
			this.pctLogo = new FontAwesome.Sharp.IconPictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblNatureza = new System.Windows.Forms.Label();
			this.nav = new System.Windows.Forms.Panel();
			this.hrSaida = new System.Windows.Forms.DateTimePicker();
			this.dtSaida = new System.Windows.Forms.DateTimePicker();
			this.lblDataEntrada = new System.Windows.Forms.Label();
			this.txtReferencia = new System.Windows.Forms.TextBox();
			this.lblReferencia = new System.Windows.Forms.Label();
			this.txtPesoSaida = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSaida = new System.Windows.Forms.Label();
			this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
			this.txtPesoEntrada = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblHoraEntrada = new System.Windows.Forms.Label();
			this.lblNomeVisitante = new System.Windows.Forms.Label();
			this.btnAlterarSaida = new FontAwesome.Sharp.IconButton();
			this.dtHoraEntrada = new System.Windows.Forms.DateTimePicker();
			this.dtEntrada = new System.Windows.Forms.DateTimePicker();
			this.cbNatureza = new System.Windows.Forms.ComboBox();
			this.btnBuscar = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.panelFooter.SuspendLayout();
			this.nav.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAlterarEntrada
			// 
			this.btnAlterarEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAlterarEntrada.BackColor = System.Drawing.Color.Navy;
			this.btnAlterarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterarEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterarEntrada.ForeColor = System.Drawing.Color.White;
			this.btnAlterarEntrada.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
			this.btnAlterarEntrada.IconColor = System.Drawing.Color.White;
			this.btnAlterarEntrada.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAlterarEntrada.IconSize = 16;
			this.btnAlterarEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterarEntrada.Location = new System.Drawing.Point(205, 552);
			this.btnAlterarEntrada.Name = "btnAlterarEntrada";
			this.btnAlterarEntrada.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnAlterarEntrada.Size = new System.Drawing.Size(191, 23);
			this.btnAlterarEntrada.TabIndex = 108;
			this.btnAlterarEntrada.Text = "Alterar Entrada";
			this.btnAlterarEntrada.UseVisualStyleBackColor = false;
			this.btnAlterarEntrada.Click += new System.EventHandler(this.AlterarEntrada);
			// 
			// txtNomeVisitado
			// 
			this.txtNomeVisitado.AcceptsTab = true;
			this.txtNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtNomeVisitado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomeVisitado.Enabled = false;
			this.txtNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeVisitado.Location = new System.Drawing.Point(243, 511);
			this.txtNomeVisitado.Name = "txtNomeVisitado";
			this.txtNomeVisitado.Size = new System.Drawing.Size(225, 16);
			this.txtNomeVisitado.TabIndex = 105;
			this.txtNomeVisitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblNomeVisitado
			// 
			this.lblNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitado.AutoSize = true;
			this.lblNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitado.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitado.Location = new System.Drawing.Point(98, 508);
			this.lblNomeVisitado.Name = "lblNomeVisitado";
			this.lblNomeVisitado.Size = new System.Drawing.Size(132, 17);
			this.lblNomeVisitado.TabIndex = 104;
			this.lblNomeVisitado.Text = "Nome do visitado";
			// 
			// txtTransportadora
			// 
			this.txtTransportadora.AcceptsTab = true;
			this.txtTransportadora.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTransportadora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtTransportadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTransportadora.Enabled = false;
			this.txtTransportadora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTransportadora.Location = new System.Drawing.Point(243, 318);
			this.txtTransportadora.Name = "txtTransportadora";
			this.txtTransportadora.Size = new System.Drawing.Size(225, 16);
			this.txtTransportadora.TabIndex = 103;
			this.txtTransportadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTransportadora
			// 
			this.lblTransportadora.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTransportadora.AutoSize = true;
			this.lblTransportadora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransportadora.ForeColor = System.Drawing.Color.Navy;
			this.lblTransportadora.Location = new System.Drawing.Point(98, 315);
			this.lblTransportadora.Name = "lblTransportadora";
			this.lblTransportadora.Size = new System.Drawing.Size(123, 17);
			this.lblTransportadora.TabIndex = 102;
			this.lblTransportadora.Text = "Transportadora";
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.BackColor = System.Drawing.Color.White;
			this.pctLogo.ForeColor = System.Drawing.Color.Navy;
			this.pctLogo.IconChar = FontAwesome.Sharp.IconChar.Spinner;
			this.pctLogo.IconColor = System.Drawing.Color.Navy;
			this.pctLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.pctLogo.IconSize = 90;
			this.pctLogo.Location = new System.Drawing.Point(384, 110);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(90, 90);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pctLogo.TabIndex = 101;
			this.pctLogo.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(807, 72);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 532);
			this.panel4.TabIndex = 100;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(807, 10);
			this.panel2.TabIndex = 99;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 542);
			this.panel1.TabIndex = 98;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 604);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(817, 10);
			this.panel3.TabIndex = 97;
			// 
			// lblFooter
			// 
			this.lblFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblFooter.AutoSize = true;
			this.lblFooter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFooter.Location = new System.Drawing.Point(341, 15);
			this.lblFooter.Name = "lblFooter";
			this.lblFooter.Size = new System.Drawing.Size(158, 12);
			this.lblFooter.TabIndex = 1;
			this.lblFooter.Text = "Pta - Serviços terceirizados";
			this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panelFooter.Controls.Add(this.lblFooter);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.ForeColor = System.Drawing.Color.White;
			this.panelFooter.Location = new System.Drawing.Point(0, 614);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(817, 36);
			this.panelFooter.TabIndex = 96;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(339, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(135, 22);
			this.lblTitulo.TabIndex = 48;
			this.lblTitulo.Text = "Alterar dados";
			// 
			// lblNatureza
			// 
			this.lblNatureza.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNatureza.AutoSize = true;
			this.lblNatureza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNatureza.ForeColor = System.Drawing.Color.Navy;
			this.lblNatureza.Location = new System.Drawing.Point(98, 478);
			this.lblNatureza.Name = "lblNatureza";
			this.lblNatureza.Size = new System.Drawing.Size(75, 17);
			this.lblNatureza.TabIndex = 106;
			this.lblNatureza.Text = "Natureza";
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.nav.Controls.Add(this.lblTitulo);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(817, 62);
			this.nav.TabIndex = 95;
			// 
			// hrSaida
			// 
			this.hrSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.hrSaida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hrSaida.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.hrSaida.CustomFormat = "hh:mm";
			this.hrSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hrSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.hrSaida.Location = new System.Drawing.Point(602, 318);
			this.hrSaida.Name = "hrSaida";
			this.hrSaida.ShowUpDown = true;
			this.hrSaida.Size = new System.Drawing.Size(108, 23);
			this.hrSaida.TabIndex = 94;
			// 
			// dtSaida
			// 
			this.dtSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtSaida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtSaida.Location = new System.Drawing.Point(602, 290);
			this.dtSaida.Name = "dtSaida";
			this.dtSaida.Size = new System.Drawing.Size(108, 23);
			this.dtSaida.TabIndex = 93;
			this.dtSaida.Value = new System.DateTime(2023, 3, 20, 15, 12, 48, 0);
			// 
			// lblDataEntrada
			// 
			this.lblDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDataEntrada.AutoSize = true;
			this.lblDataEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataEntrada.ForeColor = System.Drawing.Color.Navy;
			this.lblDataEntrada.Location = new System.Drawing.Point(98, 369);
			this.lblDataEntrada.Name = "lblDataEntrada";
			this.lblDataEntrada.Size = new System.Drawing.Size(125, 17);
			this.lblDataEntrada.TabIndex = 91;
			this.lblDataEntrada.Text = "Data da entrada";
			// 
			// txtReferencia
			// 
			this.txtReferencia.AcceptsTab = true;
			this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtReferencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtReferencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferencia.Location = new System.Drawing.Point(276, 228);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(347, 16);
			this.txtReferencia.TabIndex = 89;
			this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblReferencia
			// 
			this.lblReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblReferencia.AutoSize = true;
			this.lblReferencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReferencia.ForeColor = System.Drawing.Color.Navy;
			this.lblReferencia.Location = new System.Drawing.Point(98, 228);
			this.lblReferencia.Name = "lblReferencia";
			this.lblReferencia.Size = new System.Drawing.Size(172, 17);
			this.lblReferencia.TabIndex = 88;
			this.lblReferencia.Text = "Referência de entrada";
			// 
			// txtPesoSaida
			// 
			this.txtPesoSaida.AcceptsTab = true;
			this.txtPesoSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoSaida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtPesoSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPesoSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesoSaida.Location = new System.Drawing.Point(602, 344);
			this.txtPesoSaida.Name = "txtPesoSaida";
			this.txtPesoSaida.Size = new System.Drawing.Size(108, 16);
			this.txtPesoSaida.TabIndex = 87;
			this.txtPesoSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(479, 344);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 17);
			this.label1.TabIndex = 86;
			this.label1.Text = "Peso de saída";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(479, 318);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 17);
			this.label2.TabIndex = 85;
			this.label2.Text = "Hora da saída";
			// 
			// lblSaida
			// 
			this.lblSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSaida.AutoSize = true;
			this.lblSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaida.ForeColor = System.Drawing.Color.Navy;
			this.lblSaida.Location = new System.Drawing.Point(479, 290);
			this.lblSaida.Name = "lblSaida";
			this.lblSaida.Size = new System.Drawing.Size(107, 17);
			this.lblSaida.TabIndex = 84;
			this.lblSaida.Text = "Data da saída";
			// 
			// txtPlacaVeiculo
			// 
			this.txtPlacaVeiculo.AcceptsTab = true;
			this.txtPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPlacaVeiculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtPlacaVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPlacaVeiculo.Enabled = false;
			this.txtPlacaVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlacaVeiculo.Location = new System.Drawing.Point(243, 452);
			this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
			this.txtPlacaVeiculo.Size = new System.Drawing.Size(225, 16);
			this.txtPlacaVeiculo.TabIndex = 83;
			this.txtPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPesoEntrada
			// 
			this.txtPesoEntrada.AcceptsTab = true;
			this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoEntrada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtPesoEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPesoEntrada.Enabled = false;
			this.txtPesoEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesoEntrada.Location = new System.Drawing.Point(243, 424);
			this.txtPesoEntrada.Name = "txtPesoEntrada";
			this.txtPesoEntrada.Size = new System.Drawing.Size(225, 16);
			this.txtPesoEntrada.TabIndex = 82;
			this.txtPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCnpj
			// 
			this.txtCnpj.AcceptsTab = true;
			this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCnpj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCnpj.Enabled = false;
			this.txtCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCnpj.Location = new System.Drawing.Point(243, 344);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(225, 16);
			this.txtCnpj.TabIndex = 81;
			this.txtCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCpf
			// 
			this.txtCpf.AcceptsTab = true;
			this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCpf.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCpf.Enabled = false;
			this.txtCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(243, 290);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(225, 16);
			this.txtCpf.TabIndex = 79;
			this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtNomeVisitante
			// 
			this.txtNomeVisitante.AcceptsTab = true;
			this.txtNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtNomeVisitante.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomeVisitante.Enabled = false;
			this.txtNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeVisitante.Location = new System.Drawing.Point(243, 259);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(467, 16);
			this.txtNomeVisitante.TabIndex = 78;
			this.txtNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.ForeColor = System.Drawing.Color.Navy;
			this.lblPlaca.Location = new System.Drawing.Point(98, 449);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(127, 17);
			this.lblPlaca.TabIndex = 77;
			this.lblPlaca.Text = "Placa do veículo";
			// 
			// lblPeso
			// 
			this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPeso.AutoSize = true;
			this.lblPeso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeso.ForeColor = System.Drawing.Color.Navy;
			this.lblPeso.Location = new System.Drawing.Point(98, 421);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(127, 17);
			this.lblPeso.TabIndex = 76;
			this.lblPeso.Text = "Peso de entrada";
			// 
			// lblCnpj
			// 
			this.lblCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCnpj.AutoSize = true;
			this.lblCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCnpj.ForeColor = System.Drawing.Color.Navy;
			this.lblCnpj.Location = new System.Drawing.Point(98, 343);
			this.lblCnpj.Name = "lblCnpj";
			this.lblCnpj.Size = new System.Drawing.Size(41, 17);
			this.lblCnpj.TabIndex = 75;
			this.lblCnpj.Text = "Cnpj";
			// 
			// lblCpf
			// 
			this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpf.ForeColor = System.Drawing.Color.Navy;
			this.lblCpf.Location = new System.Drawing.Point(98, 289);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(33, 17);
			this.lblCpf.TabIndex = 74;
			this.lblCpf.Text = "Cpf";
			// 
			// lblHoraEntrada
			// 
			this.lblHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHoraEntrada.AutoSize = true;
			this.lblHoraEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoraEntrada.ForeColor = System.Drawing.Color.Navy;
			this.lblHoraEntrada.Location = new System.Drawing.Point(98, 395);
			this.lblHoraEntrada.Name = "lblHoraEntrada";
			this.lblHoraEntrada.Size = new System.Drawing.Size(127, 17);
			this.lblHoraEntrada.TabIndex = 73;
			this.lblHoraEntrada.Text = "Hora da entrada";
			// 
			// lblNomeVisitante
			// 
			this.lblNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitante.AutoSize = true;
			this.lblNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitante.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitante.Location = new System.Drawing.Point(98, 259);
			this.lblNomeVisitante.Name = "lblNomeVisitante";
			this.lblNomeVisitante.Size = new System.Drawing.Size(137, 17);
			this.lblNomeVisitante.TabIndex = 72;
			this.lblNomeVisitante.Text = "Nome do visitante";
			// 
			// btnAlterarSaida
			// 
			this.btnAlterarSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAlterarSaida.BackColor = System.Drawing.Color.Navy;
			this.btnAlterarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterarSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterarSaida.ForeColor = System.Drawing.Color.White;
			this.btnAlterarSaida.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
			this.btnAlterarSaida.IconColor = System.Drawing.Color.White;
			this.btnAlterarSaida.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAlterarSaida.IconSize = 20;
			this.btnAlterarSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlterarSaida.Location = new System.Drawing.Point(449, 552);
			this.btnAlterarSaida.Name = "btnAlterarSaida";
			this.btnAlterarSaida.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnAlterarSaida.Size = new System.Drawing.Size(191, 23);
			this.btnAlterarSaida.TabIndex = 109;
			this.btnAlterarSaida.Text = "Alterar Saida";
			this.btnAlterarSaida.UseVisualStyleBackColor = false;
			// 
			// dtHoraEntrada
			// 
			this.dtHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtHoraEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtHoraEntrada.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.dtHoraEntrada.CustomFormat = "hh:mm";
			this.dtHoraEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtHoraEntrada.Location = new System.Drawing.Point(243, 394);
			this.dtHoraEntrada.Name = "dtHoraEntrada";
			this.dtHoraEntrada.ShowUpDown = true;
			this.dtHoraEntrada.Size = new System.Drawing.Size(225, 23);
			this.dtHoraEntrada.TabIndex = 111;
			// 
			// dtEntrada
			// 
			this.dtEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtEntrada.Location = new System.Drawing.Point(243, 366);
			this.dtEntrada.Name = "dtEntrada";
			this.dtEntrada.Size = new System.Drawing.Size(225, 23);
			this.dtEntrada.TabIndex = 110;
			this.dtEntrada.Value = new System.DateTime(2023, 3, 20, 15, 12, 48, 0);
			// 
			// cbNatureza
			// 
			this.cbNatureza.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbNatureza.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.cbNatureza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbNatureza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbNatureza.FormattingEnabled = true;
			this.cbNatureza.Items.AddRange(new object[] {
            "Entrega",
            "Coleta",
            "Visita",
            "Entrevista"});
			this.cbNatureza.Location = new System.Drawing.Point(243, 478);
			this.cbNatureza.Name = "cbNatureza";
			this.cbNatureza.Size = new System.Drawing.Size(225, 23);
			this.cbNatureza.TabIndex = 112;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBuscar.BackColor = System.Drawing.Color.Navy;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
			this.btnBuscar.IconColor = System.Drawing.Color.White;
			this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnBuscar.IconSize = 18;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(629, 224);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(81, 23);
			this.btnBuscar.TabIndex = 113;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.Buscar);
			// 
			// frmAlterar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(817, 650);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.cbNatureza);
			this.Controls.Add(this.dtHoraEntrada);
			this.Controls.Add(this.dtEntrada);
			this.Controls.Add(this.btnAlterarSaida);
			this.Controls.Add(this.btnAlterarEntrada);
			this.Controls.Add(this.txtNomeVisitado);
			this.Controls.Add(this.lblNomeVisitado);
			this.Controls.Add(this.txtTransportadora);
			this.Controls.Add(this.lblTransportadora);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.lblNatureza);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.hrSaida);
			this.Controls.Add(this.dtSaida);
			this.Controls.Add(this.lblDataEntrada);
			this.Controls.Add(this.txtReferencia);
			this.Controls.Add(this.lblReferencia);
			this.Controls.Add(this.txtPesoSaida);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSaida);
			this.Controls.Add(this.txtPlacaVeiculo);
			this.Controls.Add(this.txtPesoEntrada);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtNomeVisitante);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblHoraEntrada);
			this.Controls.Add(this.lblNomeVisitante);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAlterar";
			this.Text = "Alterar";
			this.Load += new System.EventHandler(this.frmAlterar_Load);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FontAwesome.Sharp.IconButton btnAlterarEntrada;
		private System.Windows.Forms.TextBox txtNomeVisitado;
		private System.Windows.Forms.Label lblNomeVisitado;
		private System.Windows.Forms.TextBox txtTransportadora;
		private System.Windows.Forms.Label lblTransportadora;
		private FontAwesome.Sharp.IconPictureBox pctLogo;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Label lblNatureza;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.DateTimePicker hrSaida;
		private System.Windows.Forms.DateTimePicker dtSaida;
		private System.Windows.Forms.Label lblDataEntrada;
		private System.Windows.Forms.TextBox txtReferencia;
		private System.Windows.Forms.Label lblReferencia;
		private System.Windows.Forms.TextBox txtPesoSaida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSaida;
		private System.Windows.Forms.TextBox txtPlacaVeiculo;
		private System.Windows.Forms.TextBox txtPesoEntrada;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblHoraEntrada;
		private System.Windows.Forms.Label lblNomeVisitante;
		private FontAwesome.Sharp.IconButton btnAlterarSaida;
		private System.Windows.Forms.DateTimePicker dtHoraEntrada;
		private System.Windows.Forms.DateTimePicker dtEntrada;
		private System.Windows.Forms.ComboBox cbNatureza;
		private FontAwesome.Sharp.IconButton btnBuscar;
	}
}