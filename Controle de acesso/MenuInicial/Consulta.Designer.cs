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
			this.listEntrada = new System.Windows.Forms.ListView();
			this.ColRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colNomeVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colTransportadora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColNatureza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colVisitado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDataEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			this.colFinCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinTransportadora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPlacaVeiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinDataEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinDataSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinHoraSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPesoEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPesoSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinPesoSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinNatureza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinNomeVisitado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinUsuarioEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinUsuarioSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControle = new System.Windows.Forms.TabControl();
			this.tabEntrada = new System.Windows.Forms.TabPage();
			this.tabSaidas = new System.Windows.Forms.TabPage();
			this.tabAcessoFinalizado = new System.Windows.Forms.TabPage();
			this.lblDataBusca = new System.Windows.Forms.Label();
			this.dtBusca = new System.Windows.Forms.DateTimePicker();
			this.nav = new System.Windows.Forms.Panel();
			this.panelFooter = new System.Windows.Forms.Panel();
			this.lblFooter = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pctLogo = new FontAwesome.Sharp.IconPictureBox();
			this.btnBuscar = new FontAwesome.Sharp.IconButton();
			this.tabControle.SuspendLayout();
			this.tabEntrada.SuspendLayout();
			this.tabSaidas.SuspendLayout();
			this.tabAcessoFinalizado.SuspendLayout();
			this.nav.SuspendLayout();
			this.panelFooter.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHistorico
			// 
			this.lblHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHistorico.AutoSize = true;
			this.lblHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHistorico.ForeColor = System.Drawing.Color.White;
			this.lblHistorico.Location = new System.Drawing.Point(278, 21);
			this.lblHistorico.Name = "lblHistorico";
			this.lblHistorico.Size = new System.Drawing.Size(98, 22);
			this.lblHistorico.TabIndex = 5;
			this.lblHistorico.Text = "Consultar";
			// 
			// listEntrada
			// 
			this.listEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listEntrada.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColRef,
            this.colNomeVisitante,
            this.colCpf,
            this.colTransportadora,
            this.colCnpj,
            this.ColNatureza,
            this.colVisitado,
            this.colDataEntrada,
            this.colHoraEntrada,
            this.colPesoEntrada,
            this.colPlacaVeiculo,
            this.colIdUsuario});
			this.listEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listEntrada.ForeColor = System.Drawing.Color.Navy;
			this.listEntrada.FullRowSelect = true;
			this.listEntrada.GridLines = true;
			this.listEntrada.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listEntrada.HideSelection = false;
			this.listEntrada.Location = new System.Drawing.Point(3, 3);
			this.listEntrada.Name = "listEntrada";
			this.listEntrada.Size = new System.Drawing.Size(614, 239);
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
			// colCpf
			// 
			this.colCpf.Text = "Cpf";
			this.colCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colCpf.Width = 100;
			// 
			// colTransportadora
			// 
			this.colTransportadora.Text = "Transportadora";
			this.colTransportadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colTransportadora.Width = 100;
			// 
			// colCnpj
			// 
			this.colCnpj.Text = "Cnpj";
			this.colCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colCnpj.Width = 100;
			// 
			// ColNatureza
			// 
			this.ColNatureza.Text = "Natureza";
			this.ColNatureza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.listSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listSaida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSaidaRef,
            this.colSaidaNomeVisitante,
            this.colSaidaData,
            this.colSaidaHora,
            this.colSaidaPesoSaida,
            this.colSaidaIdUsuario});
			this.listSaida.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listSaida.ForeColor = System.Drawing.Color.Navy;
			this.listSaida.FullRowSelect = true;
			this.listSaida.GridLines = true;
			this.listSaida.HideSelection = false;
			this.listSaida.Location = new System.Drawing.Point(3, 3);
			this.listSaida.Name = "listSaida";
			this.listSaida.Size = new System.Drawing.Size(614, 239);
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
			this.listFinalizada.BackColor = System.Drawing.Color.White;
			this.listFinalizada.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listFinalizada.CausesValidation = false;
			this.listFinalizada.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFinRef,
            this.colFinNomeVisitante,
            this.colFinCpf,
            this.colFinTransportadora,
            this.colFinCnpj,
            this.colFinPlacaVeiculo,
            this.colFinDataEntrada,
            this.colFinDataSaida,
            this.colFinHoraEntrada,
            this.colFinHoraSaida,
            this.colFinPesoEntrada,
            this.colFinPesoSaida,
            this.colFinPesoSaldo,
            this.colFinNatureza,
            this.colFinNomeVisitado,
            this.colFinUsuarioEntrada,
            this.colFinUsuarioSaida});
			this.listFinalizada.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listFinalizada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listFinalizada.ForeColor = System.Drawing.Color.Navy;
			this.listFinalizada.FullRowSelect = true;
			this.listFinalizada.GridLines = true;
			this.listFinalizada.HideSelection = false;
			this.listFinalizada.Location = new System.Drawing.Point(3, 3);
			this.listFinalizada.Name = "listFinalizada";
			this.listFinalizada.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.listFinalizada.Size = new System.Drawing.Size(614, 239);
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
			this.colFinNomeVisitante.Width = 180;
			// 
			// colFinCpf
			// 
			this.colFinCpf.Text = "Cpf";
			this.colFinCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinCpf.Width = 80;
			// 
			// colFinTransportadora
			// 
			this.colFinTransportadora.Text = "Transportadora";
			this.colFinTransportadora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinTransportadora.Width = 180;
			// 
			// colFinCnpj
			// 
			this.colFinCnpj.Text = "Cnpj";
			this.colFinCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinCnpj.Width = 100;
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
			this.colFinDataEntrada.Width = 100;
			// 
			// colFinDataSaida
			// 
			this.colFinDataSaida.Text = "Data da saida";
			this.colFinDataSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinDataSaida.Width = 100;
			// 
			// colFinHoraEntrada
			// 
			this.colFinHoraEntrada.Text = "Hora da entrada";
			this.colFinHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinHoraEntrada.Width = 100;
			// 
			// colFinHoraSaida
			// 
			this.colFinHoraSaida.Text = "Hora da saída";
			this.colFinHoraSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinHoraSaida.Width = 100;
			// 
			// colFinPesoEntrada
			// 
			this.colFinPesoEntrada.Text = "Peso de entrada";
			this.colFinPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinPesoEntrada.Width = 100;
			// 
			// colFinPesoSaida
			// 
			this.colFinPesoSaida.Text = "Peso de saida";
			this.colFinPesoSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinPesoSaida.Width = 100;
			// 
			// colFinPesoSaldo
			// 
			this.colFinPesoSaldo.Text = "Peso real";
			this.colFinPesoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinPesoSaldo.Width = 100;
			// 
			// colFinNatureza
			// 
			this.colFinNatureza.Text = "Natureza";
			this.colFinNatureza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinNatureza.Width = 100;
			// 
			// colFinNomeVisitado
			// 
			this.colFinNomeVisitado.Text = "Visitado";
			this.colFinNomeVisitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colFinNomeVisitado.Width = 180;
			// 
			// colFinUsuarioEntrada
			// 
			this.colFinUsuarioEntrada.Text = "ID entrada";
			this.colFinUsuarioEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
			this.tabControle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControle.Location = new System.Drawing.Point(16, 185);
			this.tabControle.Multiline = true;
			this.tabControle.Name = "tabControle";
			this.tabControle.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabControle.SelectedIndex = 0;
			this.tabControle.Size = new System.Drawing.Size(628, 272);
			this.tabControle.TabIndex = 0;
			this.tabControle.Enter += new System.EventHandler(this.ExibirEntradaFinalizada);
			// 
			// tabEntrada
			// 
			this.tabEntrada.BackColor = System.Drawing.Color.White;
			this.tabEntrada.Controls.Add(this.listEntrada);
			this.tabEntrada.Location = new System.Drawing.Point(4, 23);
			this.tabEntrada.Name = "tabEntrada";
			this.tabEntrada.Padding = new System.Windows.Forms.Padding(3);
			this.tabEntrada.Size = new System.Drawing.Size(620, 245);
			this.tabEntrada.TabIndex = 0;
			this.tabEntrada.Text = "Entradas";
			this.tabEntrada.Click += new System.EventHandler(this.ExibirEntrada);
			this.tabEntrada.Enter += new System.EventHandler(this.ExibirEntrada);
			// 
			// tabSaidas
			// 
			this.tabSaidas.BackColor = System.Drawing.Color.White;
			this.tabSaidas.Controls.Add(this.listSaida);
			this.tabSaidas.Location = new System.Drawing.Point(4, 23);
			this.tabSaidas.Name = "tabSaidas";
			this.tabSaidas.Padding = new System.Windows.Forms.Padding(3);
			this.tabSaidas.Size = new System.Drawing.Size(620, 245);
			this.tabSaidas.TabIndex = 1;
			this.tabSaidas.Text = "Saídas";
			this.tabSaidas.Click += new System.EventHandler(this.ExibirSaida);
			this.tabSaidas.Enter += new System.EventHandler(this.ExibirSaida);
			// 
			// tabAcessoFinalizado
			// 
			this.tabAcessoFinalizado.BackColor = System.Drawing.Color.White;
			this.tabAcessoFinalizado.Controls.Add(this.listFinalizada);
			this.tabAcessoFinalizado.Location = new System.Drawing.Point(4, 23);
			this.tabAcessoFinalizado.Name = "tabAcessoFinalizado";
			this.tabAcessoFinalizado.Padding = new System.Windows.Forms.Padding(3);
			this.tabAcessoFinalizado.Size = new System.Drawing.Size(620, 245);
			this.tabAcessoFinalizado.TabIndex = 2;
			this.tabAcessoFinalizado.Text = "Acesso finalizado";
			this.tabAcessoFinalizado.Click += new System.EventHandler(this.ExibirEntradaFinalizada);
			// 
			// lblDataBusca
			// 
			this.lblDataBusca.AutoSize = true;
			this.lblDataBusca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataBusca.ForeColor = System.Drawing.Color.White;
			this.lblDataBusca.Location = new System.Drawing.Point(60, 410);
			this.lblDataBusca.Name = "lblDataBusca";
			this.lblDataBusca.Size = new System.Drawing.Size(112, 17);
			this.lblDataBusca.TabIndex = 24;
			this.lblDataBusca.Text = "Data da busca";
			// 
			// dtBusca
			// 
			this.dtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtBusca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtBusca.Location = new System.Drawing.Point(174, 477);
			this.dtBusca.Name = "dtBusca";
			this.dtBusca.Size = new System.Drawing.Size(127, 20);
			this.dtBusca.TabIndex = 25;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.Navy;
			this.nav.Controls.Add(this.lblHistorico);
			this.nav.Dock = System.Windows.Forms.DockStyle.Top;
			this.nav.Location = new System.Drawing.Point(0, 0);
			this.nav.Name = "nav";
			this.nav.Size = new System.Drawing.Size(660, 62);
			this.nav.TabIndex = 26;
			// 
			// panelFooter
			// 
			this.panelFooter.BackColor = System.Drawing.Color.Navy;
			this.panelFooter.Controls.Add(this.lblFooter);
			this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelFooter.ForeColor = System.Drawing.Color.White;
			this.panelFooter.Location = new System.Drawing.Point(0, 533);
			this.panelFooter.Name = "panelFooter";
			this.panelFooter.Size = new System.Drawing.Size(660, 36);
			this.panelFooter.TabIndex = 27;
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
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 523);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(660, 10);
			this.panel3.TabIndex = 33;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 62);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 10);
			this.panel2.TabIndex = 35;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(650, 72);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 451);
			this.panel4.TabIndex = 36;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 461);
			this.panel1.TabIndex = 34;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.pctLogo);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(10, 72);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(640, 100);
			this.panel5.TabIndex = 37;
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.BackColor = System.Drawing.Color.White;
			this.pctLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.pctLogo.IconChar = FontAwesome.Sharp.IconChar.Book;
			this.pctLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.pctLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.pctLogo.IconSize = 62;
			this.pctLogo.Location = new System.Drawing.Point(276, 19);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(90, 62);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pctLogo.TabIndex = 38;
			this.pctLogo.TabStop = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBuscar.BackColor = System.Drawing.Color.Navy;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
			this.btnBuscar.IconColor = System.Drawing.Color.White;
			this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnBuscar.IconSize = 18;
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(318, 477);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(81, 23);
			this.btnBuscar.TabIndex = 38;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(660, 569);
			this.ControlBox = false;
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panelFooter);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.tabControle);
			this.Controls.Add(this.dtBusca);
			this.Controls.Add(this.lblDataBusca);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsulta";
			this.Text = "Consulta";
			this.Load += new System.EventHandler(this.InicializacaoDefault);
			this.tabControle.ResumeLayout(false);
			this.tabEntrada.ResumeLayout(false);
			this.tabSaidas.ResumeLayout(false);
			this.tabAcessoFinalizado.ResumeLayout(false);
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			this.panelFooter.ResumeLayout(false);
			this.panelFooter.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHistorico;
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
		private System.Windows.Forms.Label lblDataBusca;
		private System.Windows.Forms.DateTimePicker dtBusca;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.Panel panelFooter;
		private System.Windows.Forms.Label lblFooter;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private FontAwesome.Sharp.IconPictureBox pctLogo;
		private System.Windows.Forms.ColumnHeader colTransportadora;
		private System.Windows.Forms.ColumnHeader colFinTransportadora;
		private System.Windows.Forms.ColumnHeader ColNatureza;
		private System.Windows.Forms.ColumnHeader colFinNatureza;
		private FontAwesome.Sharp.IconButton btnBuscar;
	}
}

