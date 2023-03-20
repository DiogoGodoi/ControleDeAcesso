using Menu_Inicial;
using Saida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuInicial
{
	public class ctrlNavegacao
	{
		//Método de navegação para tela de entrada
		public void NavegarParaTelaEntrada()
		{
			Application.Run(new frmEntrada());
		}
		//Método de navegação para tela de saída
		public void NavegarParaTelaSaida()
		{
			Application.Run(new frmSaida());
		}
		//Método de navegação para tela de alteração
		public void NavegarParaTelaAlteracao()
		{
			Application.Run(new frmAlterar());
		}
		//Método de navegação para tela de consulta
		public void NavegarParaTelaConsulta()
		{
			Application.Run(new frmConsulta());
		}
	    public void NavegarParaMenuInicial()
		{
			Application.Run(new frmMenuInicial());
		}
		public void Voltar()
		{
			Application.Run(new frmMenuInicial());
		}
	}
}
