using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace VIEWS
{
	//Controle de navegação
	public class ctrlNavegacao
	{
		//Método de navegação para tela de entrada
		public static void Navegacao(Form formAtivo, Form form, Panel panel)
		{
			FecharAtivo(formAtivo);
			formAtivo = form;
			form.TopLevel = false;
			panel.Controls.Add(form);
			form.BringToFront();
			form.Show();
		}
		public void NavegarPareMenuInicial()
		{
			Application.Run(new frmMenuInicial());	
		}
		public static void FecharAtivo(Form formAtivo)
		{
			if(formAtivo != null)
				formAtivo.Close();	
		}
		public static void ActiveButton(Button button, Panel panel)
		{
			foreach (Control controls in panel.Controls)
			{
				controls.BackColor = System.Drawing.Color.Navy;
				button.BackColor = System.Drawing.Color.DarkSlateBlue;
			}
		}
	}
}
