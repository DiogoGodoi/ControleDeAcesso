using ControleDeEntrada;
using EntradaDao;
using EntradaModel;
using SaidaModel;
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
	//TelaDeAlteração
	public partial class frmAlterar : Form
	{
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
				txtNomeVisitante.Text = DaoEntrada.GetNomeVisitante();
				txtNomeVisitado.Text = DaoEntrada.GetVisitado();
				txtDataEntrada.Text = DaoEntrada.GetDataEntrada();
				txtHoraEntrada.Text = DaoEntrada.GetHoraEntrada();
				txtCpf.Text = DaoEntrada.GetCpf();
				txtCnpj.Text = DaoEntrada.GetCnpj();
				txtPesoEntrada.Text = DaoEntrada.GetPesoEntrada();
				txtPlacaVeiculo.Text = DaoEntrada.GetPlacaVeiculo();
				txtDataSaida.Text = DaoEntrada.GetDataSaida();
				txtHoraSaida.Text = DaoEntrada.GetHoraSaida();
				txtPesoSaida.Text = DaoEntrada.GetPesoSaida();
				btnAlterarSaida.Enabled = true;
			}
			else if (retorno == false)
			{
				//Validação para um segundo retorno
				bool segundoRetorno = ctrlEntrada.Pesquisar(referencia);
				if (segundoRetorno == true)
				{
					txtNomeVisitante.Text = DaoEntrada.GetNomeVisitante();
					txtNomeVisitado.Text = DaoEntrada.GetVisitado();
					txtDataEntrada.Text = DaoEntrada.GetDataEntrada();
					txtHoraEntrada.Text = DaoEntrada.GetHoraEntrada();
					txtCpf.Text = DaoEntrada.GetCpf();
					txtCnpj.Text = DaoEntrada.GetCnpj();
					txtPesoEntrada.Text = DaoEntrada.GetPesoEntrada();
					txtPlacaVeiculo.Text = DaoEntrada.GetPlacaVeiculo();
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
			_mdlEntrada.cpf = txtCpf.Text;
			_mdlEntrada.cnpj = txtCnpj.Text;
			_mdlEntrada.pesoEntrada = txtPesoEntrada.Text;
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
	}
}
