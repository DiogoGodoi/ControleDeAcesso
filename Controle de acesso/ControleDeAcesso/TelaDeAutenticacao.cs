using ControleDeAutenticacao;
using Menu_Inicial;
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
using UsuarioModel;

namespace ControleDeAcesso
{
	//TelaDeLogin
	public partial class frmAutenticacao : Form
	{
		//Atributos
		private string nome { get; set; }
		private string senha { get; set; }
		public frmAutenticacao()
		{
			//Inicializador do formulário
			InitializeComponent();
		}


		//Configuração do método de entrada do sistema
		private void Entrar()
		{
			//thread de entrada do sistema
			Thread _thread = new Thread(AppRunEntrar);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		//Configuração do método de saída do sistema
		private void Sair()
		{
			//método para fechar janela atual
			this.Close();
		}
		//Configuração do botão de entrada do sistema


		private void btnEntrar_Click(object sender, EventArgs e)
		{	
			//Asociação de atributos com os campos do formulário
			nome = txtNome.Text;
			senha = txtSenha.Text;

			//Validação dos campos
			if (nome == String.Empty && senha == String.Empty)
			{
				MessageBox.Show("Por favor insira nome de usuário e senha", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (nome == String.Empty)
			{
				MessageBox.Show("Por favor insira o nome de usuário", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (senha == String.Empty)
			{
				MessageBox.Show("Por favor insira a senha", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				mdlUsuario _mdlUsuario = new mdlUsuario(nome, senha);
				bool retorno = ctrlAutenticacao.Autenticar(_mdlUsuario);
				if (retorno == true)
				{
					Entrar();
				}
				else
				{
					MessageBox.Show("Usuário inválido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		//Configuração botão de saída do sistema
		private void btnSair_Click(object sender, EventArgs e)
		{
			//Método para sair do sistema
			Sair();
		}
		//Configuração do formulário que alimentará a thread de entrada do sistema
		private void AppRunEntrar()
		{
			//Motor do formulário do menu inicial
			Application.Run(new frmMenuInicial());
		}

	}
}
