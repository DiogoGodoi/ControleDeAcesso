using MenuInicial;
using Saida;
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

namespace Menu_Inicial
{
	//Menu inicial
	public partial class frmMenuInicial : Form
	{
		//Inicializador do formulário
		ctrlNavegacao navegar = new ctrlNavegacao();
		public frmMenuInicial()
		{
			InitializeComponent();
		}
		private void TelaDeEntrada(object sender, EventArgs e)
		{
		Thread _thread = new Thread(navegar.NavegarParaTelaEntrada);
		_thread.SetApartmentState(ApartmentState.STA);
		_thread.Start();
		this.Close();
	}
		//Configuração do botão da tela de saída
		private void TelaDeSaida(object sender, EventArgs e)
		{
			//Thread da tela de saída
			Thread _thread = new Thread(navegar.NavegarParaTelaSaida);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração do botão da tela de alteração
		private void TelaDeAlteracao(object sender, EventArgs e)
		{
			//Thread da tela de alteração
			Thread _thread = new Thread(navegar.NavegarParaTelaAlteracao);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração do botão da tela de consulta
		private void TelaDeConsulta(object sender, EventArgs e)
		{
			//Thread da tela de consulta
			Thread _thread = new Thread(navegar.NavegarParaTelaConsulta);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração do botão de saida do sistema
		private void Sair(object sender, EventArgs e)
		{
			//Método para fechar o formulário atual
			this.Close();
		}
	}
}
