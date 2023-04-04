namespace VIEWS
{
	partial class frmRelSaida
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelSaida));
			this.relSaida = new Microsoft.Reporting.WinForms.ReportViewer();
			this.mdlSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.mdlSaidaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// relSaida
			// 
			this.relSaida.Dock = System.Windows.Forms.DockStyle.Fill;
			this.relSaida.LocalReport.ReportEmbeddedResource = "Relatorios.Relatorios.RelatorioDeSaida.rdlc";
			this.relSaida.Location = new System.Drawing.Point(0, 0);
			this.relSaida.Name = "relSaida";
			this.relSaida.ServerReport.BearerToken = null;
			this.relSaida.Size = new System.Drawing.Size(800, 450);
			this.relSaida.TabIndex = 0;
			this.relSaida.Load += new System.EventHandler(this.relSaida_Load);
			// 
			// mdlSaidaBindingSource
			// 
			this.mdlSaidaBindingSource.DataSource = typeof(MODEL.mdlSaida);
			// 
			// frmRelSaida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.relSaida);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRelSaida";
			this.Text = "Relatorio";
			this.Load += new System.EventHandler(this.frmRelSaida_Load);
			((System.ComponentModel.ISupportInitialize)(this.mdlSaidaBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer relSaida;
		private System.Windows.Forms.BindingSource mdlSaidaBindingSource;
	}
}

