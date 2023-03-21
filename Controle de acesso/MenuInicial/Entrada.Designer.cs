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
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.lblNomeVisitante = new System.Windows.Forms.Label();
			this.lblNomeVisitado = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblPeso = new System.Windows.Forms.Label();
			this.lblCnpj = new System.Windows.Forms.Label();
			this.lblCpf = new System.Windows.Forms.Label();
			this.txtNomeVisitante = new System.Windows.Forms.TextBox();
			this.txtNomeVisitado = new System.Windows.Forms.TextBox();
			this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
			this.txtPesoEntrada = new System.Windows.Forms.TextBox();
			this.txtCnpj = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnCadastrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.Navy;
			this.lblTitulo.Location = new System.Drawing.Point(384, 127);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(186, 22);
			this.lblTitulo.TabIndex = 3;
			this.lblTitulo.Text = "Entrada de pessoal";
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(417, 33);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(135, 71);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 2;
			this.pctLogo.TabStop = false;
			// 
			// lblNomeVisitante
			// 
			this.lblNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitante.AutoSize = true;
			this.lblNomeVisitante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitante.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitante.Location = new System.Drawing.Point(194, 169);
			this.lblNomeVisitante.Name = "lblNomeVisitante";
			this.lblNomeVisitante.Size = new System.Drawing.Size(137, 17);
			this.lblNomeVisitante.TabIndex = 4;
			this.lblNomeVisitante.Text = "Nome do visitante";
			// 
			// lblNomeVisitado
			// 
			this.lblNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblNomeVisitado.AutoSize = true;
			this.lblNomeVisitado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeVisitado.ForeColor = System.Drawing.Color.Navy;
			this.lblNomeVisitado.Location = new System.Drawing.Point(194, 197);
			this.lblNomeVisitado.Name = "lblNomeVisitado";
			this.lblNomeVisitado.Size = new System.Drawing.Size(132, 17);
			this.lblNomeVisitado.TabIndex = 5;
			this.lblNomeVisitado.Text = "Nome do visitado";
			// 
			// lblPlaca
			// 
			this.lblPlaca.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlaca.ForeColor = System.Drawing.Color.Navy;
			this.lblPlaca.Location = new System.Drawing.Point(194, 307);
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
			this.lblPeso.Location = new System.Drawing.Point(194, 279);
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
			this.lblCnpj.Location = new System.Drawing.Point(194, 253);
			this.lblCnpj.Name = "lblCnpj";
			this.lblCnpj.Size = new System.Drawing.Size(41, 17);
			this.lblCnpj.TabIndex = 9;
			this.lblCnpj.Text = "Cnpj";
			// 
			// lblCpf
			// 
			this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCpf.AutoSize = true;
			this.lblCpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCpf.ForeColor = System.Drawing.Color.Navy;
			this.lblCpf.Location = new System.Drawing.Point(194, 225);
			this.lblCpf.Name = "lblCpf";
			this.lblCpf.Size = new System.Drawing.Size(33, 17);
			this.lblCpf.TabIndex = 8;
			this.lblCpf.Text = "Cpf";
			// 
			// txtNomeVisitante
			// 
			this.txtNomeVisitante.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitante.Location = new System.Drawing.Point(352, 169);
			this.txtNomeVisitante.Name = "txtNomeVisitante";
			this.txtNomeVisitante.Size = new System.Drawing.Size(343, 20);
			this.txtNomeVisitante.TabIndex = 12;
			// 
			// txtNomeVisitado
			// 
			this.txtNomeVisitado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNomeVisitado.Location = new System.Drawing.Point(352, 197);
			this.txtNomeVisitado.Name = "txtNomeVisitado";
			this.txtNomeVisitado.Size = new System.Drawing.Size(343, 20);
			this.txtNomeVisitado.TabIndex = 13;
			// 
			// txtPlacaVeiculo
			// 
			this.txtPlacaVeiculo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPlacaVeiculo.Location = new System.Drawing.Point(352, 307);
			this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
			this.txtPlacaVeiculo.Size = new System.Drawing.Size(343, 20);
			this.txtPlacaVeiculo.TabIndex = 19;
			// 
			// txtPesoEntrada
			// 
			this.txtPesoEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPesoEntrada.Location = new System.Drawing.Point(352, 279);
			this.txtPesoEntrada.Name = "txtPesoEntrada";
			this.txtPesoEntrada.Size = new System.Drawing.Size(343, 20);
			this.txtPesoEntrada.TabIndex = 18;
			// 
			// txtCnpj
			// 
			this.txtCnpj.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCnpj.Location = new System.Drawing.Point(352, 253);
			this.txtCnpj.Name = "txtCnpj";
			this.txtCnpj.Size = new System.Drawing.Size(343, 20);
			this.txtCnpj.TabIndex = 17;
			// 
			// txtCpf
			// 
			this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCpf.Location = new System.Drawing.Point(352, 225);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(343, 20);
			this.txtCpf.TabIndex = 16;
			// 
			// btnVoltar
			// 
			this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Location = new System.Drawing.Point(506, 349);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(121, 23);
			this.btnVoltar.TabIndex = 21;
			this.btnVoltar.Text = "Voltar";
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.Voltar);
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCadastrar.BackColor = System.Drawing.Color.Navy;
			this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(318, 349);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(121, 23);
			this.btnCadastrar.TabIndex = 20;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.EfetuarEntrada);
			// 
			// frmEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 408);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtPlacaVeiculo);
			this.Controls.Add(this.txtPesoEntrada);
			this.Controls.Add(this.txtCnpj);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtNomeVisitado);
			this.Controls.Add(this.txtNomeVisitante);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblPeso);
			this.Controls.Add(this.lblCnpj);
			this.Controls.Add(this.lblCpf);
			this.Controls.Add(this.lblNomeVisitado);
			this.Controls.Add(this.lblNomeVisitante);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.pctLogo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmEntrada";
			this.Text = "Entrada";
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Label lblNomeVisitante;
		private System.Windows.Forms.Label lblNomeVisitado;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblPeso;
		private System.Windows.Forms.Label lblCnpj;
		private System.Windows.Forms.Label lblCpf;
		private System.Windows.Forms.TextBox txtNomeVisitante;
		private System.Windows.Forms.TextBox txtNomeVisitado;
		private System.Windows.Forms.TextBox txtPlacaVeiculo;
		private System.Windows.Forms.TextBox txtPesoEntrada;
		private System.Windows.Forms.TextBox txtCnpj;
		private System.Windows.Forms.TextBox txtCpf;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnCadastrar;
	}
}

