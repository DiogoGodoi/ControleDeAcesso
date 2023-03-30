using MenuInicial;
using Saida;
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
	//Menu inicial
	public partial class frmMenuInicial : Form
	{
		//Inicializador do formulário
		ctrlNavegacao navegar = new ctrlNavegacao();
		Form formAtivo;
		public frmMenuInicial()
		{
			InitializeComponent();
		}
		//Configuração do botão da tela de saída
		private void TelaDeSaida(object sender, EventArgs e)
		{
			ctrlNavegacao.ActiveButton(btnSaida, panelSlideBar);
			ctrlNavegacao.Navegacao(formAtivo, new frmSaida(), panelConteudo);
		}
		//Configuração do botão da tela de alteração
		private void TelaDeAlteracao(object sender, EventArgs e)
		{
			ctrlNavegacao.ActiveButton(btnAlterar, panelSlideBar);
			ctrlNavegacao.Navegacao(formAtivo, new frmAlterar(), panelConteudo);
		}
		//Configuração do botão da tela de consulta
		private void TelaDeConsulta(object sender, EventArgs e)
		{
			ctrlNavegacao.ActiveButton(btnConsultar, panelSlideBar);
			ctrlNavegacao.Navegacao(formAtivo, new frmConsulta(), panelConteudo);
		}

		private void Sair(object sender, EventArgs e)
		{
			DialogResult mensagem = MessageBox.Show("Deseja realmente sair ?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(mensagem == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnEntrada_Click(object sender, EventArgs e)
		{
			ctrlNavegacao.ActiveButton(btnEntrada, panelSlideBar);
			ctrlNavegacao.Navegacao(formAtivo, new frmEntrada(), panelConteudo);
		}

		private void frmMenuInicial_Load(object sender, EventArgs e)
		{
			btnAlterar.Enabled = false;
			this.WindowState = FormWindowState.Maximized;
		}

		private void pctLogo_Click(object sender, EventArgs e)
		{
			panelConteudo.Controls.RemoveAt(0);
		}
	}
}
