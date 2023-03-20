using ControleDeConsulta;
using ControleDeEntrada;
using EntradaModel;
using MenuInicial;
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
		private void radEntrada_Selecionado(object sender, EventArgs e)
		{

		}
		private void frmConsulta_Carregamento(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			radEntrada.Checked = true;

			List<mdlEntrada> entradas = ctrlConsulta.ExibirEntradas();

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
			}
				listConsulta.Items.Add(lista); 
		}
	}
}
