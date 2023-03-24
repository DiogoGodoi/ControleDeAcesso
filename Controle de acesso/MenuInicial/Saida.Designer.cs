﻿namespace Saida
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
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
			this.txtPesoEntrada = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtNomeVisitado = new System.Windows.Forms.TextBox();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblNomeVisitado = new System.Windows.Forms.Label();
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
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.footer = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.nav.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.footer.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnVoltar
			// 
			this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Location = new System.Drawing.Point(449, 379);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(121, 23);
			this.btnVoltar.TabIndex = 39;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.Voltar);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCadastrar.BackColor = System.Drawing.Color.Navy;
			this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(281, 379);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
			this.btnCadastrar.TabIndex = 38;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.EfetuarSaida);
			// 
			// txtPlacaVeiculo
			// 
			this.txtPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPlacaVeiculo.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtPlacaVeiculo.Enabled = false;
			this.txtPlacaVeiculo.Location = new System.Drawing.Point(218, 332);
			this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
			this.txtPlacaVeiculo.Size = new System.Drawing.Size(189, 20);
			this.txtPlacaVeiculo.TabIndex = 37;
			// 
			// txtPesoEntrada
			// 
			this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoEntrada.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtPesoEntrada.Enabled = false;
			this.txtPesoEntrada.Location = new System.Drawing.Point(218, 304);
			this.txtPesoEntrada.Name = "txtPesoEntrada";
			this.txtPesoEntrada.Size = new System.Drawing.Size(189, 20);
			this.txtPesoEntrada.TabIndex = 36;
			// 
			// txtCnpj
			// 
			this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCnpj.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtCnpj.Enabled = false;
			this.txtCnpj.Location = new System.Drawing.Point(218, 224);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(189, 20);
			this.txtCnpj.TabIndex = 35;
			// 
			// txtCpf
			// 
			this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCpf.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtCpf.Enabled = false;
			this.txtCpf.Location = new System.Drawing.Point(218, 196);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(189, 20);
			this.txtCpf.TabIndex = 33;
			// 
			// txtNomeVisitado
			// 
			this.txtNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitado.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtNomeVisitado.Enabled = false;
			this.txtNomeVisitado.Location = new System.Drawing.Point(218, 170);
			this.txtNomeVisitado.Name = "txtNomeVisitado";
			this.txtNomeVisitado.Size = new System.Drawing.Size(189, 20);
			this.txtNomeVisitado.TabIndex = 31;
			// 
			// txtNomeVisitante
			// 
			this.txtNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitante.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtNomeVisitante.Enabled = false;
			this.txtNomeVisitante.Location = new System.Drawing.Point(218, 142);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(536, 20);
			this.txtNomeVisitante.TabIndex = 30;
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.ForeColor = System.Drawing.Color.Black;
			this.lblPlaca.Location = new System.Drawing.Point(60, 332);
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
			this.lblPeso.ForeColor = System.Drawing.Color.Black;
			this.lblPeso.Location = new System.Drawing.Point(60, 304);
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
			this.lblCnpj.ForeColor = System.Drawing.Color.Black;
			this.lblCnpj.Location = new System.Drawing.Point(60, 224);
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
			this.lblCpf.ForeColor = System.Drawing.Color.Black;
			this.lblCpf.Location = new System.Drawing.Point(60, 196);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(33, 17);
			this.lblCpf.TabIndex = 26;
			this.lblCpf.Text = "Cpf";
			// 
			// lblNomeVisitado
			// 
			this.lblNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitado.AutoSize = true;
			this.lblNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitado.ForeColor = System.Drawing.Color.Black;
			this.lblNomeVisitado.Location = new System.Drawing.Point(60, 170);
			this.lblNomeVisitado.Name = "lblNomeVisitado";
			this.lblNomeVisitado.Size = new System.Drawing.Size(132, 17);
			this.lblNomeVisitado.TabIndex = 23;
			this.lblNomeVisitado.Text = "Nome do visitado";
			// 
			// lblNomeVisitante
			// 
			this.lblNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitante.AutoSize = true;
			this.lblNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitante.ForeColor = System.Drawing.Color.Black;
			this.lblNomeVisitante.Location = new System.Drawing.Point(60, 142);
			this.lblNomeVisitante.Name = "lblNomeVisitante";
			this.lblNomeVisitante.Size = new System.Drawing.Size(137, 17);
			this.lblNomeVisitante.TabIndex = 22;
			this.lblNomeVisitante.Text = "Nome do visitante";
			// 
			// txtPesoSaida
			// 
			this.txtPesoSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoSaida.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtPesoSaida.Location = new System.Drawing.Point(554, 227);
			this.txtPesoSaida.Name = "txtPesoSaida";
			this.txtPesoSaida.Size = new System.Drawing.Size(200, 20);
			this.txtPesoSaida.TabIndex = 45;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(425, 227);
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
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(425, 201);
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
			this.lblSaida.ForeColor = System.Drawing.Color.Black;
			this.lblSaida.Location = new System.Drawing.Point(425, 173);
			this.lblSaida.Name = "lblSaida";
			this.lblSaida.Size = new System.Drawing.Size(107, 17);
			this.lblSaida.TabIndex = 40;
			this.lblSaida.Text = "Data da saída";
			// 
			// txtReferencia
			// 
			this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtReferencia.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtReferencia.Location = new System.Drawing.Point(328, 107);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(189, 20);
			this.txtReferencia.TabIndex = 49;
			// 
			// lblReferencia
			// 
			this.lblReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblReferencia.AutoSize = true;
			this.lblReferencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReferencia.ForeColor = System.Drawing.Color.Black;
			this.lblReferencia.Location = new System.Drawing.Point(141, 107);
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
			this.btnBuscar.Location = new System.Drawing.Point(538, 105);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(64, 23);
			this.btnBuscar.TabIndex = 50;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.Buscar);
			// 
			// txtDataEntrada
			// 
			this.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDataEntrada.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtDataEntrada.Enabled = false;
			this.txtDataEntrada.Location = new System.Drawing.Point(218, 252);
			this.txtDataEntrada.Name = "txtDataEntrada";
			this.txtDataEntrada.Size = new System.Drawing.Size(189, 20);
			this.txtDataEntrada.TabIndex = 52;
			// 
			// lblDataEntrada
			// 
			this.lblDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDataEntrada.AutoSize = true;
			this.lblDataEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataEntrada.ForeColor = System.Drawing.Color.Black;
			this.lblDataEntrada.Location = new System.Drawing.Point(60, 252);
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
			this.lblHoraEntrada.ForeColor = System.Drawing.Color.Black;
			this.lblHoraEntrada.Location = new System.Drawing.Point(60, 278);
			this.lblHoraEntrada.Name = "lblHoraEntrada";
			this.lblHoraEntrada.Size = new System.Drawing.Size(127, 17);
			this.lblHoraEntrada.TabIndex = 25;
			this.lblHoraEntrada.Text = "Hora da entrada";
			// 
			// txtHoraEntrada
			// 
			this.txtHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtHoraEntrada.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtHoraEntrada.Enabled = false;
			this.txtHoraEntrada.Location = new System.Drawing.Point(218, 278);
			this.txtHoraEntrada.Name = "txtHoraEntrada";
			this.txtHoraEntrada.Size = new System.Drawing.Size(189, 20);
			this.txtHoraEntrada.TabIndex = 34;
			// 
			// dtSaida
			// 
			this.dtSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtSaida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtSaida.Location = new System.Drawing.Point(554, 173);
			this.dtSaida.Name = "dtSaida";
			this.dtSaida.Size = new System.Drawing.Size(200, 20);
			this.dtSaida.TabIndex = 53;
			this.dtSaida.Value = new System.DateTime(2023, 3, 20, 15, 12, 48, 0);
			// 
			// hrSaida
			// 
			this.hrSaida.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hrSaida.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
			this.hrSaida.CustomFormat = "hh:mm";
			this.hrSaida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.hrSaida.Location = new System.Drawing.Point(554, 201);
			this.hrSaida.Name = "hrSaida";
			this.hrSaida.ShowUpDown = true;
			this.hrSaida.Size = new System.Drawing.Size(200, 20);
			this.hrSaida.TabIndex = 54;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.lblTitulo);
			this.nav.Controls.Add(this.pctLogo);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(800, 62);
			this.nav.TabIndex = 55;
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
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(318, 20);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(165, 22);
			this.lblTitulo.TabIndex = 48;
			this.lblTitulo.Text = "Saída de pessoal";
			// 
			// footer
			// 
			this.footer.BackColor = System.Drawing.Color.Maroon;
			this.footer.Controls.Add(this.label3);
			this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footer.Location = new System.Drawing.Point(0, 442);
			this.footer.Name = "footer";
			this.footer.Size = new System.Drawing.Size(800, 28);
			this.footer.TabIndex = 56;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Right;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(539, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(261, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Pta - Serviços terceirizados";
			// 
			// frmSaida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 470);
			this.Controls.Add(this.footer);
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
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtPlacaVeiculo);
			this.Controls.Add(this.txtPesoEntrada);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtHoraEntrada);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtNomeVisitado);
			this.Controls.Add(this.txtNomeVisitante);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblHoraEntrada);
			this.Controls.Add(this.lblNomeVisitado);
			this.Controls.Add(this.lblNomeVisitante);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSaida";
			this.Text = "Saída";
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.footer.ResumeLayout(false);
			this.footer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.TextBox txtPlacaVeiculo;
		private System.Windows.Forms.TextBox txtPesoEntrada;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.TextBox txtNomeVisitado;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblNomeVisitado;
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
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Panel footer;
		private System.Windows.Forms.Label label3;
	}
}

