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
			this.radEntrada = new System.Windows.Forms.RadioButton();
			this.radSaida = new System.Windows.Forms.RadioButton();
			this.Todos = new System.Windows.Forms.RadioButton();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblDataBusca = new System.Windows.Forms.Label();
			this.dtBusca = new System.Windows.Forms.DateTimePicker();
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
			this.colFinUsuarioEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colFinUsuarioSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHistorico
			// 
			this.lblHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHistorico.AutoSize = true;
			this.lblHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHistorico.ForeColor = System.Drawing.Color.Navy;
			this.lblHistorico.Location = new System.Drawing.Point(571, 122);
			this.lblHistorico.Name = "lblHistorico";
			this.lblHistorico.Size = new System.Drawing.Size(98, 22);
			this.lblHistorico.TabIndex = 5;
			this.lblHistorico.Text = "Consultar";
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(548, 28);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(135, 71);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 4;
			this.pctLogo.TabStop = false;
			// 
			// radEntrada
			// 
			this.radEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.radEntrada.AutoSize = true;
			this.radEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radEntrada.ForeColor = System.Drawing.Color.Navy;
			this.radEntrada.Location = new System.Drawing.Point(62, 163);
			this.radEntrada.Name = "radEntrada";
			this.radEntrada.Size = new System.Drawing.Size(77, 19);
			this.radEntrada.TabIndex = 6;
			this.radEntrada.TabStop = true;
			this.radEntrada.Text = "Entrada";
			this.radEntrada.UseVisualStyleBackColor = true;
			this.radEntrada.CheckedChanged += new System.EventHandler(this.radEntrada_CheckedChanged);
			// 
			// radSaida
			// 
			this.radSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radSaida.AutoSize = true;
			this.radSaida.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radSaida.ForeColor = System.Drawing.Color.Navy;
			this.radSaida.Location = new System.Drawing.Point(586, 163);
			this.radSaida.Name = "radSaida";
			this.radSaida.Size = new System.Drawing.Size(62, 19);
			this.radSaida.TabIndex = 7;
			this.radSaida.TabStop = true;
			this.radSaida.Text = "Saida";
			this.radSaida.UseVisualStyleBackColor = true;
			this.radSaida.CheckedChanged += new System.EventHandler(this.radSaida_CheckedChanged);
			// 
			// Todos
			// 
			this.Todos.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Todos.AutoSize = true;
			this.Todos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Todos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Todos.ForeColor = System.Drawing.Color.Navy;
			this.Todos.Location = new System.Drawing.Point(1102, 163);
			this.Todos.Name = "Todos";
			this.Todos.Size = new System.Drawing.Size(64, 19);
			this.Todos.TabIndex = 8;
			this.Todos.TabStop = true;
			this.Todos.Text = "Todos";
			this.Todos.UseVisualStyleBackColor = true;
			this.Todos.CheckedChanged += new System.EventHandler(this.Todos_CheckedChanged);
			// 
			// btnVoltar
			// 
			this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Location = new System.Drawing.Point(420, 419);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(76, 23);
			this.btnVoltar.TabIndex = 23;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.Voltar);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnBuscar.BackColor = System.Drawing.Color.Navy;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(324, 419);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(76, 23);
			this.btnBuscar.TabIndex = 22;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// lblDataBusca
			// 
			this.lblDataBusca.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDataBusca.AutoSize = true;
			this.lblDataBusca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataBusca.ForeColor = System.Drawing.Color.Navy;
			this.lblDataBusca.Location = new System.Drawing.Point(68, 421);
			this.lblDataBusca.Name = "lblDataBusca";
			this.lblDataBusca.Size = new System.Drawing.Size(112, 17);
			this.lblDataBusca.TabIndex = 24;
			this.lblDataBusca.Text = "Data da busca";
			// 
			// dtBusca
			// 
			this.dtBusca.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtBusca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtBusca.Location = new System.Drawing.Point(187, 421);
			this.dtBusca.Name = "dtBusca";
			this.dtBusca.Size = new System.Drawing.Size(122, 20);
			this.dtBusca.TabIndex = 25;
			// 
			// listEntrada
			// 
			this.listEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
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
			this.listEntrada.Location = new System.Drawing.Point(71, 200);
			this.listEntrada.Name = "listEntrada";
			this.listEntrada.Size = new System.Drawing.Size(1141, 199);
			this.listEntrada.TabIndex = 26;
			this.listEntrada.UseCompatibleStateImageBehavior = false;
			this.listEntrada.View = System.Windows.Forms.View.Details;
			// 
			// ColRef
			// 
			this.ColRef.DisplayIndex = 9;
			this.ColRef.Text = "Ref";
			this.ColRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColRef.Width = 50;
			// 
			// colNomeVisitante
			// 
			this.colNomeVisitante.DisplayIndex = 0;
			this.colNomeVisitante.Text = "Nome do Visitante";
			this.colNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colNomeVisitante.Width = 200;
			// 
			// colVisitado
			// 
			this.colVisitado.DisplayIndex = 1;
			this.colVisitado.Text = "Visitado";
			this.colVisitado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colVisitado.Width = 200;
			// 
			// colDataEntrada
			// 
			this.colDataEntrada.DisplayIndex = 2;
			this.colDataEntrada.Text = "Data da Entrada";
			this.colDataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colDataEntrada.Width = 100;
			// 
			// colHoraEntrada
			// 
			this.colHoraEntrada.DisplayIndex = 3;
			this.colHoraEntrada.Text = "Hora da Entrada";
			this.colHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colHoraEntrada.Width = 100;
			// 
			// colCpf
			// 
			this.colCpf.DisplayIndex = 4;
			this.colCpf.Text = "Cpf";
			this.colCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colCpf.Width = 100;
			// 
			// colCnpj
			// 
			this.colCnpj.DisplayIndex = 5;
			this.colCnpj.Text = "Cnpj";
			this.colCnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colCnpj.Width = 100;
			// 
			// colPesoEntrada
			// 
			this.colPesoEntrada.DisplayIndex = 6;
			this.colPesoEntrada.Text = "Peso de Entrada";
			this.colPesoEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colPesoEntrada.Width = 100;
			// 
			// colPlacaVeiculo
			// 
			this.colPlacaVeiculo.DisplayIndex = 7;
			this.colPlacaVeiculo.Text = "Placa do Veiculo";
			this.colPlacaVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colPlacaVeiculo.Width = 100;
			// 
			// colIdUsuario
			// 
			this.colIdUsuario.DisplayIndex = 8;
			this.colIdUsuario.Text = "Id Usuario";
			this.colIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colIdUsuario.Width = 80;
			// 
			// listSaida
			// 
			this.listSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listSaida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSaidaRef,
            this.colSaidaNomeVisitante,
            this.colSaidaData,
            this.colSaidaHora,
            this.colSaidaPesoSaida,
            this.colSaidaIdUsuario});
			this.listSaida.HideSelection = false;
			this.listSaida.Location = new System.Drawing.Point(71, 200);
			this.listSaida.Name = "listSaida";
			this.listSaida.Size = new System.Drawing.Size(1141, 199);
			this.listSaida.TabIndex = 27;
			this.listSaida.UseCompatibleStateImageBehavior = false;
			this.listSaida.View = System.Windows.Forms.View.Details;
			// 
			// colSaidaRef
			// 
			this.colSaidaRef.DisplayIndex = 4;
			this.colSaidaRef.Text = "Ref";
			this.colSaidaRef.Width = 50;
			// 
			// colSaidaNomeVisitante
			// 
			this.colSaidaNomeVisitante.DisplayIndex = 0;
			this.colSaidaNomeVisitante.Text = "Nome do Visitante";
			this.colSaidaNomeVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colSaidaNomeVisitante.Width = 625;
			// 
			// colSaidaData
			// 
			this.colSaidaData.DisplayIndex = 1;
			this.colSaidaData.Text = "Data da Saida";
			this.colSaidaData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colSaidaData.Width = 200;
			// 
			// colSaidaHora
			// 
			this.colSaidaHora.DisplayIndex = 2;
			this.colSaidaHora.Text = "Hora da Saida";
			this.colSaidaHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colSaidaHora.Width = 100;
			// 
			// colSaidaPesoSaida
			// 
			this.colSaidaPesoSaida.DisplayIndex = 3;
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
			this.listFinalizada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.colFinUsuarioEntrada,
            this.colFinUsuarioSaida});
			this.listFinalizada.HideSelection = false;
			this.listFinalizada.Location = new System.Drawing.Point(3, 200);
			this.listFinalizada.Name = "listFinalizada";
			this.listFinalizada.Size = new System.Drawing.Size(1235, 199);
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
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1245, 513);
			this.ControlBox = false;
			this.Controls.Add(this.listFinalizada);
			this.Controls.Add(this.listSaida);
			this.Controls.Add(this.listEntrada);
			this.Controls.Add(this.dtBusca);
			this.Controls.Add(this.lblDataBusca);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.Todos);
			this.Controls.Add(this.radSaida);
			this.Controls.Add(this.radEntrada);
			this.Controls.Add(this.lblHistorico);
			this.Controls.Add(this.pctLogo);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsulta";
			this.Text = "Consulta";
			this.Load += new System.EventHandler(this.frmConsulta_Carregamento);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHistorico;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.RadioButton radEntrada;
		private System.Windows.Forms.RadioButton radSaida;
		private System.Windows.Forms.RadioButton Todos;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblDataBusca;
		private System.Windows.Forms.DateTimePicker dtBusca;
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
	}
}

