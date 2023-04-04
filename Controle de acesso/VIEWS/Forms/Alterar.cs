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
	//TelaDeAlteração
	public partial class frmAlterar : Form
	{
		//Atributos
		private int referencia;
		private mdlEntrada _mdlEntrada;
		private mdlSaida _mdlSaida;
		//Inicialização do formulário
		public frmAlterar()
		{
			InitializeComponent();
		}
		private void Voltar()
		{
			//Thread para voltar ao menu anterior
			Thread _thread = new Thread(AppRunVoltar);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		private void Buscar()
		{
			referencia = Convert.ToInt32(txtReferencia.Text);
			bool retorno = ctrlEntrada.PesquisarEntradaFinalizada(referencia);
			if (retorno != false)
			{
				txtNomeVisitante.Text = daoEntrada.GetNomeVisitante();
				txtNomeVisitado.Text = daoEntrada.GetVisitado();
				txtDataEntrada.Text = daoEntrada.GetDataEntrada();
				txtHoraEntrada.Text = daoEntrada.GetHoraEntrada();
				txtCpf.Text = daoEntrada.GetCpf().ToString();
				txtCnpj.Text = daoEntrada.GetCnpj().ToString();
				txtPesoEntrada.Text = daoEntrada.GetPesoEntrada().ToString();
				txtPlacaVeiculo.Text = daoEntrada.GetPlacaVeiculo();
				txtDataSaida.Text = daoEntrada.GetDataSaida();
				txtHoraSaida.Text = daoEntrada.GetHoraSaida();
				txtPesoSaida.Text = daoEntrada.GetPesoSaida().ToString();
				btnAlterarSaida.Enabled = true;
			}
			else if (retorno == false)
			{
				//Validação para um segundo retorno
				bool segundoRetorno = ctrlEntrada.Pesquisar(referencia);
				if (segundoRetorno == true)
				{
					txtNomeVisitante.Text = daoEntrada.GetNomeVisitante();
					txtNomeVisitado.Text = daoEntrada.GetVisitado();
					txtDataEntrada.Text = daoEntrada.GetDataEntrada();
					txtHoraEntrada.Text = daoEntrada.GetHoraEntrada();
					txtCpf.Text = daoEntrada.GetCpf().ToString();
					txtCnpj.Text = daoEntrada.GetCnpj().ToString();
					txtPesoEntrada.Text = daoEntrada.GetPesoEntrada().ToString();
					txtPlacaVeiculo.Text = daoEntrada.GetPlacaVeiculo();
					txtDataSaida.Text = String.Empty;
					txtHoraSaida.Text = String.Empty;
					txtPesoSaida.Text = String.Empty;
					btnAlterarSaida.Enabled = false;
				}
			}
			else
			{
				MessageBox.Show("Busca não localizada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			Buscar();
		}
		private void btnAlterarEntrada_Click(object sender, EventArgs e)
		{
			_mdlEntrada.nomeVisitante = txtNomeVisitante.Text;
			_mdlEntrada.visitado = txtNomeVisitado.Text;
			_mdlEntrada.dataEntrada = txtDataEntrada.Text;
			_mdlEntrada.horaEntrada = txtHoraEntrada.Text;
			_mdlEntrada.cpf = Convert.ToInt32(txtCpf.Text);
			_mdlEntrada.cnpj = Convert.ToInt64(txtCnpj.Text);
			_mdlEntrada.pesoEntrada = Convert.ToDouble(txtPesoEntrada.Text);
			_mdlEntrada.placaVeiculo = txtPlacaVeiculo.Text;


		}
		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Voltar();
		}
		private void AppRunVoltar()
		{
			Application.Run(new frmMenuInicial());
		}

		private void frmAlterar_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}
	}
}
