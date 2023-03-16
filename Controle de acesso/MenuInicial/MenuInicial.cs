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
	public partial class frmMenuInicial : Form
	{
		//Inicializador do formulário
		public frmMenuInicial()
		{
			InitializeComponent();
		}

		//Configuração da método de entrada da tela de entrada
		private void TelaDeEntrada()
		{
			//Thread da tela de entrada
			Thread _thread = new Thread(AppRunEntrada);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração método de entrada da tela de saída
		private void TelaDeSaida()
		{
			//Thread da tela de saída
			Thread _thread = new Thread(AppRunSaida);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração método de entrada da tela de alteração
		private void TelaDeAlteracao()
		{
			//Thread da tela de alteração
			Thread _thread = new Thread(AppRunAlteracao);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração método de entrada da tela de consulta
		private void TelaDeConsulta()
		{
			//Thread da tela de consulta
			Thread _thread = new Thread(AppRunConsulta);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração do método de saida do sistema
		private void Sair()
		{
			//Método para fechar o formulário atual
			this.Close();
		}


		//Configuração do botão da tela entrada
		private void btnEntrada_Click(object sender, EventArgs e)
		{
			//Método de navegação para tela de entrada
			TelaDeEntrada();
		}
		//Configuração do botão da tela de saída
		private void btnSaida_Click(object sender, EventArgs e)
		{
			//Método de navegação para tela de saída
			TelaDeSaida();
		}
		//Configuração do botão da tela de alteração
		private void btnAlterar_Click(object sender, EventArgs e)
		{
			//Método de navegação para tela de alteração
			TelaDeAlteracao();
		}
		//Configuração do botão da tela de consulta
		private void btnConsultar_Click(object sender, EventArgs e)
		{
			//Método de navegação para tela de consulta
			TelaDeConsulta();
		}
		//Configuração do botão de saida do sistema
		private void btnSair_click(object sender, EventArgs e)
		{
			//Método para sair do sistema
			Sair();
		}
		//Configuração do formulário de entrada que alimentará a Thread de entrada
		private void AppRunEntrada()
		{
			//Motor do formulário de entrada
			Application.Run(new frmEntrada());
		}
		//Configuração do formulário de saída que alimentará a Thread de saída
		private void AppRunSaida()
		{
			//Motor do formulário de saida
			Application.Run(new frmSaida());
		}
		//Configuração do formulário de alteração que alimentará a Thread de alteração
		private void AppRunAlteracao()
		{
			//Motor do formulário de alteração
			Application.Run(new frmAlterar());
		}
		//Configuração do formulário de consulta que alimentará a Thread de consulta
		private void AppRunConsulta()
		{
			//Motor do formulário de consulta
			Application.Run(new frmConsulta());
		}

	}
}
