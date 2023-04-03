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
	public partial class ImpressaoRelEntrada : Form
	{
		DataTable dtTable = new DataTable();
		public ImpressaoRelEntrada(DataTable dtTable)
		{
			InitializeComponent();
			this.dtTable = dtTable;
		}
		private void rpViwer_Load(object sender, EventArgs e)
		{
			this.rpViwer.LocalReport.DataSources.Clear();
			this.rpViwer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("mdlEntrada", dtTable));
			this.rpViwer.RefreshReport();
		}
	}
}
