using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioDao;
using UsuarioModel;

namespace EntradaModel
{
	//Model de entrada
	public class mdlEntrada
	{
		//Atributos
		public string dataEntrada = DateTime.Now.ToString("dd-MM-yyyy");
		public string horaEntrada = DateTime.Now.ToString("HH:mm");
		public int idUsuario = DaoUsuario.idUsuario;
		public string nomeVisitante { get; set; }
		public long cpf { get; set; }
		public long cnpj { get; set; }
		public double pesoEntrada { get; set; }
		public string visitado { get; set; }
		public string placaVeiculo { get; set; }

		public mdlEntrada(
			string nomeVisitante,
			long cpf,
			long cnpj,
			double pesoEntrada,
			string visitado,
			string placaVeiculo)
		{
			this.nomeVisitante = nomeVisitante;
			this.cpf = cpf;
			this.cnpj = cnpj;
			this.pesoEntrada = pesoEntrada;
			this.visitado = visitado;
			this.placaVeiculo = placaVeiculo;
		}
	}
}
