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
	//TelaDeConsulta
	public partial class frmConsulta : Form
	{
		ListViewItem lista;
		DataTable dataGrid;
		public frmConsulta()
		{
			InitializeComponent();
		}
		private void InicializacaoDefault(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			List<mdlEntrada> entradas = ctrlConsulta.ExibirEntrada();

			if (entradas != null)
			{
				var busca = entradas.Where(i => i.dataEntrada == dtBusca.Value.ToString("dd-MM-yyyy"));
				if (busca.Count() > 0)
				{
					foreach (var item in busca)
					{
						lista = new ListViewItem(item.referencia.ToString());
						lista.SubItems.Add(item.nomeVisitante);
						lista.SubItems.Add(item.cpf.ToString());
						lista.SubItems.Add(item.transportadora);
						lista.SubItems.Add(item.cnpj.ToString());
						lista.SubItems.Add(item.natureza);
						lista.SubItems.Add(item.visitado);
						lista.SubItems.Add(item.dataEntrada);
						lista.SubItems.Add(item.horaEntrada);
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
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
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
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				listEntrada.Items.Add(lista);
			}
		}
		private void ExibirEntrada(object sender, EventArgs e)
		{
			btnImprimir.Visible = true;
			listEntrada.Items.Clear();
			List<mdlEntrada> entradas = ctrlConsulta.ExibirEntrada();

			if (entradas != null)
			{
				var busca = entradas.Where(i => i.dataEntrada == dtBusca.Value.ToString("dd-MM-yyyy"));
				if (busca.Count() > 0)
				{
					foreach (var item in busca)
					{
						lista = new ListViewItem(item.referencia.ToString());
						lista.SubItems.Add(item.nomeVisitante);
						lista.SubItems.Add(item.cpf.ToString());
						lista.SubItems.Add(item.transportadora);
						lista.SubItems.Add(item.cnpj.ToString());
						lista.SubItems.Add(item.natureza);
						lista.SubItems.Add(item.visitado);
						lista.SubItems.Add(item.dataEntrada);
						lista.SubItems.Add(item.horaEntrada);
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
					lista.SubItems.Add("Sem dados");
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
				lista.SubItems.Add("Sem dados");
				listEntrada.Items.Add(lista);
			}
		}
		private void ExibirSaida(object sender, EventArgs e)
		{
			btnImprimir.Visible = true;
			listSaida.Items.Clear();
			List<mdlSaida> saidas = ctrlConsulta.ExibirSaida();
			if (saidas != null)
			{
				var busca = saidas.Where(i => i.dataSaida == dtBusca.Value.ToString("dd-MM-yyyy"));
				if (busca.Count() > 0)
				{
					foreach (var item in busca)
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
				listSaida.Items.Add(lista);
			}
		}
		private void ExibirEntradaFinalizada(object sender, EventArgs e)
		{
			btnImprimir.Visible = false;
			listFinalizada.Items.Clear();
			List<mdlEntrada> entradasFinalizada = ctrlConsulta.ExibirEntradaFinalizada();

			if (entradasFinalizada != null)
			{
				var busca = entradasFinalizada.Where(i => i.dataEntrada == dtBusca.Value.ToString("dd-MM-yyyy"));
				if (busca.Count() > 0)
				{
					foreach (var item in busca)
					{
						var saldo = 0.0;

						if (item.pesoEntrada > item.pesoSaida)
						{
							saldo = item.pesoEntrada - item.pesoSaida;
						}
						else if (item.pesoSaida > item.pesoEntrada) {
							saldo = item.pesoSaida - item.pesoEntrada;
						}

						lista = new ListViewItem(item.referencia.ToString());
						lista.SubItems.Add(item.nomeVisitante);
						lista.SubItems.Add(item.cpf.ToString());
						lista.SubItems.Add(item.transportadora);
						lista.SubItems.Add(item.cnpj.ToString());
						lista.SubItems.Add(item.placaVeiculo);
						lista.SubItems.Add(item.dataEntrada);
						lista.SubItems.Add(item.dataSaida);
						lista.SubItems.Add(item.horaEntrada);
						lista.SubItems.Add(item.horaSaida);
						lista.SubItems.Add(item.pesoEntrada.ToString());
						lista.SubItems.Add(item.pesoSaida.ToString());
						lista.SubItems.Add(saldo.ToString());
						lista.SubItems.Add(item.natureza);
						lista.SubItems.Add(item.visitado);
						lista.SubItems.Add(item.idUsuarioEntrada.ToString());
						lista.SubItems.Add(item.idUsuarioSaida.ToString());
						listFinalizada.Items.Add(lista);
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
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					listFinalizada.Items.Add(lista);
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
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				lista.SubItems.Add("Sem dados");
				listFinalizada.Items.Add(lista);
			}
		}
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			List<mdlEntrada> entradas = new List<mdlEntrada>();
			entradas = ctrlConsulta.ExibirEntrada();
			List<mdlSaida> saidas = new List<mdlSaida>();
			saidas = ctrlConsulta.ExibirSaida();
			List<mdlEntrada> entradasFinalizadas = new List<mdlEntrada>();
			entradasFinalizadas = ctrlConsulta.ExibirEntradaFinalizada();

			if (tabEntrada.Focus())
			{
				listEntrada.Items.Clear();
				var busca = entradas.Where(i => i.dataEntrada == dtBusca.Value.ToString("dd-MM-yyyy"));
				if (busca.Count() > 0)
				{
					foreach (var item in busca)
					{
						lista = new ListViewItem(item.referencia.ToString());
						lista.SubItems.Add(item.nomeVisitante);
						lista.SubItems.Add(item.cpf.ToString());
						lista.SubItems.Add(item.transportadora);
						lista.SubItems.Add(item.cnpj.ToString());
						lista.SubItems.Add(item.natureza);
						lista.SubItems.Add(item.visitado);
						lista.SubItems.Add(item.dataEntrada);
						lista.SubItems.Add(item.horaEntrada);
						lista.SubItems.Add(item.pesoEntrada.ToString());
						lista.SubItems.Add(item.placaVeiculo);
						lista.SubItems.Add(item.idUsuario.ToString());
						listEntrada.Items.Add(lista);
					}
				}
				else
				{
					listEntrada.Items.Clear();
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
					listEntrada.Items.Add(lista);
				}
			}
			else if (tabSaidas.Focus())
			{
				listSaida.Items.Clear();
				var busca = saidas.Where(i => i.dataSaida == dtBusca.Value.ToString("dd-MM-yyyy"));
				if (busca.Count() > 0)
				{
					foreach (var item in busca)
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
					listSaida.Items.Clear();
					lista = new ListViewItem("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					lista.SubItems.Add("Sem dados");
					listSaida.Items.Add(lista);
				}
			}
			else if (tabAcessoFinalizado.Focus())
			{
				listFinalizada.Items.Clear();
				var busca = entradasFinalizadas.Where(i => i.dataEntrada == dtBusca.Value.ToString("dd-MM-yyyy"));
				if (busca.Count() > 0)
				{
					foreach (var item in busca)
					{
						double saldo = item.pesoEntrada - item.pesoSaida;
						lista = new ListViewItem(item.referencia.ToString());
						lista.SubItems.Add(item.nomeVisitante);
						lista.SubItems.Add(item.cpf.ToString());
						lista.SubItems.Add(item.transportadora);
						lista.SubItems.Add(item.cnpj.ToString());
						lista.SubItems.Add(item.placaVeiculo);
						lista.SubItems.Add(item.dataEntrada);
						lista.SubItems.Add(item.dataSaida);
						lista.SubItems.Add(item.horaEntrada);
						lista.SubItems.Add(item.horaSaida);
						lista.SubItems.Add(item.pesoEntrada.ToString());
						lista.SubItems.Add(item.pesoSaida.ToString());
						lista.SubItems.Add(saldo.ToString());
						lista.SubItems.Add(item.natureza);
						lista.SubItems.Add(item.visitado);
						lista.SubItems.Add(item.idUsuarioEntrada.ToString());
						lista.SubItems.Add(item.idUsuarioSaida.ToString());
						listFinalizada.Items.Add(lista);
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
		private void btnImprimir_Click(object sender, EventArgs e)
		{
			if (tabEntrada.Focus() == true)
			{
				var relEntrada = ctrlRelatorio.relEntrada(dataGrid, dtBusca);
				Form imprimirEntrada = new frmRelEntrada(relEntrada);
				imprimirEntrada.Show();
			}
			else if (tabSaidas.Focus() == true)
			{
				var relSaida = ctrlRelatorio.relSaida(dataGrid, dtBusca);
				Form imprimirSaida = new frmRelSaida(relSaida);
				imprimirSaida.Show();
			}
			else if (tabAcessoFinalizado.Focus() == true)
			{
				btnImprimir.Visible = false;			
			}
		}
	}
}
