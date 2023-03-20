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
			this.listConsulta = new System.Windows.Forms.ListView();
			this.colNomeVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colVisitado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDataEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colHoraEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPesoEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPlacaVeiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colIdUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColRef = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHistorico
			// 
			this.lblHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHistorico.AutoSize = true;
			this.lblHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHistorico.ForeColor = System.Drawing.Color.Navy;
			this.lblHistorico.Location = new System.Drawing.Point(562, 122);
			this.lblHistorico.Name = "lblHistorico";
			this.lblHistorico.Size = new System.Drawing.Size(98, 22);
			this.lblHistorico.TabIndex = 5;
			this.lblHistorico.Text = "Consultar";
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(539, 28);
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
			this.radEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radEntrada.ForeColor = System.Drawing.Color.Navy;
			this.radEntrada.Location = new System.Drawing.Point(62, 163);
			this.radEntrada.Name = "radEntrada";
			this.radEntrada.Size = new System.Drawing.Size(77, 19);
			this.radEntrada.TabIndex = 6;
			this.radEntrada.TabStop = true;
			this.radEntrada.Text = "Entrada";
			this.radEntrada.UseVisualStyleBackColor = true;
			this.radEntrada.CheckedChanged += new System.EventHandler(this.radEntrada_Selecionado);
			// 
			// radSaida
			// 
			this.radSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radSaida.AutoSize = true;
			this.radSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radSaida.ForeColor = System.Drawing.Color.Navy;
			this.radSaida.Location = new System.Drawing.Point(577, 163);
			this.radSaida.Name = "radSaida";
			this.radSaida.Size = new System.Drawing.Size(62, 19);
			this.radSaida.TabIndex = 7;
			this.radSaida.TabStop = true;
			this.radSaida.Text = "Saida";
			this.radSaida.UseVisualStyleBackColor = true;
			// 
			// Todos
			// 
			this.Todos.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Todos.AutoSize = true;
			this.Todos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Todos.ForeColor = System.Drawing.Color.Navy;
			this.Todos.Location = new System.Drawing.Point(1084, 163);
			this.Todos.Name = "Todos";
			this.Todos.Size = new System.Drawing.Size(64, 19);
			this.Todos.TabIndex = 8;
			this.Todos.TabStop = true;
			this.Todos.Text = "Todos";
			this.Todos.UseVisualStyleBackColor = true;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Location = new System.Drawing.Point(411, 419);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(76, 23);
			this.btnVoltar.TabIndex = 23;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.Voltar);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBuscar.BackColor = System.Drawing.Color.Navy;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(315, 419);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(76, 23);
			this.btnBuscar.TabIndex = 22;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			// 
			// lblDataBusca
			// 
			this.lblDataBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDataBusca.AutoSize = true;
			this.lblDataBusca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataBusca.ForeColor = System.Drawing.Color.Navy;
			this.lblDataBusca.Location = new System.Drawing.Point(59, 421);
			this.lblDataBusca.Name = "lblDataBusca";
			this.lblDataBusca.Size = new System.Drawing.Size(112, 17);
			this.lblDataBusca.TabIndex = 24;
			this.lblDataBusca.Text = "Data da busca";
			// 
			// dtBusca
			// 
			this.dtBusca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtBusca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtBusca.Location = new System.Drawing.Point(178, 421);
			this.dtBusca.Name = "dtBusca";
			this.dtBusca.Size = new System.Drawing.Size(122, 20);
			this.dtBusca.TabIndex = 25;
			// 
			// listConsulta
			// 
			this.listConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.listConsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
			this.listConsulta.HideSelection = false;
			this.listConsulta.Location = new System.Drawing.Point(62, 200);
			this.listConsulta.Name = "listConsulta";
			this.listConsulta.Size = new System.Drawing.Size(1141, 199);
			this.listConsulta.TabIndex = 26;
			this.listConsulta.UseCompatibleStateImageBehavior = false;
			this.listConsulta.View = System.Windows.Forms.View.Details;
			// 
			// colNomeVisitante
			// 
			this.colNomeVisitante.DisplayIndex = 0;
			this.colNomeVisitante.Text = "Nome do Visitante";
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
			this.colPesoEntrada.Width = 100;
			// 
			// colPlacaVeiculo
			// 
			this.colPlacaVeiculo.DisplayIndex = 7;
			this.colPlacaVeiculo.Text = "Placa do Veiculo";
			this.colPlacaVeiculo.Width = 100;
			// 
			// colIdUsuario
			// 
			this.colIdUsuario.DisplayIndex = 8;
			this.colIdUsuario.Text = "Id Usuario";
			this.colIdUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.colIdUsuario.Width = 80;
			// 
			// ColRef
			// 
			this.ColRef.DisplayIndex = 9;
			this.ColRef.Text = "Ref";
			this.ColRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ColRef.Width = 100;
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1227, 513);
			this.Controls.Add(this.listConsulta);
			this.Controls.Add(this.dtBusca);
			this.Controls.Add(this.lblDataBusca);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.Todos);
			this.Controls.Add(this.radSaida);
			this.Controls.Add(this.radEntrada);
			this.Controls.Add(this.lblHistorico);
			this.Controls.Add(this.pctLogo);
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
		private System.Windows.Forms.ListView listConsulta;
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
	}
}

