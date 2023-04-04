using CONTROL;
using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEWS.Forms
{
	public partial class frmAlterar : Form
	{
		TextBox referencia;
		TextBox nomeDoVisitante;
		TextBox cpf;
		TextBox transportadora;
		TextBox cnpj;
		DateTimePicker dataEntrada;
		DateTimePicker horaEntrada;
		TextBox pesoEntrada;
		TextBox placaVeiculo;
		ComboBox natureza;
		TextBox visitado;
		DateTimePicker dataSaida;
		DateTimePicker horaSaida;
		TextBox pesoSaida;
		public frmAlterar()
		{
			InitializeComponent();
		}
		private void frmAlterar_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;	
		}
		private void Buscar(object sender, EventArgs e)
		{
			referencia = txtReferencia;
			nomeDoVisitante = txtNomeVisitante;
			cpf = txtCpf;
			transportadora = txtTransportadora;
			cnpj = txtCnpj;
			dataEntrada = dtEntrada;
			horaEntrada = dtHoraEntrada;
			pesoEntrada = txtPesoEntrada;
			placaVeiculo = txtPlacaVeiculo;
			natureza = cbNatureza;
			visitado = txtNomeVisitado;
			dataSaida = dtSaida;
			horaSaida = hrSaida;
			pesoSaida = txtPesoSaida;

			var retorno = ctrlEntrada.PesquisarEntradaFinalizada(int.Parse(referencia.Text));

			if (retorno == true)
			{
				nomeDoVisitante.Text = daoEntrada.GetNomeVisitante();
				cpf.Text = daoEntrada.GetCpf().ToString();
				transportadora.Text = daoEntrada.GetTransportadora();
				cnpj.Text = daoEntrada.GetCnpj().ToString();
				dataEntrada.Text = daoEntrada.GetDataEntrada();
				horaEntrada.Text = daoEntrada.GetHoraEntrada();
				pesoEntrada.Text = daoEntrada.GetPesoEntrada().ToString();
				placaVeiculo.Text = daoEntrada.GetPlacaVeiculo();
				natureza.Text = daoEntrada.GetNatureza();
				visitado.Text = daoEntrada.GetVisitado();
				dataSaida.Text = daoEntrada.GetDataSaida();
				horaSaida.Text = daoEntrada.GetHoraSaida();
				pesoSaida.Text = daoEntrada.GetPesoSaida().ToString();

				nomeDoVisitante.Enabled = true;
				cpf.Enabled = true;
				transportadora.Enabled = true;
				cnpj.Enabled = true;
				dataEntrada.Enabled = true;
				horaEntrada.Enabled = true;
				pesoEntrada.Enabled = true;
				placaVeiculo.Enabled = true;
				natureza.Enabled = true;
				visitado.Enabled = true;

				dataSaida.Enabled = true;
				horaSaida.Enabled = true;
				pesoSaida.Enabled = true;

			}
			else
			{
				var retorno2 = ctrlEntrada.Pesquisar(int.Parse(referencia.Text));

				if (retorno2 == true)
				{
					nomeDoVisitante.Text = daoEntrada.GetNomeVisitante();
					cpf.Text = daoEntrada.GetCpf().ToString();
					transportadora.Text = daoEntrada.GetTransportadora();
					cnpj.Text = daoEntrada.GetCnpj().ToString();
					dataEntrada.Text = daoEntrada.GetDataEntrada();
					horaEntrada.Text = daoEntrada.GetHoraEntrada();
					pesoEntrada.Text = daoEntrada.GetPesoEntrada().ToString();
					placaVeiculo.Text = daoEntrada.GetPlacaVeiculo();
					natureza.Text = daoEntrada.GetNatureza();
					visitado.Text = daoEntrada.GetVisitado();

					nomeDoVisitante.Enabled = true;
					cpf.Enabled = true;
					transportadora.Enabled = true;
					cnpj.Enabled = true;
					dataEntrada.Enabled = true;
					horaEntrada.Enabled = true;
					pesoEntrada.Enabled = true;
					placaVeiculo.Enabled = true;
					natureza.Enabled = true;
					visitado.Enabled = true;

					dtSaida.Enabled = false;
					hrSaida.Enabled = false;
					txtPesoSaida.Enabled = false;
				}
				else
				{
					MessageBox.Show("Registo não localizado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
		private async void Alterar(object sender, EventArgs e)
		{
			DialogResult resposta = MessageBox.Show("Confirma a alteração ?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (resposta == DialogResult.Yes)
			{
				if (dataSaida.Enabled == false && horaSaida.Enabled == false && pesoSaida.Enabled == false)
				{
					bool alterarEntrada = AlterarEntrada();
					if(alterarEntrada == true)
					{
						MessageBox.Show("Dados Alterados com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
						nomeDoVisitante.Text = String.Empty;
						cpf.Text = String.Empty;
						transportadora.Text = String.Empty;
						cnpj.Text = String.Empty;
						dataEntrada.Text = String.Empty;
						horaEntrada.Text = String.Empty;
						pesoEntrada.Text = String.Empty;
						placaVeiculo.Text = String.Empty;
						placaVeiculo.Text = String.Empty;
						natureza.Text = String.Empty;
						visitado.Text = String.Empty;
						referencia.Text = String.Empty;
						referencia.Focus();
					}
					else
					{
						MessageBox.Show("Erro na alteração", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				else
				{
					bool alterarEntrada = AlterarEntrada();
					await Task.Delay(1500);
					bool alterarSaida = AlterarSaida();

					if(alterarEntrada == true && alterarSaida == true)
					{
					MessageBox.Show("Dados Alterados com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
						nomeDoVisitante.Text = String.Empty;
						cpf.Text = String.Empty;
						transportadora.Text = String.Empty;
						cnpj.Text = String.Empty;
						dataEntrada.Text = String.Empty;
						horaEntrada.Text = String.Empty;
						pesoEntrada.Text = String.Empty;
						placaVeiculo.Text = String.Empty;
						placaVeiculo.Text = String.Empty;
						natureza.Text = String.Empty;
						visitado.Text = String.Empty;
						dataSaida.Text = String.Empty;
						horaSaida.Text = String.Empty;
						pesoSaida.Text = String.Empty;
						referencia.Text = String.Empty;
						referencia.Focus();
					}
					else
					{
					MessageBox.Show("Erro na alteração", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				
			}
		}
		public bool AlterarEntrada()
		{
			try
			{
				mdlEntrada mdlEntrada = new mdlEntrada();
				mdlEntrada.nomeVisitante = nomeDoVisitante.Text;
				mdlEntrada.cpf = Convert.ToInt64(cpf.Text);
				mdlEntrada.transportadora = transportadora.Text;
				mdlEntrada.cnpj = Convert.ToInt64(cnpj.Text);
				mdlEntrada.dataEntrada = dataEntrada.Value.ToString("dd-MM-yyyy");
				mdlEntrada.horaEntrada = horaEntrada.Value.ToString("HH:mm");
				mdlEntrada.pesoEntrada = Convert.ToDouble(pesoEntrada.Text);
				mdlEntrada.placaVeiculo = placaVeiculo.Text;
				mdlEntrada.natureza = natureza.Text;
				mdlEntrada.visitado = visitado.Text;

					bool retorno = ctrlEntrada.Alterar(mdlEntrada, Convert.ToInt32(referencia.Text));

					if (retorno == true)
					{
					return true;
					}
					else
					{
					return false;
					}
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public bool AlterarSaida()
		{
			try
			{
				mdlSaida _mdlSaida = new mdlSaida(dataSaida.Value.ToString("dd-MM-yyyy"), horaSaida.Value.ToString("HH:mm"), Convert.ToDouble(pesoSaida.Text));
				bool retorno = ctrlSaida.Alterar(_mdlSaida, Convert.ToInt32(referencia.Text));

					if (retorno == true)
					{
					return true;

					}
					else
					{
					return false;
					}
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
