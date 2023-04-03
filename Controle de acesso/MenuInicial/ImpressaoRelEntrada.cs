using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInicial
{
	public partial class frmRelEntrada : Form
	{
		DataTable dtTable = new DataTable();
		public frmRelEntrada(DataTable dtTable)
		{
			InitializeComponent();
			this.dtTable = dtTable;
		}
		private void rpViwer_Load(object sender, EventArgs e)
		{
			this.rpEntrada.LocalReport.DataSources.Clear();
			this.rpEntrada.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("mdlEntrada", dtTable));
			this.rpEntrada.RefreshReport();
		}

		private void ImpressaoRelEntrada_Load(object sender, EventArgs e)
		{
			this.rpEntrada.RefreshReport();
		}
	}
}
