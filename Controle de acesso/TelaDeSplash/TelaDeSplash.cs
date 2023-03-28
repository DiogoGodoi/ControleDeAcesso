using ControleDeAcesso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeSplash
{
	public partial class frmSplash : Form
	{
		public frmSplash()
		{
			InitializeComponent();
		}
		private void frmSplash_Shown(object sender, EventArgs e)
		{
			lblCarregamento.Text = "Carregando";
			this.Refresh();
			for (int i = 1; i < 101; i++)
			{
				progress.Value = i;
				Thread.Sleep(30);
			}
			Thread.Sleep(2000);
			this.Hide();
			frmAutenticacao form = new frmAutenticacao();
			form.ShowDialog();
			this.Close();
		}
	}
}
