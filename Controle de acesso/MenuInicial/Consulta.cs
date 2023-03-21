using ControleDeConsulta;
using ControleDeEntrada;
using EntradaModel;
using MenuInicial;
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

namespace Menu_Inicial
{
	public partial class frmConsulta : Form
	{
		ListViewItem lista;
		public frmConsulta()
		{
			InitializeComponent();
		}
		private void Voltar(object sender, EventArgs e)
		{
			ctrlNavegacao navegar = new ctrlNavegacao();
			Thread _thread = new Thread(navegar.NavegarParaMenuInicial);
			_thread.SetApartmentState(ApartmentState.STA);
			_thread.Start();
			this.Close();
		}
		private void radEntrada_CheckedChanged(object sender, EventArgs e)
		{
			listEntrada.Items.Clear();
			listEntrada.Enabled = true;
			listEntrada.Visible = true;
			listSaida.Enabled = false;
			listSaida.Visible = false;
			listFinalizada.Enabled = false;
			listFinalizada.Visible = false;

			List<mdlEntrada> entradas = ctrlConsulta.ExibirEntrada();

			if (entradas != null)
			{
				foreach (var item in entradas)
				{
					lista = new ListViewItem(item.referencia.ToString());
					lista.SubItems.Add(item.nomeVisitante);
					lista.SubItems.Add(item.visitado);
					lista.SubItems.Add(item.dataEntrada);
					lista.SubItems.Add(item.horaEntrada);
					lista.SubItems.Add(item.cpf.ToString());
					lista.SubItems.Add(item.cnpj.ToString());
					lista.SubItems.Add(item.pesoEntrada.ToString());
					lista.SubItems.Add(item.placaVeiculo);
					lista.SubItems.Add(item.idUsuario.ToString());
					listEntrada.Items.Add(lista);
				}
			}
			else
			{
				lista = new ListViewItem("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				listFinalizada.Items.Add(lista);
			}
		}
		private void radSaida_CheckedChanged(object sender, EventArgs e)
		{
			listSaida.Items.Clear();
			listSaida.Enabled = true;
			listSaida.Visible = true;
			listEntrada.Enabled = false;
			listEntrada.Visible = false;
			listFinalizada.Enabled = false;
			listFinalizada.Visible = false;

			List<mdlSaida> saidas = ctrlConsulta.ExibirSaida();

			if (saidas != null)
			{
				foreach (var item in saidas)
				{
					lista = new ListViewItem(item.referencia.ToString());
					lista.SubItems.Add(item.dados.nomeVisitante);
					lista.SubItems.Add(item.dataSaida);
					lista.SubItems.Add(item.horaSaida);
					lista.SubItems.Add(item.pesoSaida.ToString());
					lista.SubItems.Add(item.idUsuario.ToString());
					listSaida.Items.Add(lista);
				}
			}
			else
			{
				lista = new ListViewItem("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				listFinalizada.Items.Add(lista);
			}
		}
		private void frmConsulta_Carregamento(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;

			listEntrada.Items.Clear();
			listEntrada.Enabled = true;
			listEntrada.Visible = true;
			listSaida.Enabled = false;
			listSaida.Visible = false;
			listFinalizada.Enabled = false;
			listFinalizada.Visible = false;

			List<mdlEntrada> entradas = ctrlConsulta.ExibirEntrada();

			if (entradas != null)
			{
				foreach (var item in entradas)
				{
					lista = new ListViewItem(item.referencia.ToString());
					lista.SubItems.Add(item.nomeVisitante);
					lista.SubItems.Add(item.visitado);
					lista.SubItems.Add(item.dataEntrada);
					lista.SubItems.Add(item.horaEntrada);
					lista.SubItems.Add(item.cpf.ToString());
					lista.SubItems.Add(item.cnpj.ToString());
					lista.SubItems.Add(item.pesoEntrada.ToString());
					lista.SubItems.Add(item.placaVeiculo);
					lista.SubItems.Add(item.idUsuario.ToString());
					listEntrada.Items.Add(lista);
				}
			}
			else
			{
				lista = new ListViewItem("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				listFinalizada.Items.Add(lista);
			}
		}
		private void Todos_CheckedChanged(object sender, EventArgs e)
		{
			listFinalizada.Items.Clear();
			listFinalizada.Enabled = true;
			listFinalizada.Visible = true;
			listEntrada.Enabled = false;
			listEntrada.Visible = false;
			listSaida.Enabled = false;
			listSaida.Visible = false;

			List<mdlEntrada> entradasFinalizada = ctrlConsulta.ExibirEntradaFinalizada();

			if (entradasFinalizada != null)
			{
				foreach (var item in entradasFinalizada)
				{
					lista = new ListViewItem(item.referencia.ToString());
					lista.SubItems.Add(item.nomeVisitante);
					lista.SubItems.Add(item.visitado);
					lista.SubItems.Add(item.cnpj.ToString());
					lista.SubItems.Add(item.cpf.ToString());
					lista.SubItems.Add(item.placaVeiculo);
					lista.SubItems.Add(item.dataEntrada);
					lista.SubItems.Add(item.dataSaida);
					lista.SubItems.Add(item.horaEntrada);
					lista.SubItems.Add(item.horaSaida);
					lista.SubItems.Add(item.pesoEntrada.ToString());
					lista.SubItems.Add(item.pesoSaida.ToString());
					lista.SubItems.Add(item.idUsuarioEntrada.ToString());
					lista.SubItems.Add(item.idUsuarioSaida.ToString());
					listFinalizada.Items.Add(lista);
				}
			}else
			{
				lista = new ListViewItem("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				listFinalizada.Items.Add(lista);
			}
		}
	}
}
