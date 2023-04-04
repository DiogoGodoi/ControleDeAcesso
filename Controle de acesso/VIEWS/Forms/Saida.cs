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
using CONTROL;
using MODEL;
using DAO;

namespace VIEWS
{
	//TelaDeSaida
	public partial class frmSaida : Form
	{
		//Atributos
		private mdlEntrada dados = new mdlEntrada();
		private int referencia;
		private string dataSaida;
		private string horaSaida;
		private double pesoSaida;

		//Inicialização do formulário
		public frmSaida()
		{
			InitializeComponent();
		}
		//Configuração do botão de cadastrar
		private void EfetuarSaida(object sender, EventArgs e)
		{
			//Método de cadastro
			//Blobo try catch para evitar quebras no sistema
			try
			{
				referencia = Convert.ToInt32(txtReferencia.Text);
				dataSaida = dtSaida.Value.ToString("dd-MM-yyyy");
				horaSaida = hrSaida.Value.ToString("HH:mm");
				pesoSaida = Convert.ToDouble(txtPesoSaida.Text);
				mdlSaida dados = new mdlSaida(referencia, dataSaida, horaSaida, pesoSaida);

				if (dataSaida == String.Empty && horaSaida == String.Empty)
				{
					MessageBox.Show("Por favor insira os dados de saída", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (dataSaida == String.Empty)
				{
					MessageBox.Show("Insira a data de saída", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (horaSaida == String.Empty)
				{
					MessageBox.Show("Insira a hora de saída", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if (txtPesoSaida.Text == "0" && txtPesoEntrada.Text != String.Empty)
				{
					MessageBox.Show("Insira o peso de saída", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					DialogResult mensagem = MessageBox.Show("Confirma a saída", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (mensagem == DialogResult.Yes)
					{

						bool retorno = ctrlSaida.EfetuarSaida(dados);
						if (retorno == true)
						{
							MessageBox.Show("Saida efetuada com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
							dtSaida.Text = String.Empty;
							hrSaida.Text = String.Empty;
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
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro interno: " + ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//Configuração do botão de buscar

		private void Buscar(object sender, EventArgs e)
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
						dados.nomeVisitante = daoEntrada.GetNomeVisitante();
						dados.visitado = daoEntrada.GetVisitado();
						dados.cpf = daoEntrada.GetCpf();
						dados.cnpj = daoEntrada.GetCnpj();
						dados.dataEntrada = daoEntrada.GetDataEntrada();
						dados.horaEntrada = daoEntrada.GetHoraEntrada();
						dados.pesoEntrada = daoEntrada.GetPesoEntrada();
						dados.placaVeiculo = daoEntrada.GetPlacaVeiculo();
						txtNomeVisitante.Text = dados.nomeVisitante;
						txtNomeVisitado.Text = dados.visitado;
						txtCpf.Text = Convert.ToString(dados.cpf);
						txtCnpj.Text = dados.cnpj.ToString();
						txtDataEntrada.Text = dados.dataEntrada;
						txtHoraEntrada.Text = dados.horaEntrada;
						txtPesoEntrada.Text = daoEntrada.GetPesoEntrada().ToString();
						txtPlacaVeiculo.Text = dados.placaVeiculo;
						txtTransportadora.Text = daoEntrada.GetTransportadora();
						txtNatureza.Text = daoEntrada.GetNatureza();

						dataSaida = daoEntrada.GetDataSaida();
						dtSaida.Text = dataSaida;
						horaSaida = daoEntrada.GetHoraSaida();
						hrSaida.Text = horaSaida;
						pesoSaida = daoEntrada.GetPesoSaida();
						txtPesoSaida.Text = pesoSaida.ToString();

						if (dataSaida != String.Empty | horaSaida != String.Empty)
						{
							dtSaida.Enabled = false;
							hrSaida.Enabled = false;
							txtPesoSaida.Enabled = false;
							btnCadastrar.Enabled = false;
							MessageBox.Show("O acesso já encontra-se baixado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

					}
					else
					{
						bool segundoRetorno = daoEntrada.PesquisarEntrada(referencia);

						if (segundoRetorno == true)
						{
							dados.nomeVisitante = daoEntrada.GetNomeVisitante();
							dados.visitado = daoEntrada.GetVisitado();
							dados.cpf = daoEntrada.GetCpf();
							dados.cnpj = daoEntrada.GetCnpj();
							dados.dataEntrada = daoEntrada.GetDataEntrada();
							dados.horaEntrada = daoEntrada.GetHoraEntrada();
							dados.pesoEntrada = daoEntrada.GetPesoEntrada();
							dados.placaVeiculo = daoEntrada.GetPlacaVeiculo();

							txtNomeVisitante.Text = dados.nomeVisitante;
							txtNomeVisitado.Text = dados.visitado;
							txtCpf.Text = dados.cpf.ToString();
							txtCnpj.Text = dados.cnpj.ToString();
							txtDataEntrada.Text = dados.dataEntrada;
							txtHoraEntrada.Text = dados.horaEntrada;
							txtPesoEntrada.Text = dados.pesoEntrada.ToString();
							txtPlacaVeiculo.Text = dados.placaVeiculo;
							dtSaida.Text = String.Empty;
							hrSaida.Text = String.Empty;
							txtPesoSaida.Text = "0";
							dtSaida.Enabled = true;
							hrSaida.Enabled = true;
							txtPesoSaida.Enabled = true;
							btnCadastrar.Enabled = true;
						}
						else
						{
							MessageBox.Show("Não existe entrada com a referência informada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
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
		private void frmSaida_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}

	}
}
