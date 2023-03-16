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
using EntradaModel;
using ControleDeEntrada;
using Menu_Inicial;
using EntradaDao;

namespace Menu_Inicial
{
	//TelaDeEntrada
	public partial class frmEntrada : Form
	{
		//Atributos
		private string nomeVisitante;
		private string cpf;
		private string cnpj;
		private string pesoEntrada;
		private string visitado;
		private string placaVeiculo;

		//Inicializador do formulário
		public frmEntrada()
		{
			InitializeComponent();
		}
		//Configuração do método de entrada de acesso de pessoal
		private void EfetuarEntrada()
		{
			nomeVisitante = txtNomeVisitante.Text;
			cpf = txtCpf.Text;
			cnpj = txtCnpj.Text;
			pesoEntrada = txtPesoEntrada.Text;
			visitado = txtNomeVisitado.Text;
			placaVeiculo = txtPlacaVeiculo.Text;

			//Validação dos campos de entrada
			if (nomeVisitante == String.Empty)
			{
				MessageBox.Show("Por favor insira o nome do visitante", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (visitado == String.Empty)
			{
				MessageBox.Show("Por favor insira o nome do visitado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				//Bloco try e catch para a não quebra do sistema
				try
				{
					mdlEntrada _mdlEntrada = new mdlEntrada(nomeVisitante, cpf, cnpj, pesoEntrada, visitado, placaVeiculo);

					bool retorno = ctrlEntrada.EfetuarEntrada(_mdlEntrada);

					if (retorno != false)
					{
						MessageBox.Show("Cadastrado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Erro no cadastro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro interno" + ex.Message);
				}
			}
		}
		//Configuração da método para voltar ao menu anterior
		private void Voltar()
		{
			//Thread para voltar ao menu anterior
			Thread _thread = new Thread(AppRunVoltar);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}

		//Configuração do botão de cadastro
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			//Método para efetuar o acesso de entrada de dados junto ao banco 
			EfetuarEntrada();
		}
		//Configuração do botão de voltar
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Voltar();
		}
		//Configuração do formulário inicial que alimentará a Thread
		private void AppRunVoltar()
		{
			Application.Run(new frmMenuInicial());
		}
	}
}
