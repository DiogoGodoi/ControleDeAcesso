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
		public int referencia;
		public string nomeVisitante { get; set; }
		public string visitado { get; set; }
		public long cpf { get; set; }
		public long cnpj { get; set; }
		public string placaVeiculo { get; set; }
		public string dataEntrada = DateTime.Now.ToString("dd-MM-yyyy");
		public string dataSaida { get; set; }
		public string horaEntrada = DateTime.Now.ToString("HH:mm");
		public string horaSaida { get; set; }
		public double pesoEntrada { get; set; }
		public double pesoSaida { get; set; }
		public int idUsuarioEntrada { get; set; }
		public int idUsuarioSaida { get;set; }
		public int idUsuario = daoUsuario.idUsuario;

		//Construtores
		public mdlEntrada() { }
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
		public mdlEntrada(
			int referenci,
			string nomeVisitante,
			string visitado,
			string dataEntrada,
			string horaEntrada,
			long cpf,
			long cnpj,
			double pesoEntrada,
			string placaVeiculo)
		{
			this.referencia = referenci;
			this.nomeVisitante = nomeVisitante;
			this.visitado = visitado;
			this.dataEntrada = dataEntrada;
			this.horaEntrada = horaEntrada;
			this.cpf = cpf;
			this.cnpj = cnpj;
			this.pesoEntrada = pesoEntrada;
			this.placaVeiculo = placaVeiculo;
		}
		public mdlEntrada(
			string nVisitante, 
			string visitado, 
			long cpf, 
			long cnpj, 
			string placaVeiculo,
			string dataEntrada,
			string dataSaida, 
			string horaEntrada,
			string horaSaida,
			double pesoEntrada,
			double pesoSaida,
			int idUsuarioEntrada,
			int idUsuarioSaida
			)
		{
			this.referencia.ToString();
			this.nomeVisitante = nVisitante;
			this.visitado = visitado;
			this.cpf = cpf;
			this.cnpj = cnpj;
			this.placaVeiculo = placaVeiculo;
			this.dataEntrada = dataEntrada;
			this.dataSaida = dataSaida;
			this.horaEntrada = horaEntrada;
			this.horaSaida = horaSaida;
			this.pesoEntrada = pesoEntrada;
			this.pesoSaida = pesoSaida;
			this.idUsuarioEntrada = idUsuarioEntrada;
			this.idUsuarioSaida = idUsuarioSaida;
		}
	}

	}

