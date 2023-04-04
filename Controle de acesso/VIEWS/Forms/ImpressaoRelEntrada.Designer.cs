namespace VIEWS
{
	partial class frmRelEntrada
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelEntrada));
			this.rpEntrada = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rpEntrada
			// 
			this.rpEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "daoEntrada";
			reportDataSource1.Value = null;
			reportDataSource2.Name = "daoUsuario";
			reportDataSource2.Value = null;
			this.rpEntrada.LocalReport.DataSources.Add(reportDataSource1);
			this.rpEntrada.LocalReport.DataSources.Add(reportDataSource2);
			this.rpEntrada.LocalReport.ReportEmbeddedResource = "VIEWS.Relatorios.RelatorioEntrada.rdlc";
			this.rpEntrada.Location = new System.Drawing.Point(0, 0);
			this.rpEntrada.Name = "rpEntrada";
			this.rpEntrada.ServerReport.BearerToken = null;
			this.rpEntrada.Size = new System.Drawing.Size(800, 450);
			this.rpEntrada.TabIndex = 0;
			this.rpEntrada.Load += new System.EventHandler(this.rpViwer_Load);
			// 
			// frmRelEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rpEntrada);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRelEntrada";
			this.Text = "Impressao";
			this.Load += new System.EventHandler(this.ImpressaoRelEntrada_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpEntrada;
	}
}