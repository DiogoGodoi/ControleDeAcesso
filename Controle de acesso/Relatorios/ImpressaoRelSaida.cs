using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios
{
	public partial class frmRelSaida : Form
	{
		DataTable dtSaida = new DataTable();

		public frmRelSaida()
		{
			InitializeComponent();
		}
		public frmRelSaida(DataTable dtSaida)
		{
			InitializeComponent();
			this.dtSaida = dtSaida;
		}

		private void frmRelSaida_Load(object sender, EventArgs e)
		{

            this.relSaida.RefreshReport();
        }

		private void relSaida_Load(object sender, EventArgs e)
		{
			this.relSaida.LocalReport.DataSources.Clear();
			this.relSaida.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("mdlSaida", dtSaida));
			this.relSaida.RefreshReport();
		}
	}
}
