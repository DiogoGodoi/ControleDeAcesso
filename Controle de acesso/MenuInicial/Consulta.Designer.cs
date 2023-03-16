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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblDataBusca = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHistorico
			// 
			this.lblHistorico.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblHistorico.AutoSize = true;
			this.lblHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHistorico.ForeColor = System.Drawing.Color.Navy;
			this.lblHistorico.Location = new System.Drawing.Point(232, 122);
			this.lblHistorico.Name = "lblHistorico";
			this.lblHistorico.Size = new System.Drawing.Size(98, 22);
			this.lblHistorico.TabIndex = 5;
			this.lblHistorico.Text = "Consultar";
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(209, 28);
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
			// 
			// radSaida
			// 
			this.radSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.radSaida.AutoSize = true;
			this.radSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radSaida.ForeColor = System.Drawing.Color.Navy;
			this.radSaida.Location = new System.Drawing.Point(247, 163);
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
			this.Todos.Location = new System.Drawing.Point(423, 163);
			this.Todos.Name = "Todos";
			this.Todos.Size = new System.Drawing.Size(64, 19);
			this.Todos.TabIndex = 8;
			this.Todos.TabStop = true;
			this.Todos.Text = "Todos";
			this.Todos.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(62, 210);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(425, 186);
			this.listBox1.TabIndex = 9;
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
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.Location = new System.Drawing.Point(177, 421);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 20);
			this.textBox1.TabIndex = 25;
			// 
			// frmConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 513);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblDataBusca);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.Todos);
			this.Controls.Add(this.radSaida);
			this.Controls.Add(this.radEntrada);
			this.Controls.Add(this.lblHistorico);
			this.Controls.Add(this.pctLogo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmConsulta";
			this.Text = "Consulta";
			this.Load += new System.EventHandler(this.frmConsulta_Load);
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
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblDataBusca;
		private System.Windows.Forms.TextBox textBox1;
	}
}

