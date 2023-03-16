using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Inicial
{
	public partial class frmConsulta : Form
	{
		private Thread _thread;
		public frmConsulta()
		{
			InitializeComponent();
		}
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			_thread = new Thread(Voltar);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		private void Voltar()
		{
			Application.Run(new frmMenuInicial());
		}

		private void frmConsulta_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}
	}
}
