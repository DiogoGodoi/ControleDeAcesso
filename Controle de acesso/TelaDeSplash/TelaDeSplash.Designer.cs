namespace TelaDeSplash
{
	partial class frmSplash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
			this.panelNav = new System.Windows.Forms.Panel();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.pctLogo = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblCarregamento = new System.Windows.Forms.Label();
			this.progress = new System.Windows.Forms.ProgressBar();
			this.panelNav.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelNav
			// 
			this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panelNav.Controls.Add(this.lblTitulo);
			this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelNav.Location = new System.Drawing.Point(0, 0);
			this.panelNav.Name = "panelNav";
			this.panelNav.Size = new System.Drawing.Size(456, 76);
			this.panelNav.TabIndex = 0;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(76, 18);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(320, 37);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Controle de Acesso";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pctLogo
			// 
			this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
			this.pctLogo.Location = new System.Drawing.Point(52, 104);
			this.pctLogo.Name = "pctLogo";
			this.pctLogo.Size = new System.Drawing.Size(358, 163);
			this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctLogo.TabIndex = 1;
			this.pctLogo.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.lblCarregamento);
			this.panel1.Controls.Add(this.progress);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 297);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(456, 75);
			this.panel1.TabIndex = 2;
			// 
			// lblCarregamento
			// 
			this.lblCarregamento.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCarregamento.AutoSize = true;
			this.lblCarregamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCarregamento.ForeColor = System.Drawing.Color.White;
			this.lblCarregamento.Location = new System.Drawing.Point(49, 10);
			this.lblCarregamento.Name = "lblCarregamento";
			this.lblCarregamento.Size = new System.Drawing.Size(47, 15);
			this.lblCarregamento.TabIndex = 5;
			this.lblCarregamento.Text = "label1";
			// 
			// progress
			// 
			this.progress.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.progress.Location = new System.Drawing.Point(52, 28);
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(358, 23);
			this.progress.TabIndex = 4;
			// 
			// frmSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(456, 372);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pctLogo);
			this.Controls.Add(this.panelNav);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmSplash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Shown += new System.EventHandler(this.frmSplash_Shown);
			this.panelNav.ResumeLayout(false);
			this.panelNav.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Panel panelNav;
		private System.Windows.Forms.PictureBox pctLogo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblCarregamento;
		private System.Windows.Forms.ProgressBar progress;
	}
}

