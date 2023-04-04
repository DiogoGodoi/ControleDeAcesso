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
using CONTROL;
using MODEL;
using DAO;

namespace VIEWS
{
	//TelaDeEntrada
	public partial class frmEntrada : Form
	{
		//Atributos
		private string nomeVisitante;
		private string transportadora;
		private string natureza;
		private long cpf;
		private long cnpj;
		private double pesoEntrada;
		private string visitado;
		private string placaVeiculo;
		private string horaEntrada;

		//Inicializador do formulário
		public frmEntrada()
		{
			InitializeComponent();
		}

		//Configuração do botão de cadastro

		private void EfetuarEntrada(object sender, EventArgs e)
		{
			//Bloco try para evitar quebra no sistema
			try
			{
				DialogResult mensagem = MessageBox.Show("Confirma a entrada ?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (mensagem == DialogResult.Yes)
				{
					//Pré validação dos campos do tipo numérico para inicialização
					if (txtCpf.Text == String.Empty && txtCnpj.Text == String.Empty && txtPesoEntrada.Text == String.Empty)
					{
						nomeVisitante = txtNomeVisitante.Text;
						transportadora = txtTransportadora.Text;
						visitado = txtNomeVisitado.Text;
						placaVeiculo = txtPlacaVeiculo.Text;
						cpf = 0;
						cnpj = 0;
						pesoEntrada = 0;
						natureza = cbNatureza.Text;
						horaEntrada = dtHoraEntrada.Value.ToString("HH:mm");
					}
					else if (txtCpf.Text == String.Empty && txtPesoEntrada.Text == String.Empty)
					{
						nomeVisitante = txtNomeVisitante.Text;
						transportadora = txtTransportadora.Text;
						visitado = txtNomeVisitado.Text;
						placaVeiculo = txtPlacaVeiculo.Text;
						cpf = 0;
						cnpj = Convert.ToInt64(txtCnpj.Text);
						pesoEntrada = 0;
						natureza = cbNatureza.Text;
						horaEntrada = dtHoraEntrada.Value.ToString("HH:mm");
					}
					else if (txtCnpj.Text == String.Empty && txtPesoEntrada.Text == String.Empty)
					{
						nomeVisitante = txtNomeVisitante.Text;
						transportadora = txtTransportadora.Text;
						visitado = txtNomeVisitado.Text;
						placaVeiculo = txtPlacaVeiculo.Text;
						cpf = Convert.ToInt64(txtCpf.Text);
						cnpj = 0;
						pesoEntrada = 0;
						natureza = cbNatureza.Text;
						horaEntrada = dtHoraEntrada.Value.ToString("HH:mm");
					}
					else if (txtCpf.Text == String.Empty && txtCnpj.Text == String.Empty)
					{
						nomeVisitante = txtNomeVisitante.Text;
						transportadora = txtTransportadora.Text;
						visitado = txtNomeVisitado.Text;
						placaVeiculo = txtPlacaVeiculo.Text;
						cpf = 0;
						cnpj = 0;
						pesoEntrada = Convert.ToInt64(txtPesoEntrada.Text);
						natureza = cbNatureza.Text;
						horaEntrada = dtHoraEntrada.Value.ToString("HH:mm");
					}
					else if (txtCpf.Text == String.Empty)
					{
						nomeVisitante = txtNomeVisitante.Text;
						transportadora = txtTransportadora.Text;
						visitado = txtNomeVisitado.Text;
						placaVeiculo = txtPlacaVeiculo.Text;
						cpf = 0;
						cnpj = Convert.ToInt64(txtCnpj.Text);
						pesoEntrada = Convert.ToInt64(txtPesoEntrada.Text);
						natureza = cbNatureza.Text;
						horaEntrada = dtHoraEntrada.Value.ToString("HH:mm");
					}
					else if (txtCnpj.Text == String.Empty)
					{
						nomeVisitante = txtNomeVisitante.Text;
						transportadora = txtTransportadora.Text;
						visitado = txtNomeVisitado.Text;
						placaVeiculo = txtPlacaVeiculo.Text;
						cpf = Convert.ToInt64(txtCpf.Text);
						cnpj = 0;
						pesoEntrada = Convert.ToInt64(txtPesoEntrada.Text);
						natureza = cbNatureza.Text;
						horaEntrada = dtHoraEntrada.Value.ToString("HH:mm");
					}
					else
					{
						nomeVisitante = txtNomeVisitante.Text;
						transportadora = txtTransportadora.Text;
						visitado = txtNomeVisitado.Text;
						placaVeiculo = txtPlacaVeiculo.Text;
						cpf = Convert.ToInt64(txtCpf.Text);
						cnpj = Convert.ToInt64(txtCnpj.Text);
						pesoEntrada = Convert.ToInt64(txtPesoEntrada.Text);
						natureza = cbNatureza.Text;
						horaEntrada = dtHoraEntrada.Value.ToString("HH:mm");
					}
					//Segunda validação dos campos 
					if (txtCpf.Text == String.Empty && txtCnpj.Text == String.Empty &&
						txtPesoEntrada.Text == String.Empty && txtNomeVisitante.Text == String.Empty &&
						txtNomeVisitado.Text == String.Empty)
					{
						MessageBox.Show("Por favor insira os dados", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtNomeVisitante.Text == String.Empty)
					{
						MessageBox.Show("Por favor insira o nome do visitante", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtNomeVisitado.Text == String.Empty)
					{
						MessageBox.Show("Por favor insira o nome do visitado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtCpf.Text == String.Empty && txtCnpj.Text == String.Empty)
					{
						MessageBox.Show("Por favor insira o cpf ou o cnpj do visitante", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtTransportadora.Text == String.Empty && txtCnpj.Text != String.Empty)
					{
						MessageBox.Show("Por favor insira o nome da transportadora", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (cbNatureza.Text == String.Empty)
					{
						MessageBox.Show("Por favor insira a natureza da entrada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtNomeVisitante.Text != String.Empty
						&& txtNomeVisitado.Text != String.Empty
						&& txtCpf.Text != String.Empty
						&& txtCnpj.Text == String.Empty
						&& txtPesoEntrada.Text != String.Empty
						&& txtPlacaVeiculo.Text == String.Empty)
					{
						MessageBox.Show("Por favor a placa do veículo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtNomeVisitante.Text != String.Empty
						&& txtNomeVisitado.Text != String.Empty
						&& txtCpf.Text == String.Empty
						&& txtCnpj.Text != String.Empty
						&& txtTransportadora.Text != String.Empty
						&& txtPesoEntrada.Text != String.Empty
						&& txtPlacaVeiculo.Text == String.Empty)
					{
						MessageBox.Show("Por favor a placa do veículo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtNomeVisitante.Text != String.Empty
						&& txtNomeVisitado.Text != String.Empty
						&& txtCpf.Text != String.Empty
						&& txtCnpj.Text != String.Empty
						&& txtTransportadora.Text != String.Empty
						&& txtPesoEntrada.Text != String.Empty
						&& txtPlacaVeiculo.Text == String.Empty)
					{
						MessageBox.Show("Por favor a placa do veículo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (txtNomeVisitante.Text != String.Empty
						&& txtNomeVisitado.Text != String.Empty
						&& txtCpf.Text != String.Empty
						&& txtCnpj.Text == String.Empty
						&& txtPesoEntrada.Text != String.Empty
						&& txtPesoEntrada.Text != String.Empty)
					{
						//Ciração de objeto e chamada de método para efetuar a entrada dos dados
						mdlEntrada dados = new mdlEntrada(horaEntrada, nomeVisitante, cpf, cnpj, pesoEntrada, visitado, placaVeiculo, transportadora, natureza, daoUsuario.idUsuario);

						bool retorno = ctrlEntrada.EfetuarEntrada(dados);

						//Validação para sucesso ou falha na entrada de dados
						if (retorno != false)
						{
							MessageBox.Show("Cadastrado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtNomeVisitante.Text = String.Empty;
							txtNomeVisitado.Text = String.Empty;
							txtTransportadora.Text = String.Empty;
							txtCpf.Text = String.Empty;
							txtCnpj.Text = String.Empty;
							txtPesoEntrada.Text = String.Empty;
							txtPlacaVeiculo.Text = String.Empty;
							txtNomeVisitante.Focus();
						}
						else
						{
							MessageBox.Show("Erro no cadastro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

					}
					else if (txtNomeVisitante.Text != String.Empty
					&& txtNomeVisitado.Text != String.Empty
					&& txtCpf.Text == String.Empty
					&& txtCnpj.Text != String.Empty
					&& txtPesoEntrada.Text != String.Empty
					&& txtPlacaVeiculo.Text != String.Empty)
					{
						//Ciração de objeto e chamada de método para efetuar a entrada dos dados
						mdlEntrada _mdlEntrada = new mdlEntrada(horaEntrada, nomeVisitante, cpf, cnpj, pesoEntrada, visitado, placaVeiculo, transportadora, cbNatureza.Text, daoUsuario.idUsuario);

						bool retorno = ctrlEntrada.EfetuarEntrada(_mdlEntrada);

						if (retorno != false)
						{
							MessageBox.Show("Cadastrado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtNomeVisitante.Text = String.Empty;
							txtNomeVisitado.Text = String.Empty;
							txtTransportadora.Text = String.Empty;
							txtCpf.Text = String.Empty;
							txtCnpj.Text = String.Empty;
							txtPesoEntrada.Text = String.Empty;
							txtPlacaVeiculo.Text = String.Empty;
							txtNomeVisitante.Focus();
						}
						else
						{
							MessageBox.Show("Erro no cadastro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						//Ciração de objeto e chamada de método para efetuar a entrada dos dados
						mdlEntrada _mdlEntrada = new mdlEntrada(dtHoraEntrada.Value.ToString("HH:mm"), nomeVisitante, cpf, cnpj, pesoEntrada, visitado, placaVeiculo, transportadora, natureza, daoUsuario.idUsuario);

						bool retorno = ctrlEntrada.EfetuarEntrada(_mdlEntrada);

						if (retorno != false)
						{
							MessageBox.Show("Cadastrado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtNomeVisitante.Text = String.Empty;
							txtNomeVisitado.Text = String.Empty;
							txtTransportadora.Text = String.Empty;
							txtCpf.Text = String.Empty;
							txtCnpj.Text = String.Empty;
							txtPesoEntrada.Text = String.Empty;
							txtPlacaVeiculo.Text = String.Empty;
							txtNomeVisitante.Focus();
						}
						else
						{
							MessageBox.Show("Erro no cadastro", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			catch (FormatException)
			{
				MessageBox.Show("Os campos cpf, cnpj, e peso de entrada só aceitam numeros", "Mensagm", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void frmEntrada_Load(object sender, EventArgs e)
		{
			dtHoraEntrada.Text = DateTime.Now.ToString("dd-MM-yyyy");
			this.WindowState = FormWindowState.Maximized;
		}
	}
}
