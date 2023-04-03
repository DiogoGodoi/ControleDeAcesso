namespace MenuInicial
{
	partial class ImpressaoRelEntrada
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
			this.rpViwer = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// rpViwer
			// 
			this.rpViwer.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "daoEntrada";
			reportDataSource1.Value = null;
			reportDataSource2.Name = "daoUsuario";
			reportDataSource2.Value = null;
			this.rpViwer.LocalReport.DataSources.Add(reportDataSource1);
			this.rpViwer.LocalReport.DataSources.Add(reportDataSource2);
			this.rpViwer.LocalReport.ReportEmbeddedResource = "MenuInicial.Relatorio.RelatorioEntrada.rdlc";
			this.rpViwer.Location = new System.Drawing.Point(0, 0);
			this.rpViwer.Name = "rpViwer";
			this.rpViwer.ServerReport.BearerToken = null;
			this.rpViwer.Size = new System.Drawing.Size(800, 450);
			this.rpViwer.TabIndex = 0;
			this.rpViwer.Load += new System.EventHandler(this.rpViwer_Load);
			// 
			// ImpressaoRelEntrada
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rpViwer);
			this.Name = "ImpressaoRelEntrada";
			this.Text = "Impressao";
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rpViwer;
	}
}