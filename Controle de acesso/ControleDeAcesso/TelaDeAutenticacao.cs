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
using MenuInicial;

namespace ControleDeAcesso
{
	//TelaDeLogin
	public partial class frmAutenticacao : Form
	{
		//Atributos
		private ctrlNavegacao navegacao = new ctrlNavegacao();
		private string nome { get; set; }
		private string senha { get; set; }
		public frmAutenticacao()
		{
			//Inicializador do formulário
			InitializeComponent();
		}

		//Configuração do botão de entrada do sistema
		private void Entrar(object sender, EventArgs e)
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
				//Criando o objeto e chamando a função do objeto mdlUsuario
				mdlUsuario _mdlUsuario = new mdlUsuario(nome, senha);
				bool retorno = ctrlAutenticacao.Autenticar(_mdlUsuario);
				if (retorno == true)
				{
					//thread de entrada do sistema
					Thread _thread = new Thread(navegacao.NavegarParaMenuInicial);
					_thread.SetApartmentState(ApartmentState.STA);
					_thread.Start();
					this.Close();
				}
				else
				{
					MessageBox.Show("Usuário inválido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		//Configuração botão de saída do sistema
		private void Sair(object sender, EventArgs e)
		{
			//método para fechar janela atual
			this.Close();
		}
	}
}
