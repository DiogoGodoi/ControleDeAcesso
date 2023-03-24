namespace Menu_Inicial
{
	partial class frmMenuInicial
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuInicial));
			this.pctEntrada = new System.Windows.Forms.PictureBox();
			this.pctSair = new System.Windows.Forms.PictureBox();
			this.pctBuscar = new System.Windows.Forms.PictureBox();
			this.pctAlterar = new System.Windows.Forms.PictureBox();
			this.btnEntrada = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnSaida = new System.Windows.Forms.Button();
			this.nav = new System.Windows.Forms.Panel();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.footer = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pctEntrada)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctSair)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctAlterar)).BeginInit();
			this.nav.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.footer.SuspendLayout();
			this.SuspendLayout();
			// 
			// pctEntrada
			// 
			this.pctEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctEntrada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pctEntrada.Image = ((System.Drawing.Image)(resources.GetObject("pctEntrada.Image")));
			this.pctEntrada.Location = new System.Drawing.Point(79, 117);
			this.pctEntrada.Name = "pctEntrada";
			this.pctEntrada.Size = new System.Drawing.Size(111, 93);
			this.pctEntrada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctEntrada.TabIndex = 4;
			this.pctEntrada.TabStop = false;
			// 
			// pctSair
			// 
			this.pctSair.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pctSair.Image = ((System.Drawing.Image)(resources.GetObject("pctSair.Image")));
			this.pctSair.Location = new System.Drawing.Point(256, 117);
			this.pctSair.Name = "pctSair";
			this.pctSair.Size = new System.Drawing.Size(111, 93);
			this.pctSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctSair.TabIndex = 5;
			this.pctSair.TabStop = false;
			// 
			// pctBuscar
			// 
			this.pctBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pctBuscar.Image = ((System.Drawing.Image)(resources.GetObject("pctBuscar.Image")));
			this.pctBuscar.Location = new System.Drawing.Point(611, 117);
			this.pctBuscar.Name = "pctBuscar";
			this.pctBuscar.Size = new System.Drawing.Size(111, 93);
			this.pctBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctBuscar.TabIndex = 7;
			this.pctBuscar.TabStop = false;
			// 
			// pctAlterar
			// 
			this.pctAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pctAlterar.Image = ((System.Drawing.Image)(resources.GetObject("pctAlterar.Image")));
			this.pctAlterar.Location = new System.Drawing.Point(434, 117);
			this.pctAlterar.Name = "pctAlterar";
			this.pctAlterar.Size = new System.Drawing.Size(111, 93);
			this.pctAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctAlterar.TabIndex = 6;
			this.pctAlterar.TabStop = false;
			// 
			// btnEntrada
			// 
			this.btnEntrada.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEntrada.BackColor = System.Drawing.Color.Navy;
			this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrada.ForeColor = System.Drawing.Color.White;
			this.btnEntrada.Location = new System.Drawing.Point(79, 233);
			this.btnEntrada.Name = "btnEntrada";
			this.btnEntrada.Size = new System.Drawing.Size(111, 23);
			this.btnEntrada.TabIndex = 8;
			this.btnEntrada.Text = "Entrada";
			this.btnEntrada.UseVisualStyleBackColor = false;
			this.btnEntrada.Click += new System.EventHandler(this.TelaDeEntrada);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnConsultar.BackColor = System.Drawing.Color.Navy;
			this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.ForeColor = System.Drawing.Color.White;
			this.btnConsultar.Location = new System.Drawing.Point(611, 233);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(111, 23);
			this.btnConsultar.TabIndex = 11;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.TelaDeConsulta);
			// 
			// btnAlterar
			// 
			this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAlterar.BackColor = System.Drawing.Color.Navy;
			this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlterar.ForeColor = System.Drawing.Color.White;
			this.btnAlterar.Location = new System.Drawing.Point(434, 233);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(111, 23);
			this.btnAlterar.TabIndex = 10;
			this.btnAlterar.Text = "Alterar";
			this.btnAlterar.UseVisualStyleBackColor = false;
			this.btnAlterar.Click += new System.EventHandler(this.TelaDeAlteracao);
			// 
			// btnSair
			// 
			this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(334, 292);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(111, 23);
			this.btnSair.TabIndex = 12;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.Sair);
			// 
			// btnSaida
			// 
			this.btnSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSaida.BackColor = System.Drawing.Color.Navy;
			this.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaida.ForeColor = System.Drawing.Color.White;
			this.btnSaida.Location = new System.Drawing.Point(256, 233);
			this.btnSaida.Name = "btnSaida";
			this.btnSaida.Size = new System.Drawing.Size(111, 23);
			this.btnSaida.TabIndex = 9;
			this.btnSaida.Text = "Saida";
			this.btnSaida.UseVisualStyleBackColor = false;
			this.btnSaida.Click += new System.EventHandler(this.TelaDeSaida);
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
			this.nav.TabIndex = 27;
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
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(210, 15);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(380, 32);
			this.lblTitulo.TabIndex = 5;
			this.lblTitulo.Text = "Selecione a opção desejada";
			// 
			// footer
			// 
			this.footer.BackColor = System.Drawing.Color.Maroon;
			this.footer.Controls.Add(this.label1);
			this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footer.Location = new System.Drawing.Point(0, 348);
			this.footer.Name = "footer";
			this.footer.Size = new System.Drawing.Size(800, 28);
			this.footer.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Right;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(539, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 22);
			this.label1.TabIndex = 6;
			this.label1.Text = "Pta - Serviços terceirizados";
			// 
			// frmMenuInicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 376);
			this.Controls.Add(this.footer);
			this.Controls.Add(this.nav);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.btnSaida);
			this.Controls.Add(this.btnEntrada);
			this.Controls.Add(this.pctBuscar);
			this.Controls.Add(this.pctAlterar);
			this.Controls.Add(this.pctSair);
			this.Controls.Add(this.pctEntrada);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMenuInicial";
			this.Text = "Menu inicial";
			this.Load += new System.EventHandler(this.frmMenuInicial_Load);
			((System.ComponentModel.ISupportInitialize)(this.pctEntrada)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctSair)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctAlterar)).EndInit();
			this.nav.ResumeLayout(false);
			this.nav.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.footer.ResumeLayout(false);
			this.footer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pctEntrada;
		private System.Windows.Forms.PictureBox pctSair;
		private System.Windows.Forms.PictureBox pctBuscar;
		private System.Windows.Forms.PictureBox pctAlterar;
		private System.Windows.Forms.Button btnEntrada;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnSaida;
		private System.Windows.Forms.Panel nav;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Panel footer;
		private System.Windows.Forms.Label label1;
	}
}

