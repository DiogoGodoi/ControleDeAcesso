using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using MySqlConnector;
using EntradaModel;
using System.Threading.Tasks;

//Data access object de entrada
namespace EntradaDao
{
	public class DaoEntrada
	{
		//Atributos
		private static int referencia { get; set; }
		private static string nomeVisitante { get; set; }
		private static string cpf { get; set; }
		private static string cnpj { get; set; }
		private static string pesoEntrada { get; set; }
		private static string visitado { get; set; }
		private static string placaVeiculo { get; set; }
		private static string dataEntrada { get; set; }
		private static string horaEntrada { get; set; }
		private static string dataSaida { get; set; }
		private static string horaSaida { get; set; }
		private static string pesoSaida { get; set; }

		//Método de entrada de dados no banco
		public static bool InserirEntrada(mdlEntrada Entrada)
		{
			var builder = new MySqlConnectionStringBuilder
			{
				Server = "192.168.0.253",
				Port = 4550,
				Database = "Portaria",
				UserID = "root",
				Password = "T21nfr@--"
			};
			MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
			try
			{
				conn.Open();
				string query = "INSERT INTO ENTRADA (nomeVisitante, visitado, dataEntrada, horaEntrada, cpf, cnpj, pesoEntrada, placaVeiculo, idUsuario) " +
				"VALUES (@nomeVisitante, @visitado, @dataEntrada, @horaEntrada, @cpf, @cnpj, @pesoEntrada, @placaVeiculo, @idUsuario)";
				MySqlCommand cmd = new MySqlCommand(query, conn);

				var pmtNomeVisitante = cmd.CreateParameter();
				pmtNomeVisitante.ParameterName = "@nomeVisitante";
				pmtNomeVisitante.DbType = DbType.String;
				pmtNomeVisitante.Value = Entrada.nomeVisitante;
				cmd.Parameters.Add(pmtNomeVisitante);

				var pmtNomeVisitado = cmd.CreateParameter();
				pmtNomeVisitado.ParameterName = "@visitado";
				pmtNomeVisitado.DbType = DbType.String;
				pmtNomeVisitado.Value = Entrada.visitado;
				cmd.Parameters.Add(pmtNomeVisitado);

				var pmtDataEntrada = cmd.CreateParameter();
				pmtDataEntrada.ParameterName = "@dataEntrada";
				pmtDataEntrada.DbType = DbType.String;
				pmtDataEntrada.Value = Entrada.dataEntrada;
				cmd.Parameters.Add(pmtDataEntrada);

				var pmtHoraEntrada = cmd.CreateParameter();
				pmtHoraEntrada.ParameterName = "@horaEntrada";
				pmtHoraEntrada.DbType = DbType.String;
				pmtHoraEntrada.Value = Entrada.horaEntrada;
				cmd.Parameters.Add(pmtHoraEntrada);

				var pmtCpf = cmd.CreateParameter();
				pmtCpf.ParameterName = "@cpf";
				pmtCpf.DbType = DbType.String;
				pmtCpf.Value = Entrada.cpf;
				cmd.Parameters.Add(pmtCpf);

				var pmtCnpj = cmd.CreateParameter();
				pmtCnpj.ParameterName = "@cnpj";
				pmtCnpj.DbType = DbType.String;
				pmtCnpj.Value = Entrada.cnpj;
				cmd.Parameters.Add(pmtCnpj);

				var pmtPesoEntrada = cmd.CreateParameter();
				pmtPesoEntrada.ParameterName = "@pesoEntrada";
				pmtPesoEntrada.DbType = DbType.String;
				pmtPesoEntrada.Value = Entrada.pesoEntrada;
				cmd.Parameters.Add(pmtPesoEntrada);

				var pmtPlacaVeiculo = cmd.CreateParameter();
				pmtPlacaVeiculo.ParameterName = "@placaVeiculo";
				pmtPlacaVeiculo.DbType = DbType.String;
				pmtPlacaVeiculo.Value = Entrada.placaVeiculo;
				cmd.Parameters.Add(pmtPlacaVeiculo);

				var pmtIdUsuario = cmd.CreateParameter();
				pmtIdUsuario.ParameterName = "@idUsuario";
				pmtIdUsuario.DbType = DbType.Int32;
				pmtIdUsuario.Value = Entrada.idUsuario;
				cmd.Parameters.Add(pmtIdUsuario);

				if (cmd.ExecuteNonQuery() > 0)
				{
					conn.Close();
					return true;
				}
				else
				{
					conn.Close();
					return false;
				}

			}
			catch (Exception ex)
			{
				conn.Close();
				return false;
				throw new Exception("Erro interno" + ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}

		//public static bool AlterarEntrada(mdlEntrada Entrada)
		//{
		//}

		//Método para pesquisar entrada
		public static bool PesquisarEntrada(int dados)
		{
			var builder = new MySqlConnectionStringBuilder
			{
				Server = "192.168.0.253",
				Port = 4550,
				Database = "Portaria",
				UserID = "root",
				Password = "T21nfr@--"
			};
			MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
			try
			{
				conn.Open();
				string query = $"SELECT * FROM Entrada WHERE Entrada.ref = {dados}";

				MySqlCommand cmd = new MySqlCommand(query, conn);
				var leitura = cmd.ExecuteReader();
				if (leitura.Read() == true)
				{
					nomeVisitante = leitura["nomeVisitante"].ToString();
					visitado = leitura["visitado"].ToString();
					cpf = leitura["cpf"].ToString();
					cnpj = leitura["cnpj"].ToString();
					placaVeiculo = leitura["placaVeiculo"].ToString();
					dataEntrada = leitura["dataEntrada"].ToString();
					horaEntrada = leitura["horaEntrada"].ToString();
					pesoEntrada = leitura["pesoEntrada"].ToString();

					return true;
				}
				else
				{
					return false;
				}

			}
			catch (Exception ex)
			{
				conn.Close();
				return false;
				throw new Exception("Erro interno" + ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}
		//Método para pesquisar entrada finalizada
		public static bool PesquisarEntradaFinalizada(int dados)
		{
			var builder = new MySqlConnectionStringBuilder
			{
				Server = "192.168.0.253",
				Port = 4550,
				Database = "Portaria",
				UserID = "root",
				Password = "T21nfr@--"
			};
			MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
			try
			{
				conn.Open();
				string query = $"SELECT Entrada.nomeVisitante, Entrada.visitado, Entrada.cnpj, Entrada.cpf, Entrada.placaVeiculo, Entrada.dataEntrada, Saida.dataSaida, Entrada.horaEntrada, Saida.horaSaida, Entrada.pesoEntrada, Saida.pesoSaida, Entrada.idUsuario, Saida.idUsuario FROM Entrada INNER JOIN SAIDA ON Entrada.ref=Saida.ref WHERE Entrada.ref = {dados}";
				
				MySqlCommand cmd = new MySqlCommand(query, conn);
				var leitura = cmd.ExecuteReader();	
				if(leitura.Read() == true)
				{
					nomeVisitante = leitura["nomeVisitante"].ToString();
					visitado = leitura["visitado"].ToString();
					cpf = leitura["cpf"].ToString();
					cnpj = leitura["cnpj"].ToString();
					placaVeiculo = leitura["placaVeiculo"].ToString();
					dataEntrada = leitura["dataEntrada"].ToString();
					horaEntrada = leitura["horaEntrada"].ToString();
					pesoEntrada = leitura["pesoEntrada"].ToString();
					dataSaida = leitura["dataSaida"].ToString();
					horaSaida = leitura["horaSaida"].ToString();
					pesoSaida = leitura["pesoSaida"].ToString();

					return true;
				}
				else{
					return false;
				}

			}catch(Exception ex)
			{
				conn.Close();
				return false;
				throw new Exception("Erro interno"+ ex.Message);
			}finally { 
				conn.Close(); 
			}
		}

		//public static List<mdlEntrada> ExibirEntrada()
		//{

		//}

		public static int GetReferencia()
		{
			return referencia;
		}
		public static string GetNomeVisitante()
		{
			return nomeVisitante;
		}
		public static string GetCpf()
		{
			return cpf;
		}
		public static string GetCnpj()
		{
			return cnpj;
		}
		public static string GetPesoEntrada()
		{
			return pesoEntrada;
		}
		public static string GetVisitado()
		{
			return visitado;
		}
		public static string GetPlacaVeiculo()
		{
			return placaVeiculo;
		}
		public static string GetDataEntrada()
		{
			return dataEntrada;
		}
		public static string GetHoraEntrada()
		{
			return horaEntrada;
		}
		public static string GetDataSaida()
		{
			return dataSaida;
		}
		public static string GetHoraSaida()
		{
			return horaSaida;
		}
		public static string GetPesoSaida()
		{
			return pesoSaida;
		}

	}
}
