namespace Menu_Inicial
{
	partial class frmAlterar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterar));
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtReferencia = new System.Windows.Forms.TextBox();
			this.lblReferencia = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.txtPesoSaida = new System.Windows.Forms.TextBox();
			this.txtHoraSaida = new System.Windows.Forms.TextBox();
			this.txtDataSaida = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSaida = new System.Windows.Forms.Label();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnAlterarEntrada = new System.Windows.Forms.Button();
			this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
			this.txtPesoEntrada = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.txtHoraEntrada = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtDataEntrada = new System.Windows.Forms.TextBox();
			this.txtNomeVisitado = new System.Windows.Forms.TextBox();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.lblHoraEntrada = new System.Windows.Forms.Label();
			this.lblDataEntrada = new System.Windows.Forms.Label();
			this.lblNomeVisitado = new System.Windows.Forms.Label();
			this.lblNomeVisitante = new System.Windows.Forms.Label();
			this.btnAlterarSaida = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnBuscar.BackColor = System.Drawing.Color.Navy;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.White;
			this.btnBuscar.Location = new System.Drawing.Point(530, 150);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(121, 23);
			this.btnBuscar.TabIndex = 79;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtReferencia
			// 
			this.txtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtReferencia.Location = new System.Drawing.Point(317, 150);
			this.txtReferencia.Name = "txtReferencia";
			this.txtReferencia.Size = new System.Drawing.Size(189, 20);
			this.txtReferencia.TabIndex = 78;
			// 
			// lblReferencia
			// 
			this.lblReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblReferencia.AutoSize = true;
			this.lblReferencia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReferencia.ForeColor = System.Drawing.Color.Navy;
			this.lblReferencia.Location = new System.Drawing.Point(130, 150);
			this.lblReferencia.Name = "lblReferencia";
			this.lblReferencia.Size = new System.Drawing.Size(172, 17);
			this.lblReferencia.TabIndex = 77;
			this.lblReferencia.Text = "Referência de entrada";
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
			this.lblTitulo.Location = new System.Drawing.Point(339, 102);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(135, 22);
			this.lblTitulo.TabIndex = 76;
			this.lblTitulo.Text = "Alterar dados";
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(339, 12);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(135, 71);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 75;
			this.pctLogo.TabStop = false;
			// 
			// txtPesoSaida
			// 
			this.txtPesoSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoSaida.Location = new System.Drawing.Point(554, 324);
			this.txtPesoSaida.Name = "txtPesoSaida";
			this.txtPesoSaida.Size = new System.Drawing.Size(189, 20);
			this.txtPesoSaida.TabIndex = 74;
			// 
			// txtHoraSaida
			// 
			this.txtHoraSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtHoraSaida.Location = new System.Drawing.Point(554, 298);
			this.txtHoraSaida.Name = "txtHoraSaida";
			this.txtHoraSaida.Size = new System.Drawing.Size(189, 20);
			this.txtHoraSaida.TabIndex = 73;
			// 
			// txtDataSaida
			// 
			this.txtDataSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDataSaida.Location = new System.Drawing.Point(554, 270);
			this.txtDataSaida.Name = "txtDataSaida";
			this.txtDataSaida.Size = new System.Drawing.Size(189, 20);
			this.txtDataSaida.TabIndex = 72;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(425, 324);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 17);
			this.label1.TabIndex = 71;
			this.label1.Text = "Peso de saída";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Location = new System.Drawing.Point(425, 298);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 17);
			this.label2.TabIndex = 70;
			this.label2.Text = "Hora da saída";
			// 
			// lblSaida
			// 
			this.lblSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSaida.AutoSize = true;
			this.lblSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaida.ForeColor = System.Drawing.Color.Navy;
			this.lblSaida.Location = new System.Drawing.Point(425, 270);
			this.lblSaida.Name = "lblSaida";
			this.lblSaida.Size = new System.Drawing.Size(107, 17);
			this.lblSaida.TabIndex = 69;
			this.lblSaida.Text = "Data da saída";
			// 
			// btnVoltar
			// 
			this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Location = new System.Drawing.Point(530, 463);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(121, 23);
			this.btnVoltar.TabIndex = 68;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// btnAlterarEntrada
			// 
			this.btnAlterarEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAlterarEntrada.BackColor = System.Drawing.Color.Navy;
			this.btnAlterarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAlterarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAlterarEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterarEntrada.ForeColor = System.Drawing.Color.White;
			this.btnAlterarEntrada.Location = new System.Drawing.Point(181, 463);
			this.btnAlterarEntrada.Name = "btnAlterarEntrada";
			this.btnAlterarEntrada.Size = new System.Drawing.Size(121, 23);
			this.btnAlterarEntrada.TabIndex = 67;
			this.btnAlterarEntrada.Text = "Alterar Entrada";
			this.btnAlterarEntrada.UseVisualStyleBackColor = false;
			this.btnAlterarEntrada.Click += new System.EventHandler(this.btnAlterarEntrada_Click);
			// 
			// txtPlacaVeiculo
			// 
			this.txtPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPlacaVeiculo.Location = new System.Drawing.Point(207, 390);
			this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
			this.txtPlacaVeiculo.Size = new System.Drawing.Size(189, 20);
			this.txtPlacaVeiculo.TabIndex = 66;
			// 
			// txtPesoEntrada
			// 
			this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoEntrada.Location = new System.Drawing.Point(207, 362);
			this.txtPesoEntrada.Name = "txtPesoEntrada";
			this.txtPesoEntrada.Size = new System.Drawing.Size(189, 20);
			this.txtPesoEntrada.TabIndex = 65;
			// 
			// txtCnpj
			// 
			this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCnpj.Location = new System.Drawing.Point(207, 336);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(189, 20);
			this.txtCnpj.TabIndex = 64;
			// 
			// txtHoraEntrada
			// 
			this.txtHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtHoraEntrada.Location = new System.Drawing.Point(207, 308);
			this.txtHoraEntrada.Name = "txtHoraEntrada";
			this.txtHoraEntrada.Size = new System.Drawing.Size(189, 20);
			this.txtHoraEntrada.TabIndex = 63;
			// 
			// txtCpf
			// 
			this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCpf.Location = new System.Drawing.Point(207, 282);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(189, 20);
			this.txtCpf.TabIndex = 62;
			// 
			// txtDataEntrada
			// 
			this.txtDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDataEntrada.Location = new System.Drawing.Point(207, 254);
			this.txtDataEntrada.Name = "txtDataEntrada";
			this.txtDataEntrada.Size = new System.Drawing.Size(189, 20);
			this.txtDataEntrada.TabIndex = 61;
			// 
			// txtNomeVisitado
			// 
			this.txtNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitado.Location = new System.Drawing.Point(207, 228);
			this.txtNomeVisitado.Name = "txtNomeVisitado";
			this.txtNomeVisitado.Size = new System.Drawing.Size(189, 20);
			this.txtNomeVisitado.TabIndex = 60;
			// 
			// txtNomeVisitante
			// 
			this.txtNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitante.Location = new System.Drawing.Point(207, 200);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(189, 20);
			this.txtNomeVisitante.TabIndex = 59;
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.ForeColor = System.Drawing.Color.Navy;
			this.lblPlaca.Location = new System.Drawing.Point(49, 390);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(127, 17);
			this.lblPlaca.TabIndex = 58;
			this.lblPlaca.Text = "Placa do veículo";
			// 
			// lblPeso
			// 
			this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPeso.AutoSize = true;
			this.lblPeso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPeso.ForeColor = System.Drawing.Color.Navy;
			this.lblPeso.Location = new System.Drawing.Point(49, 362);
			this.lblPeso.Name = "lblPeso";
			this.lblPeso.Size = new System.Drawing.Size(127, 17);
			this.lblPeso.TabIndex = 57;
			this.lblPeso.Text = "Peso de entrada";
			// 
			// lblCnpj
			// 
			this.lblCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCnpj.AutoSize = true;
			this.lblCnpj.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCnpj.ForeColor = System.Drawing.Color.Navy;
			this.lblCnpj.Location = new System.Drawing.Point(49, 336);
			this.lblCnpj.Name = "lblCnpj";
			this.lblCnpj.Size = new System.Drawing.Size(41, 17);
			this.lblCnpj.TabIndex = 56;
			this.lblCnpj.Text = "Cnpj";
			// 
			// lblCpf
			// 
			this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpf.ForeColor = System.Drawing.Color.Navy;
			this.lblCpf.Location = new System.Drawing.Point(49, 282);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(33, 17);
			this.lblCpf.TabIndex = 55;
			this.lblCpf.Text = "Cpf";
			// 
			// lblHoraEntrada
			// 
			this.lblHoraEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHoraEntrada.AutoSize = true;
			this.lblHoraEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHoraEntrada.ForeColor = System.Drawing.Color.Navy;
			this.lblHoraEntrada.Location = new System.Drawing.Point(49, 308);
			this.lblHoraEntrada.Name = "lblHoraEntrada";
			this.lblHoraEntrada.Size = new System.Drawing.Size(127, 17);
			this.lblHoraEntrada.TabIndex = 54;
			this.lblHoraEntrada.Text = "Hora da entrada";
			// 
			// lblDataEntrada
			// 
			this.lblDataEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDataEntrada.AutoSize = true;
			this.lblDataEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDataEntrada.ForeColor = System.Drawing.Color.Navy;
			this.lblDataEntrada.Location = new System.Drawing.Point(49, 254);
			this.lblDataEntrada.Name = "lblDataEntrada";
			this.lblDataEntrada.Size = new System.Drawing.Size(125, 17);
			this.lblDataEntrada.TabIndex = 53;
			this.lblDataEntrada.Text = "Data da entrada";
			// 
			// lblNomeVisitado
			// 
			this.lblNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitado.AutoSize = true;
			this.lblNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitado.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitado.Location = new System.Drawing.Point(49, 228);
			this.lblNomeVisitado.Name = "lblNomeVisitado";
			this.lblNomeVisitado.Size = new System.Drawing.Size(132, 17);
			this.lblNomeVisitado.TabIndex = 52;
			this.lblNomeVisitado.Text = "Nome do visitado";
			// 
			// lblNomeVisitante
			// 
			this.lblNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitante.AutoSize = true;
			this.lblNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitante.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitante.Location = new System.Drawing.Point(49, 200);
			this.lblNomeVisitante.Name = "lblNomeVisitante";
			this.lblNomeVisitante.Size = new System.Drawing.Size(137, 17);
			this.lblNomeVisitante.TabIndex = 51;
			this.lblNomeVisitante.Text = "Nome do visitante";
			// 
			// btnAlterarSaida
			// 
			this.btnAlterarSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAlterarSaida.BackColor = System.Drawing.Color.Navy;
			this.btnAlterarSaida.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAlterarSaida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAlterarSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterarSaida.ForeColor = System.Drawing.Color.White;
			this.btnAlterarSaida.Location = new System.Drawing.Point(353, 463);
			this.btnAlterarSaida.Name = "btnAlterarSaida";
			this.btnAlterarSaida.Size = new System.Drawing.Size(121, 23);
			this.btnAlterarSaida.TabIndex = 80;
			this.btnAlterarSaida.Text = "Alterar Saida";
			this.btnAlterarSaida.UseVisualStyleBackColor = false;
			// 
			// frmAlterar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 525);
			this.Controls.Add(this.btnAlterarSaida);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtReferencia);
			this.Controls.Add(this.lblReferencia);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.txtPesoSaida);
			this.Controls.Add(this.txtHoraSaida);
			this.Controls.Add(this.txtDataSaida);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblSaida);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnAlterarEntrada);
			this.Controls.Add(this.txtPlacaVeiculo);
			this.Controls.Add(this.txtPesoEntrada);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtHoraEntrada);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtDataEntrada);
			this.Controls.Add(this.txtNomeVisitado);
			this.Controls.Add(this.txtNomeVisitante);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblHoraEntrada);
			this.Controls.Add(this.lblDataEntrada);
			this.Controls.Add(this.lblNomeVisitado);
			this.Controls.Add(this.lblNomeVisitante);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAlterar";
			this.Text = "Alterar";
			this.Load += new System.EventHandler(this.frmAlterar_Load);
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtReferencia;
		private System.Windows.Forms.Label lblReferencia;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.TextBox txtPesoSaida;
		private System.Windows.Forms.TextBox txtHoraSaida;
		private System.Windows.Forms.TextBox txtDataSaida;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSaida;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnAlterarEntrada;
		private System.Windows.Forms.TextBox txtPlacaVeiculo;
		private System.Windows.Forms.TextBox txtPesoEntrada;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.TextBox txtHoraEntrada;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.TextBox txtDataEntrada;
		private System.Windows.Forms.TextBox txtNomeVisitado;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.Label lblHoraEntrada;
		private System.Windows.Forms.Label lblDataEntrada;
		private System.Windows.Forms.Label lblNomeVisitado;
		private System.Windows.Forms.Label lblNomeVisitante;
		private System.Windows.Forms.Button btnAlterarSaida;
	}
}

