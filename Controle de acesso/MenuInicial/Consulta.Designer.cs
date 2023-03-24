namespace Menu_Inicial
{
	partial class frmConsulta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
			this.lblHistorico = new System.Windows.Forms.Label();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.listEntrada = new System.Windows.Forms.ListView();
			this.ColRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNomeVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colVisitado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDataEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPesoEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPlacaVeiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colIdUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listSaida = new System.Windows.Forms.ListView();
			this.colSaidaRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSaidaNomeVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSaidaData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSaidaHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSaidaPesoSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSaidaIdUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listFinalizada = new System.Windows.Forms.ListView();
			this.colFinRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinNomeVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinNomeVisitado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPlacaVeiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinDataEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinDataSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinHoraSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPesoEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPesoSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPesoSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinUsuarioEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinUsuarioSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControle = new System.Windows.Forms.TabControl();
			this.tabEntrada = new System.Windows.Forms.TabPage();
			this.tabSaidas = new System.Windows.Forms.TabPage();
			this.tabAcessoFinalizado = new System.Windows.Forms.TabPage();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.lblDataBusca = new System.Windows.Forms.Label();
			this.dtBusca = new System.Windows.Forms.DateTimePicker();
			this.nav = new System.Windows.Forms.Panel();
			this.footer = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.tabControle.SuspendLayout();
			this.tabEntrada.SuspendLayout();
			this.tabSaidas.SuspendLayout();
			this.tabAcessoFinalizado.SuspendLayout();
			this.nav.SuspendLayout();
			this.footer.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblHistorico
			// 
			this.lblHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHistorico.AutoSize = true;
			this.lblHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHistorico.ForeColor = System.Drawing.Color.White;
			this.lblHistorico.Location = new System.Drawing.Point(570, 21);
			this.lblHistorico.Name = "lblHistorico";
			this.lblHistorico.Size = new System.Drawing.Size(98, 22);
			this.lblHistorico.TabIndex = 5;
			this.lblHistorico.Text = "Consultar";
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
			// listEntrada
			// 
			this.listEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listEntrada.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColRef,
            this.colNomeVisitante,
            this.colVisitado,
            this.colDataEntrada,
            this.colHoraEntrada,
            this.colCpf,
            this.colCnpj,
            this.colPesoEntrada,
            this.colPlacaVeiculo,
            this.colIdUsuario});
			this.listEntrada.HideSelection = false;
			this.listEntrada.Location = new System.Drawing.Point(3, 3);
			this.listEntrada.Name = "listEntrada";
			this.listEntrada.Size = new System.Drawing.Size(1231, 256);
			this.listEntrada.TabIndex = 26;
			this.listEntrada.UseCompatibleStateImageBehavior = false;
			this.listEntrada.View = System.Windows.Forms.View.Details;
			// 
			// ColRef
			// 
			this.ColRef.Text = "Ref";
			this.ColRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColRef.Width = 80;
			// 
			// colNomeVisitante
			// 
			this.colNomeVisitante.Text = "Nome do Visitante";
			this.colNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colNomeVisitante.Width = 232;
			// 
			// colVisitado
			// 
			this.colVisitado.Text = "Visitado";
			this.colVisitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colVisitado.Width = 232;
			// 
			// colDataEntrada
			// 
			this.colDataEntrada.Text = "Data da Entrada";
			this.colDataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colDataEntrada.Width = 100;
			// 
			// colHoraEntrada
			// 
			this.colHoraEntrada.Text = "Hora da Entrada";
			this.colHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colHoraEntrada.Width = 100;
			// 
			// colCpf
			// 
			this.colCpf.Text = "Cpf";
			this.colCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colCpf.Width = 100;
			// 
			// colCnpj
			// 
			this.colCnpj.Text = "Cnpj";
			this.colCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colCnpj.Width = 100;
			// 
			// colPesoEntrada
			// 
			this.colPesoEntrada.Text = "Peso de Entrada";
			this.colPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colPesoEntrada.Width = 100;
			// 
			// colPlacaVeiculo
			// 
			this.colPlacaVeiculo.Text = "Placa do Veiculo";
			this.colPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colPlacaVeiculo.Width = 100;
			// 
			// colIdUsuario
			// 
			this.colIdUsuario.Text = "Id Usuario";
			this.colIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colIdUsuario.Width = 80;
			// 
			// listSaida
			// 
			this.listSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listSaida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSaidaRef,
            this.colSaidaNomeVisitante,
            this.colSaidaData,
            this.colSaidaHora,
            this.colSaidaPesoSaida,
            this.colSaidaIdUsuario});
			this.listSaida.HideSelection = false;
			this.listSaida.Location = new System.Drawing.Point(3, 3);
			this.listSaida.Name = "listSaida";
			this.listSaida.Size = new System.Drawing.Size(1231, 256);
			this.listSaida.TabIndex = 27;
			this.listSaida.UseCompatibleStateImageBehavior = false;
			this.listSaida.View = System.Windows.Forms.View.Details;
			// 
			// colSaidaRef
			// 
			this.colSaidaRef.Text = "Ref";
			this.colSaidaRef.Width = 80;
			// 
			// colSaidaNomeVisitante
			// 
			this.colSaidaNomeVisitante.Text = "Nome do Visitante";
			this.colSaidaNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colSaidaNomeVisitante.Width = 685;
			// 
			// colSaidaData
			// 
			this.colSaidaData.Text = "Data da Saida";
			this.colSaidaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colSaidaData.Width = 200;
			// 
			// colSaidaHora
			// 
			this.colSaidaHora.Text = "Hora da Saida";
			this.colSaidaHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colSaidaHora.Width = 100;
			// 
			// colSaidaPesoSaida
			// 
			this.colSaidaPesoSaida.Text = "Peso de Saida";
			this.colSaidaPesoSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colSaidaPesoSaida.Width = 100;
			// 
			// colSaidaIdUsuario
			// 
			this.colSaidaIdUsuario.Text = "Id Usuario";
			// 
			// listFinalizada
			// 
			this.listFinalizada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listFinalizada.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFinRef,
            this.colFinNomeVisitante,
            this.colFinNomeVisitado,
            this.colFinCnpj,
            this.colFinCpf,
            this.colFinPlacaVeiculo,
            this.colFinDataEntrada,
            this.colFinDataSaida,
            this.colFinHoraEntrada,
            this.colFinHoraSaida,
            this.colFinPesoEntrada,
            this.colFinPesoSaida,
            this.colFinPesoSaldo,
            this.colFinUsuarioEntrada,
            this.colFinUsuarioSaida});
			this.listFinalizada.HideSelection = false;
			this.listFinalizada.Location = new System.Drawing.Point(3, 3);
			this.listFinalizada.Name = "listFinalizada";
			this.listFinalizada.Size = new System.Drawing.Size(1228, 256);
			this.listFinalizada.TabIndex = 28;
			this.listFinalizada.UseCompatibleStateImageBehavior = false;
			this.listFinalizada.View = System.Windows.Forms.View.Details;
			// 
			// colFinRef
			// 
			this.colFinRef.Text = "Ref";
			this.colFinRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinRef.Width = 50;
			// 
			// colFinNomeVisitante
			// 
			this.colFinNomeVisitante.Text = "Nome do Visitante";
			this.colFinNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinNomeVisitante.Width = 163;
			// 
			// colFinNomeVisitado
			// 
			this.colFinNomeVisitado.Text = "Visitado";
			this.colFinNomeVisitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinNomeVisitado.Width = 163;
			// 
			// colFinCnpj
			// 
			this.colFinCnpj.Text = "Cnpj";
			this.colFinCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinCnpj.Width = 100;
			// 
			// colFinCpf
			// 
			this.colFinCpf.Text = "Cpf";
			this.colFinCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinCpf.Width = 80;
			// 
			// colFinPlacaVeiculo
			// 
			this.colFinPlacaVeiculo.Text = "Placa do veículo";
			this.colFinPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinPlacaVeiculo.Width = 100;
			// 
			// colFinDataEntrada
			// 
			this.colFinDataEntrada.Text = "Data da entrada";
			this.colFinDataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinDataEntrada.Width = 90;
			// 
			// colFinDataSaida
			// 
			this.colFinDataSaida.Text = "Data da saida";
			this.colFinDataSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinDataSaida.Width = 80;
			// 
			// colFinHoraEntrada
			// 
			this.colFinHoraEntrada.Text = "Hora da entrada";
			this.colFinHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinHoraEntrada.Width = 90;
			// 
			// colFinHoraSaida
			// 
			this.colFinHoraSaida.Text = "Hora da saída";
			this.colFinHoraSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinHoraSaida.Width = 80;
			// 
			// colFinPesoEntrada
			// 
			this.colFinPesoEntrada.Text = "Peso de entrada";
			this.colFinPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinPesoEntrada.Width = 90;
			// 
			// colFinPesoSaida
			// 
			this.colFinPesoSaida.Text = "Peso de saida";
			this.colFinPesoSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinPesoSaida.Width = 80;
			// 
			// colFinPesoSaldo
			// 
			this.colFinPesoSaldo.Text = "Peso real";
			// 
			// colFinUsuarioEntrada
			// 
			this.colFinUsuarioEntrada.Text = "ID entrada";
			this.colFinUsuarioEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinUsuarioEntrada.Width = 65;
			// 
			// colFinUsuarioSaida
			// 
			this.colFinUsuarioSaida.Text = "ID saída";
			this.colFinUsuarioSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabControle
			// 
			this.tabControle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControle.Controls.Add(this.tabEntrada);
			this.tabControle.Controls.Add(this.tabSaidas);
			this.tabControle.Controls.Add(this.tabAcessoFinalizado);
			this.tabControle.Location = new System.Drawing.Point(0, 103);
			this.tabControle.Name = "tabControle";
			this.tabControle.SelectedIndex = 0;
			this.tabControle.Size = new System.Drawing.Size(1245, 288);
			this.tabControle.TabIndex = 0;
			this.tabControle.Enter += new System.EventHandler(this.ExibirEntradaFinalizada);
			// 
			// tabEntrada
			// 
			this.tabEntrada.BackColor = System.Drawing.Color.White;
			this.tabEntrada.Controls.Add(this.listEntrada);
			this.tabEntrada.Location = new System.Drawing.Point(4, 22);
			this.tabEntrada.Name = "tabEntrada";
			this.tabEntrada.Padding = new System.Windows.Forms.Padding(3);
			this.tabEntrada.Size = new System.Drawing.Size(1237, 262);
			this.tabEntrada.TabIndex = 0;
			this.tabEntrada.Text = "Entradas";
			this.tabEntrada.Click += new System.EventHandler(this.ExibirEntrada);
			this.tabEntrada.Enter += new System.EventHandler(this.ExibirEntrada);
			// 
			// tabSaidas
			// 
			this.tabSaidas.BackColor = System.Drawing.Color.White;
			this.tabSaidas.Controls.Add(this.listSaida);
			this.tabSaidas.Location = new System.Drawing.Point(4, 22);
			this.tabSaidas.Name = "tabSaidas";
			this.tabSaidas.Padding = new System.Windows.Forms.Padding(3);
			this.tabSaidas.Size = new System.Drawing.Size(1237, 262);
			this.tabSaidas.TabIndex = 1;
			this.tabSaidas.Text = "Saídas";
			this.tabSaidas.Click += new System.EventHandler(this.ExibirSaida);
			this.tabSaidas.Enter += new System.EventHandler(this.ExibirSaida);
			// 
			// tabAcessoFinalizado
			// 
			this.tabAcessoFinalizado.BackColor = System.Drawing.Color.White;
			this.tabAcessoFinalizado.Controls.Add(this.listFinalizada);
			this.tabAcessoFinalizado.Location = new System.Drawing.Point(4, 22);
			this.tabAcessoFinalizado.Name = "tabAcessoFinalizado";
			this.tabAcessoFinalizado.Padding = new System.Windows.Forms.Padding(3);
			this.tabAcessoFinalizado.Size = new System.Drawing.Size(1237, 262);
			this.tabAcessoFinalizado.TabIndex = 2;
			this.tabAcessoFinalizado.Text = "Acesso finalizado";
			this.tabAcessoFinalizado.Click += new System.EventHandler(this.ExibirEntradaFinalizada);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBuscar.BackColor = System.Drawing.Color.Navy;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(311, 413);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(81, 23);
			this.btnBuscar.TabIndex = 22;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.Buscar);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Location = new System.Drawing.Point(407, 413);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(81, 23);
			this.btnVoltar.TabIndex = 23;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.Voltar);
			// 
			// lblDataBusca
			// 
			this.lblDataBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblDataBusca.AutoSize = true;
			this.lblDataBusca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataBusca.ForeColor = System.Drawing.Color.White;
			this.lblDataBusca.Location = new System.Drawing.Point(60, 415);
			this.lblDataBusca.Name = "lblDataBusca";
			this.lblDataBusca.Size = new System.Drawing.Size(112, 17);
			this.lblDataBusca.TabIndex = 24;
			this.lblDataBusca.Text = "Data da busca";
			// 
			// dtBusca
			// 
			this.dtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtBusca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtBusca.Location = new System.Drawing.Point(174, 415);
			this.dtBusca.Name = "dtBusca";
			this.dtBusca.Size = new System.Drawing.Size(127, 20);
			this.dtBusca.TabIndex = 25;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.pctLogo);
			this.nav.Controls.Add(this.lblHistorico);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(1245, 62);
			this.nav.TabIndex = 26;
			// 
			// footer
			// 
			this.footer.BackColor = System.Drawing.Color.Maroon;
			this.footer.Controls.Add(this.label1);
			this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footer.Location = new System.Drawing.Point(0, 479);
			this.footer.Name = "footer";
			this.footer.Size = new System.Drawing.Size(1245, 28);
			this.footer.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Right;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(984, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 22);
			this.label1.TabIndex = 6;
			this.label1.Text = "Pta - Serviços terceirizados";
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1245, 507);
			this.ControlBox = false;
			this.Controls.Add(this.footer);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.tabControle);
			this.Controls.Add(this.dtBusca);
			this.Controls.Add(this.lblDataBusca);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnBuscar);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsulta";
			this.Text = "Consulta";
			this.Load += new System.EventHandler(this.InicializacaoDefault);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.tabControle.ResumeLayout(false);
			this.tabEntrada.ResumeLayout(false);
			this.tabSaidas.ResumeLayout(false);
			this.tabAcessoFinalizado.ResumeLayout(false);
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			this.footer.ResumeLayout(false);
			this.footer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHistorico;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.ListView listEntrada;
		private System.Windows.Forms.ColumnHeader colNomeVisitante;
		private System.Windows.Forms.ColumnHeader colVisitado;
		private System.Windows.Forms.ColumnHeader colDataEntrada;
		private System.Windows.Forms.ColumnHeader colHoraEntrada;
		private System.Windows.Forms.ColumnHeader colCpf;
		private System.Windows.Forms.ColumnHeader colCnpj;
		private System.Windows.Forms.ColumnHeader colPesoEntrada;
		private System.Windows.Forms.ColumnHeader colPlacaVeiculo;
		private System.Windows.Forms.ColumnHeader colIdUsuario;
		private System.Windows.Forms.ColumnHeader ColRef;
		private System.Windows.Forms.ListView listSaida;
		private System.Windows.Forms.ColumnHeader colSaidaIdUsuario;
		private System.Windows.Forms.ColumnHeader colSaidaRef;
		private System.Windows.Forms.ColumnHeader colSaidaNomeVisitante;
		private System.Windows.Forms.ColumnHeader colSaidaData;
		private System.Windows.Forms.ColumnHeader colSaidaHora;
		private System.Windows.Forms.ColumnHeader colSaidaPesoSaida;
		private System.Windows.Forms.ListView listFinalizada;
		private System.Windows.Forms.ColumnHeader colFinRef;
		private System.Windows.Forms.ColumnHeader colFinNomeVisitante;
		private System.Windows.Forms.ColumnHeader colFinNomeVisitado;
		private System.Windows.Forms.ColumnHeader colFinCnpj;
		private System.Windows.Forms.ColumnHeader colFinCpf;
		private System.Windows.Forms.ColumnHeader colFinPlacaVeiculo;
		private System.Windows.Forms.ColumnHeader colFinDataEntrada;
		private System.Windows.Forms.ColumnHeader colFinDataSaida;
		private System.Windows.Forms.ColumnHeader colFinHoraEntrada;
		private System.Windows.Forms.ColumnHeader colFinHoraSaida;
		private System.Windows.Forms.ColumnHeader colFinPesoEntrada;
		private System.Windows.Forms.ColumnHeader colFinPesoSaida;
		private System.Windows.Forms.ColumnHeader colFinUsuarioEntrada;
		private System.Windows.Forms.ColumnHeader colFinUsuarioSaida;
		private System.Windows.Forms.ColumnHeader colFinPesoSaldo;
		private System.Windows.Forms.TabControl tabControle;
		private System.Windows.Forms.TabPage tabEntrada;
		private System.Windows.Forms.TabPage tabSaidas;
		private System.Windows.Forms.TabPage tabAcessoFinalizado;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Label lblDataBusca;
		private System.Windows.Forms.DateTimePicker dtBusca;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.Panel footer;
		private System.Windows.Forms.Label label1;
	}
}

