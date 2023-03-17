using ControleDeEntrada;
using ControleDeSaida;
using EntradaDao;
using Menu_Inicial;
using SaidaModel;
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

namespace Saida
{
	//TelaDeSaida
	public partial class frmSaida : Form
	{
		//Atributos
		private Thread _thread;
		private int referencia;
		private string nomeVisitante;
		private string visitado;
		private string cpf;
		private string cnpj;
		private string dataEntrada;
		private string horaEntrada;
		private string pesoEntrada;
		private string placaVeiculo;
		private string dataSaida;
		private string horaSaida;
		private string pesoSaida;

		//Inicialização do formulário
		public frmSaida()
		{
			InitializeComponent();
		}

		//Configuração do método de cadastro
		private void Cadastrar()
		{
			//Blobo try catch para evitar quebras no sistema
			try
			{
				referencia = Convert.ToInt32(txtReferencia.Text);
				dataSaida = txtDataSaida.Text;
				horaSaida = txtHoraSaida.Text;
				pesoSaida = txtPesoSaida.Text;
				mdlSaida _mdlSaida = new mdlSaida(referencia, dataSaida, horaSaida, pesoSaida);

				if (dataSaida == String.Empty && horaSaida == String.Empty)
				{
					MessageBox.Show("Por favor insira os dados de saída", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (dataSaida == String.Empty)
				{
					MessageBox.Show("Insira a data de saída", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (horaSaida == String.Empty)
				{
					MessageBox.Show("Insira a hora de saída", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					bool retorno = ctrlSaida.EfetuarSaida(_mdlSaida);
					if (retorno == true)
					{
						MessageBox.Show("Saida efetuada com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtDataSaida.Text = String.Empty;
						txtHoraSaida.Text = String.Empty;
						txtPesoSaida.Text = String.Empty;
						txtReferencia.Text = String.Empty;
						txtReferencia.Focus();
					}
					else
					{
						MessageBox.Show("Erro na operação", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro interno: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//Configuração do método de busca
		private void Buscar()
		{
			//Bloco try catch para a não quebra do sistema
			try
			{
				//Validação do campo de referência
				if (txtReferencia.Text != String.Empty)
				{
					referencia = Convert.ToInt32(txtReferencia.Text);
					bool retorno = ctrlEntrada.PesquisarEntradaFinalizada(referencia);

					if (retorno == true)
					{
						nomeVisitante = DaoEntrada.GetNomeVisitante();
						txtNomeVisitante.Text = nomeVisitante;
						visitado = DaoEntrada.GetVisitado();
						txtNomeVisitado.Text = visitado;
						cpf = DaoEntrada.GetCpf().ToString();
						txtCpf.Text = cpf;
						cnpj = DaoEntrada.GetCnpj().ToString();
						txtCnpj.Text = cnpj;
						dataEntrada = DaoEntrada.GetDataEntrada();
						txtDataEntrada.Text = dataEntrada;
						horaEntrada = DaoEntrada.GetHoraEntrada();
						txtHoraEntrada.Text = horaEntrada;
						pesoEntrada = DaoEntrada.GetPesoEntrada().ToString();
						txtPesoEntrada.Text = pesoEntrada;
						placaVeiculo = DaoEntrada.GetPlacaVeiculo();
						txtPlacaVeiculo.Text = placaVeiculo;
						dataSaida = DaoEntrada.GetDataSaida();
						txtDataSaida.Text = dataSaida;
						horaSaida = DaoEntrada.GetHoraSaida();
						txtHoraSaida.Text = horaSaida;
						pesoSaida = DaoEntrada.GetPesoSaida();
						txtPesoSaida.Text= pesoSaida;
						
						if(dataSaida != String.Empty | horaSaida != String.Empty)
						{
							txtDataSaida.Enabled = false;
							txtHoraSaida.Enabled = false;
							txtPesoSaida.Enabled = false;
							btnCadastrar.Enabled = false;
							MessageBox.Show("O acesso já encontra-se baixado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

					}else if(retorno == false)
					{
						bool segundoRetorno = DaoEntrada.PesquisarEntrada(referencia);
						nomeVisitante = DaoEntrada.GetNomeVisitante();
						txtNomeVisitante.Text = nomeVisitante;
						visitado = DaoEntrada.GetVisitado();
						txtNomeVisitado.Text = visitado;
						cpf = DaoEntrada.GetCpf().ToString();
						txtCpf.Text = cpf;
						cnpj = DaoEntrada.GetCnpj().ToString();
						txtCnpj.Text = cnpj;
						dataEntrada = DaoEntrada.GetDataEntrada();
						txtDataEntrada.Text = dataEntrada;
						horaEntrada = DaoEntrada.GetHoraEntrada();
						txtHoraEntrada.Text = horaEntrada;
						pesoEntrada = DaoEntrada.GetPesoEntrada().ToString();
						txtPesoEntrada.Text = pesoEntrada;
						placaVeiculo = DaoEntrada.GetPlacaVeiculo();
						txtPlacaVeiculo.Text = placaVeiculo;
						txtDataSaida.Text = String.Empty;
						txtHoraSaida.Text = String.Empty;
						txtPesoSaida.Text = String.Empty;
						txtDataSaida.Enabled = true;
						txtHoraSaida.Enabled = true;
						txtPesoSaida.Enabled = true;
						btnCadastrar.Enabled = true;
					}
					else
					{
						MessageBox.Show("Não existe entrada com a referência informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
					MessageBox.Show("Por favor digite a referência de entrada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro interno: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//Configuração do método voltar
		private void Voltar()
		{
			//Thread para voltar ao formulário anterior
			_thread = new Thread(AppRunVoltar);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}

		//Configuração do botão de voltar
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Voltar();
		}
		//Configuração do botão de buscar
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			Buscar();
		}
		//Configuração do botão de cadastrar
		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			//Método de cadastro
			Cadastrar();
		}
		//Configuração do formulário de anterior que alimentará a thread
		private void AppRunVoltar()
		{
			Application.Run(new frmMenuInicial());
		}
	}
}
