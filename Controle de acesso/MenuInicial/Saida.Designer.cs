namespace Saida
{
	partial class frmSaida
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaida));
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
			this.txtPesoEntrada = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblNomeVisitante = new System.Windows.Forms.Label();
			this.txtPesoSaida = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSaida = new System.Windows.Forms.Label();
			this.txtReferencia = new System.Windows.Forms.TextBox();
			this.lblReferencia = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtDataEntrada = new System.Windows.Forms.TextBox();
			this.lblDataEntrada = new System.Windows.Forms.Label();
			this.lblHoraEntrada = new System.Windows.Forms.Label();
			this.txtHoraEntrada = new System.Windows.Forms.TextBox();
			this.dtSaida = new System.Windows.Forms.DateTimePicker();
			this.hrSaida = new System.Windows.Forms.DateTimePicker();
			this.nav = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pctLogo = new FontAwesome.Sharp.IconPictureBox();
			this.txtTransportadora = new System.Windows.Forms.TextBox();
			this.lblTransportadora = new System.Windows.Forms.Label();
			this.txtNomeVisitado = new System.Windows.Forms.TextBox();
			this.lblNomeVisitado = new System.Windows.Forms.Label();
			this.txtNatureza = new System.Windows.Forms.TextBox();
			this.lblNatureza = new System.Windows.Forms.Label();
			this.nav.SuspendLayout();
			this.panelFooter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCadastrar.BackColor = System.Drawing.Color.Navy;
			this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(288, 579);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
			this.btnCadastrar.TabIndex = 38;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.EfetuarSaida);
			// 
			// txtPlacaVeiculo
			// 
			this.txtPlacaVeiculo.AcceptsTab = true;
			this.txtPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPlacaVeiculo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtPlacaVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPlacaVeiculo.Enabled = false;
			this.txtPlacaVeiculo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlacaVeiculo.Location = new System.Drawing.Point(205, 475);
			this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
			this.txtPlacaVeiculo.Size = new System.Drawing.Size(147, 16);
			this.txtPlacaVeiculo.TabIndex = 37;
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
			this.txtPesoEntrada.Location = new System.Drawing.Point(205, 447);
			this.txtPesoEntrada.Name = "txtPesoEntrada";
			this.txtPesoEntrada.Size = new System.Drawing.Size(147, 16);
			this.txtPesoEntrada.TabIndex = 36;
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
			this.txtCnpj.Location = new System.Drawing.Point(205, 367);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(147, 16);
			this.txtCnpj.TabIndex = 35;
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
			this.txtCpf.Location = new System.Drawing.Point(205, 313);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(147, 16);
			this.txtCpf.TabIndex = 33;
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
			this.txtNomeVisitante.Location = new System.Drawing.Point(205, 282);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(376, 16);
			this.txtNomeVisitante.TabIndex = 30;
			this.txtNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.ForeColor = System.Drawing.Color.Navy;
			this.lblPlaca.Location = new System.Drawing.Point(62, 472);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(127, 17);
			this.lblPlaca.TabIndex = 29;
			this.lblPlaca.Text = "Placa do veículo";
			// 
			// lblPeso
			// 
			this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPeso.AutoSize = true;
			this.lblPeso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeso.ForeColor = System.Drawing.Color.Navy;
			this.lblPeso.Location = new System.Drawing.Point(62, 444);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(127, 17);
			this.lblPeso.TabIndex = 28;
			this.lblPeso.Text = "Peso de entrada";
			// 
			// lblCnpj
			// 
			this.lblCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCnpj.AutoSize = true;
			this.lblCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCnpj.ForeColor = System.Drawing.Color.Navy;
			this.lblCnpj.Location = new System.Drawing.Point(62, 367);
			this.lblCnpj.Name = "lblCnpj";
			this.lblCnpj.Size = new System.Drawing.Size(41, 17);
			this.lblCnpj.TabIndex = 27;
			this.lblCnpj.Text = "Cnpj";
			// 
			// lblCpf
			// 
			this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpf.ForeColor = System.Drawing.Color.Navy;
			this.lblCpf.Location = new System.Drawing.Point(62, 313);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(33, 17);
			this.lblCpf.TabIndex = 26;
			this.lblCpf.Text = "Cpf";
			// 
			// lblNomeVisitante
			// 
			this.lblNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitante.AutoSize = true;
			this.lblNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitante.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitante.Location = new System.Drawing.Point(62, 282);
			this.lblNomeVisitante.Name = "lblNomeVisitante";
			this.lblNomeVisitante.Size = new System.Drawing.Size(137, 17);
			this.lblNomeVisitante.TabIndex = 22;
			this.lblNomeVisitante.Text = "Nome do visitante";
			// 
			// txtPesoSaida
			// 
			this.txtPesoSaida.AcceptsTab = true;
			this.txtPesoSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoSaida.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtPesoSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPesoSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesoSaida.Location = new System.Drawing.Point(487, 367);
			this.txtPesoSaida.Name = "txtPesoSaida";
			this.txtPesoSaida.Size = new System.Drawing.Size(94, 16);
			this.txtPesoSaida.TabIndex = 45;
			this.txtPesoSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(358, 367);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 17);
			this.label1.TabIndex = 42;
			this.label1.Text = "Peso de saída";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(358, 341);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 17);
			this.label2.TabIndex = 41;
			this.label2.Text = "Hora da saída";
			// 
			// lblSaida
			// 
			this.lblSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSaida.AutoSize = true;
			this.lblSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaida.ForeColor = System.Drawing.Color.Navy;
			this.lblSaida.Location = new System.Drawing.Point(358, 313);
			this.lblSaida.Name = "lblSaida";
			this.lblSaida.Size = new System.Drawing.Size(107, 17);
			this.lblSaida.TabIndex = 40;
			this.lblSaida.Text = "Data da saída";
			// 
			// txtReferencia
			// 
			this.txtReferencia.AcceptsTab = true;
			this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtReferencia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtReferencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReferencia.Location = new System.Drawing.Point(240, 251);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(271, 16);
			this.txtReferencia.TabIndex = 49;
			this.txtReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblReferencia
			// 
			this.lblReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblReferencia.AutoSize = true;
			this.lblReferencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReferencia.ForeColor = System.Drawing.Color.Navy;
			this.lblReferencia.Location = new System.Drawing.Point(62, 251);
			this.lblReferencia.Name = "lblReferencia";
			this.lblReferencia.Size = new System.Drawing.Size(172, 17);
			this.lblReferencia.TabIndex = 48;
			this.lblReferencia.Text = "Referência de entrada";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBuscar.BackColor = System.Drawing.Color.Navy;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(517, 249);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(64, 23);
			this.btnBuscar.TabIndex = 50;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.Buscar);
			// 
			// txtDataEntrada
			// 
			this.txtDataEntrada.AcceptsTab = true;
			this.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDataEntrada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtDataEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDataEntrada.Enabled = false;
			this.txtDataEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataEntrada.Location = new System.Drawing.Point(205, 395);
			this.txtDataEntrada.Name = "txtDataEntrada";
			this.txtDataEntrada.Size = new System.Drawing.Size(147, 16);
			this.txtDataEntrada.TabIndex = 52;
			this.txtDataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblDataEntrada
			// 
			this.lblDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDataEntrada.AutoSize = true;
			this.lblDataEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataEntrada.ForeColor = System.Drawing.Color.Navy;
			this.lblDataEntrada.Location = new System.Drawing.Point(62, 392);
			this.lblDataEntrada.Name = "lblDataEntrada";
			this.lblDataEntrada.Size = new System.Drawing.Size(125, 17);
			this.lblDataEntrada.TabIndex = 51;
			this.lblDataEntrada.Text = "Data da entrada";
			// 
			// lblHoraEntrada
			// 
			this.lblHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHoraEntrada.AutoSize = true;
			this.lblHoraEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoraEntrada.ForeColor = System.Drawing.Color.Navy;
			this.lblHoraEntrada.Location = new System.Drawing.Point(62, 418);
			this.lblHoraEntrada.Name = "lblHoraEntrada";
			this.lblHoraEntrada.Size = new System.Drawing.Size(127, 17);
			this.lblHoraEntrada.TabIndex = 25;
			this.lblHoraEntrada.Text = "Hora da entrada";
			// 
			// txtHoraEntrada
			// 
			this.txtHoraEntrada.AcceptsTab = true;
			this.txtHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtHoraEntrada.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtHoraEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtHoraEntrada.Enabled = false;
			this.txtHoraEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraEntrada.Location = new System.Drawing.Point(205, 421);
			this.txtHoraEntrada.Name = "txtHoraEntrada";
			this.txtHoraEntrada.Size = new System.Drawing.Size(147, 16);
			this.txtHoraEntrada.TabIndex = 34;
			this.txtHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtSaida
			// 
			this.dtSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtSaida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtSaida.Location = new System.Drawing.Point(487, 313);
			this.dtSaida.Name = "dtSaida";
			this.dtSaida.Size = new System.Drawing.Size(94, 20);
			this.dtSaida.TabIndex = 53;
			this.dtSaida.Value = new System.DateTime(2023, 3, 20, 15, 12, 48, 0);
			// 
			// hrSaida
			// 
			this.hrSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.hrSaida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hrSaida.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.hrSaida.CustomFormat = "hh:mm";
			this.hrSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.hrSaida.Location = new System.Drawing.Point(487, 341);
			this.hrSaida.Name = "hrSaida";
			this.hrSaida.ShowUpDown = true;
			this.hrSaida.Size = new System.Drawing.Size(94, 20);
			this.hrSaida.TabIndex = 54;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.lblTitulo);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(660, 62);
			this.nav.TabIndex = 55;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(248, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(165, 22);
			this.lblTitulo.TabIndex = 48;
			this.lblTitulo.Text = "Saída de pessoal";
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.Navy;
			this.panelFooter.Controls.Add(this.lblFooter);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.ForeColor = System.Drawing.Color.White;
			this.panelFooter.Location = new System.Drawing.Point(0, 653);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(660, 36);
			this.panelFooter.TabIndex = 56;
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 10);
			this.panel2.TabIndex = 60;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 581);
			this.panel1.TabIndex = 59;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 643);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(660, 10);
			this.panel3.TabIndex = 58;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(650, 72);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 571);
			this.panel4.TabIndex = 61;
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.BackColor = System.Drawing.Color.White;
			this.pctLogo.ForeColor = System.Drawing.Color.Navy;
			this.pctLogo.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowLoopLeft;
			this.pctLogo.IconColor = System.Drawing.Color.Navy;
			this.pctLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.pctLogo.IconSize = 90;
			this.pctLogo.Location = new System.Drawing.Point(298, 135);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(90, 90);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pctLogo.TabIndex = 62;
			this.pctLogo.TabStop = false;
			// 
			// txtTransportadora
			// 
			this.txtTransportadora.AcceptsTab = true;
			this.txtTransportadora.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTransportadora.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtTransportadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTransportadora.Enabled = false;
			this.txtTransportadora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTransportadora.Location = new System.Drawing.Point(205, 341);
			this.txtTransportadora.Name = "txtTransportadora";
			this.txtTransportadora.Size = new System.Drawing.Size(147, 16);
			this.txtTransportadora.TabIndex = 66;
			this.txtTransportadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTransportadora
			// 
			this.lblTransportadora.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTransportadora.AutoSize = true;
			this.lblTransportadora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTransportadora.ForeColor = System.Drawing.Color.Navy;
			this.lblTransportadora.Location = new System.Drawing.Point(62, 338);
			this.lblTransportadora.Name = "lblTransportadora";
			this.lblTransportadora.Size = new System.Drawing.Size(123, 17);
			this.lblTransportadora.TabIndex = 65;
			this.lblTransportadora.Text = "Transportadora";
			// 
			// txtNomeVisitado
			// 
			this.txtNomeVisitado.AcceptsTab = true;
			this.txtNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtNomeVisitado.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNomeVisitado.Enabled = false;
			this.txtNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeVisitado.Location = new System.Drawing.Point(205, 534);
			this.txtNomeVisitado.Name = "txtNomeVisitado";
			this.txtNomeVisitado.Size = new System.Drawing.Size(147, 16);
			this.txtNomeVisitado.TabIndex = 68;
			this.txtNomeVisitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblNomeVisitado
			// 
			this.lblNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitado.AutoSize = true;
			this.lblNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitado.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitado.Location = new System.Drawing.Point(62, 531);
			this.lblNomeVisitado.Name = "lblNomeVisitado";
			this.lblNomeVisitado.Size = new System.Drawing.Size(132, 17);
			this.lblNomeVisitado.TabIndex = 67;
			this.lblNomeVisitado.Text = "Nome do visitado";
			// 
			// txtNatureza
			// 
			this.txtNatureza.AcceptsTab = true;
			this.txtNatureza.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNatureza.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtNatureza.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtNatureza.Enabled = false;
			this.txtNatureza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNatureza.Location = new System.Drawing.Point(205, 504);
			this.txtNatureza.Name = "txtNatureza";
			this.txtNatureza.Size = new System.Drawing.Size(147, 16);
			this.txtNatureza.TabIndex = 70;
			this.txtNatureza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblNatureza
			// 
			this.lblNatureza.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNatureza.AutoSize = true;
			this.lblNatureza.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNatureza.ForeColor = System.Drawing.Color.Navy;
			this.lblNatureza.Location = new System.Drawing.Point(62, 501);
			this.lblNatureza.Name = "lblNatureza";
			this.lblNatureza.Size = new System.Drawing.Size(75, 17);
			this.lblNatureza.TabIndex = 69;
			this.lblNatureza.Text = "Natureza";
			// 
			// frmSaida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(660, 689);
			this.Controls.Add(this.txtNatureza);
			this.Controls.Add(this.lblNatureza);
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
			this.Controls.Add(this.nav);
			this.Controls.Add(this.hrSaida);
			this.Controls.Add(this.dtSaida);
			this.Controls.Add(this.txtDataEntrada);
			this.Controls.Add(this.lblDataEntrada);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtReferencia);
			this.Controls.Add(this.lblReferencia);
			this.Controls.Add(this.txtPesoSaida);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSaida);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtPlacaVeiculo);
			this.Controls.Add(this.txtPesoEntrada);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtHoraEntrada);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtNomeVisitante);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblHoraEntrada);
			this.Controls.Add(this.lblNomeVisitante);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ForeColor = System.Drawing.Color.Navy;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSaida";
			this.Text = "Saída";
			this.Load += new System.EventHandler(this.frmSaida_Load);
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.TextBox txtPlacaVeiculo;
		private System.Windows.Forms.TextBox txtPesoEntrada;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblNomeVisitante;
		private System.Windows.Forms.TextBox txtPesoSaida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSaida;
		private System.Windows.Forms.TextBox txtReferencia;
		private System.Windows.Forms.Label lblReferencia;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtDataEntrada;
		private System.Windows.Forms.Label lblDataEntrada;
		private System.Windows.Forms.Label lblHoraEntrada;
		private System.Windows.Forms.TextBox txtHoraEntrada;
		private System.Windows.Forms.DateTimePicker dtSaida;
		private System.Windows.Forms.DateTimePicker hrSaida;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Panel panel4;
		private FontAwesome.Sharp.IconPictureBox pctLogo;
		private System.Windows.Forms.TextBox txtTransportadora;
		private System.Windows.Forms.Label lblTransportadora;
		private System.Windows.Forms.TextBox txtNomeVisitado;
		private System.Windows.Forms.Label lblNomeVisitado;
		private System.Windows.Forms.TextBox txtNatureza;
		private System.Windows.Forms.Label lblNatureza;
	}
}

