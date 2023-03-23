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
	//Controle de navegação
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
		//Método para navegar para o menu inicial
	    public void NavegarParaMenuInicial()
		{
			Application.Run(new frmMenuInicial());
		}
		//Método para voltar
		public void Voltar()
		{
			Application.Run(new frmMenuInicial());
		}
	}
}
