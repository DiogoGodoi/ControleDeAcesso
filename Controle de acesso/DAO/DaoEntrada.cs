using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using MySqlConnector;
using MODEL;
using System.Threading.Tasks;

//Data access object de entrada
namespace DAO
{
	public class daoEntrada
	{
		//Atributos
		private static MySqlConnection conn = DaoConexao.GetConnection();	
		private static int referencia { get; set; }
		private static string nomeVisitante { get; set; }
		private static long cpf { get; set; }
		private static long cnpj { get; set; }
		private static double pesoEntrada { get; set; }
		private static string visitado { get; set; }
		private static string placaVeiculo { get; set; }
		private static string dataEntrada = DateTime.Now.Date.ToString("dd-MM-yyyy");
		private static string horaEntrada { get; set; }
		private static string transportadora { get; set; }
		private static string natureza { get; set; }
		private static string dataSaida { get; set; }
		private static string horaSaida { get; set; }
		private static double pesoSaida { get; set; }

		//Método de entrada de dados no banco
		public static bool InserirEntrada(mdlEntrada Entrada)
		{
			try
			{
				conn.Open();
				string query = "INSERT INTO ENTRADA (nomeVisitante, visitado, dataEntrada, horaEntrada, cpf, cnpj, pesoEntrada, placaVeiculo, idUsuario, transportadora, natureza) " +
				"VALUES (@nomeVisitante, @visitado, @dataEntrada, @horaEntrada, @cpf, @cnpj, @pesoEntrada, @placaVeiculo, @idUsuario, @transportadora, @natureza)";
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
				pmtCpf.DbType = DbType.Int32;
				pmtCpf.Value = Entrada.cpf;
				cmd.Parameters.Add(pmtCpf);

				var pmtCnpj = cmd.CreateParameter();
				pmtCnpj.ParameterName = "@cnpj";
				pmtCnpj.DbType = DbType.Int64;
				pmtCnpj.Value = Entrada.cnpj;
				cmd.Parameters.Add(pmtCnpj);

				var pmtPesoEntrada = cmd.CreateParameter();
				pmtPesoEntrada.ParameterName = "@pesoEntrada";
				pmtPesoEntrada.DbType = DbType.Double;
				pmtPesoEntrada.Value = Entrada.pesoEntrada;
				cmd.Parameters.Add(pmtPesoEntrada);

				var pmtPlacaVeiculo = cmd.CreateParameter();
				pmtPlacaVeiculo.ParameterName = "@placaVeiculo";
				pmtPlacaVeiculo.DbType = DbType.String;
				pmtPlacaVeiculo.Value = Entrada.placaVeiculo.ToUpper();
				cmd.Parameters.Add(pmtPlacaVeiculo);

				var pmtIdUsuario = cmd.CreateParameter();
				pmtIdUsuario.ParameterName = "@idUsuario";
				pmtIdUsuario.DbType = DbType.Int32;
				pmtIdUsuario.Value = Entrada.idUsuario;
				cmd.Parameters.Add(pmtIdUsuario);

				var pmtTransportadora = cmd.CreateParameter();
				pmtTransportadora.ParameterName = "@transportadora";
				pmtTransportadora.DbType = DbType.String;
				pmtTransportadora.Value = Entrada.transportadora;
				cmd.Parameters.Add(pmtTransportadora);

				var pmtNatureza = cmd.CreateParameter();
				pmtNatureza.ParameterName = "@natureza";
				pmtNatureza.DbType = DbType.String;
				pmtNatureza.Value = Entrada.natureza.ToUpper();
				cmd.Parameters.Add(pmtNatureza);

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
		public static bool AlterarEntrada(mdlEntrada Entrada, int pmtReferencia)
		{
			try
			{
				conn.Open();
				string query = $"UPDATE ENTRADA SET nomeVisitante = @nomeVisitante, visitado = @visitado, dataEntrada = @dataEntrada, horaEntrada = @horaEntrada, cpf = @cpf, cnpj = @cnpj, pesoEntrada = @pesoEntrada, placaVeiculo = @placaVeiculo, transportadora = @transportadora, natureza = @natureza WHERE referencia = {pmtReferencia}";
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
				pmtCpf.DbType = DbType.Int32;
				pmtCpf.Value = Entrada.cpf;
				cmd.Parameters.Add(pmtCpf);

				var pmtCnpj = cmd.CreateParameter();
				pmtCnpj.ParameterName = "@cnpj";
				pmtCnpj.DbType = DbType.Int64;
				pmtCnpj.Value = Entrada.cnpj;
				cmd.Parameters.Add(pmtCnpj);

				var pmtPesoEntrada = cmd.CreateParameter();
				pmtPesoEntrada.ParameterName = "@pesoEntrada";
				pmtPesoEntrada.DbType = DbType.Double;
				pmtPesoEntrada.Value = Entrada.pesoEntrada;
				cmd.Parameters.Add(pmtPesoEntrada);

				var pmtPlacaVeiculo = cmd.CreateParameter();
				pmtPlacaVeiculo.ParameterName = "@placaVeiculo";
				pmtPlacaVeiculo.DbType = DbType.String;
				pmtPlacaVeiculo.Value = Entrada.placaVeiculo.ToUpper();
				cmd.Parameters.Add(pmtPlacaVeiculo);

				var pmtTransportadora = cmd.CreateParameter();
				pmtTransportadora.ParameterName = "@transportadora";
				pmtTransportadora.DbType = DbType.String;
				pmtTransportadora.Value = Entrada.transportadora;
				cmd.Parameters.Add(pmtTransportadora);

				var pmtNatureza = cmd.CreateParameter();
				pmtNatureza.ParameterName = "@natureza";
				pmtNatureza.DbType = DbType.String;
				pmtNatureza.Value = Entrada.natureza.ToUpper();
				cmd.Parameters.Add(pmtNatureza);
				
				if (cmd.ExecuteNonQuery() >= 0)
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
		//Método para pesquisar entrada
		public static bool PesquisarEntrada(int pmtReferencia)
		{
			try
			{
				conn.Open();
				string query = $"SELECT * FROM Entrada WHERE Entrada.referencia = {pmtReferencia}";

				MySqlCommand cmd = new MySqlCommand(query, conn);
				var leitura = cmd.ExecuteReader();
				if (leitura.Read() == true)
				{
					nomeVisitante = leitura["nomeVisitante"].ToString().ToUpper(); ;
					cpf = Convert.ToInt64(leitura["cpf"]);
					transportadora = leitura["transportadora"].ToString().ToUpper();
					cnpj = Convert.ToInt64(leitura["cnpj"]);
					visitado = leitura["visitado"].ToString().ToUpper();
					placaVeiculo = leitura["placaVeiculo"].ToString();
					dataEntrada = leitura["dataEntrada"].ToString();
					horaEntrada = leitura["horaEntrada"].ToString();
					pesoEntrada = Convert.ToDouble(leitura["pesoEntrada"]);
					natureza = leitura["natureza"].ToString();

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
		//Método para exibir entradas
		public static List<mdlEntrada> ExibirEntrada()
		{
			List<mdlEntrada> entradas = new List<mdlEntrada>();
			try
			{
				conn.Open();
				string query = $"SELECT * FROM Entrada ORDER BY dataEntrada, horaEntrada ASC";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.CommandType = CommandType.Text;
				MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
				DataTable tabela = new DataTable();
				adaptador.Fill(tabela);
				var leitura = cmd.ExecuteReader();
				if (leitura.Read() == true)
				{
					foreach (DataRow dados in tabela.Rows)
					{
						var pmtCodigo = Convert.ToInt32(dados["referencia"]);
						var pmtNomeVisitante = dados["nomeVisitante"].ToString().ToUpper();
						var pmtCpf = Convert.ToInt64(dados["cpf"]);
						var pmtVisitado = dados["visitado"].ToString().ToUpper();
						var pmtTransportadora = dados["transportadora"].ToString().ToUpper();
						var pmtCnpj = Convert.ToInt64(dados["cnpj"]);
						var pmtPlacaVeiculo = dados["placaVeiculo"].ToString();
						var pmtDataEntrada = dados["dataEntrada"].ToString();
						var pmtHoraEntrada = dados["horaEntrada"].ToString();
						var pmtPesoEntrada = Convert.ToDouble(dados["pesoEntrada"]);
						var pmtNatureza = dados["natureza"].ToString().ToUpper();
						var pmtIdUsuario = Convert.ToInt32(dados["idUsuario"]);
						entradas.Add(new mdlEntrada(pmtCodigo, pmtNomeVisitante, pmtVisitado, pmtDataEntrada, pmtHoraEntrada, pmtCpf, pmtCnpj, pmtPesoEntrada, pmtPlacaVeiculo, pmtTransportadora, pmtNatureza, pmtIdUsuario));
					}

					return entradas;
				}
				else
				{
					return null;
				}

			}
			catch (Exception ex)
			{
				conn.Close();
				return null;
				throw new Exception("Erro interno" + ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}
		//Método para pesquisar entrada finalizada
		public static bool PesquisarEntradaFinalizada(int pmtReferencia)
		{
			try
			{
				conn.Open();
				string query = $"SELECT Entrada.nomeVisitante, Entrada.cpf, Entrada.transportadora, Entrada.cnpj, Entrada.visitado, Entrada.natureza, Entrada.placaVeiculo, Entrada.dataEntrada, Saida.dataSaida, Entrada.horaEntrada, Saida.horaSaida, Entrada.pesoEntrada, Saida.pesoSaida, Entrada.idUsuario, Saida.idUsuario FROM Entrada INNER JOIN SAIDA ON Entrada.referencia=Saida.referencia WHERE Entrada.referencia = {pmtReferencia}";
				
				MySqlCommand cmd = new MySqlCommand(query, conn);
				var leitura = cmd.ExecuteReader();	
				if(leitura.Read() == true)
				{
					nomeVisitante = leitura["nomeVisitante"].ToString().ToUpper();
					cpf = Convert.ToInt64(leitura["cpf"]);
					transportadora = leitura["transportadora"].ToString().ToUpper();
					cnpj = Convert.ToInt64(leitura["cnpj"]);
					dataEntrada = leitura["dataEntrada"].ToString();
					horaEntrada = leitura["horaEntrada"].ToString();
					pesoEntrada = Convert.ToDouble(leitura["pesoEntrada"]);
					placaVeiculo = leitura["placaVeiculo"].ToString();
					natureza = leitura["natureza"].ToString().ToUpper();
					visitado = leitura["visitado"].ToString().ToUpper();
					dataSaida = leitura["dataSaida"].ToString();
					horaSaida = leitura["horaSaida"].ToString();
					pesoSaida = Convert.ToDouble(leitura["pesoSaida"]);
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
		//Método para exibir entrada finalizada
		public static List<mdlEntrada> ExibirEntradaFinalizada()
		{
			List<mdlEntrada> entradaFinalizada = new List<mdlEntrada>();
			try
			{
				conn.Open();
				string query = "SELECT Entrada.referencia, Entrada.nomeVisitante, Entrada.transportadora," +
					"Entrada.visitado, Entrada.natureza," +
					"Entrada.cpf, Entrada.cnpj, " +
					"Entrada.dataEntrada, Saida.dataSaida, " +
					"Entrada.horaEntrada, Saida.horaSaida, " +
					"Entrada.pesoEntrada, Saida.pesoSaida, " +
					"Entrada.placaVeiculo, Entrada.idUsuario, " +
					$"Saida.idUsuario FROM Entrada INNER JOIN SAIDA ON Entrada.referencia=Saida.referencia";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				cmd.CommandType = CommandType.Text;
				MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
				DataTable tabela = new DataTable();
				adaptador.Fill(tabela);
				var leitura = cmd.ExecuteReader();

				if (leitura.Read() == true)
				{
					foreach (DataRow dados in tabela.Rows) {
						var pmtCodigo = Convert.ToInt32(dados["referencia"]);
						var pmtNomeVisitante = dados["nomeVisitante"].ToString().ToUpper();
						var pmtCpf = Convert.ToInt64(dados["cpf"]);
						var pmtTransportadora = dados["transportadora"].ToString().ToUpper();
						var pmtCnpj = Convert.ToInt64(dados["cnpj"]);
						var pmtVisitado = dados["visitado"].ToString().ToUpper();
						var pmtPlacaVeiculo = dados["placaVeiculo"].ToString();
						var pmtDataEntrada = dados["dataEntrada"].ToString();
						var pmtDataSaida = dados["dataSaida"].ToString();
						var pmtHoraEntrada = dados["horaEntrada"].ToString();
						var pmtHoraSaida = dados["horaSaida"].ToString();
						var pmtPesoEntrada = Convert.ToDouble(dados["pesoEntrada"]);
						var pmtPesoSaida = Convert.ToDouble(dados["pesoSaida"]);
						var pmtIdUsuarioEntrada = Convert.ToInt32(dados["idUsuario"]);
						var pmtIdUsuarioSaida = Convert.ToInt32(dados["idUsuario"]);
						var pmtNatureza = dados["natureza"].ToString().ToUpper();
						
						entradaFinalizada.Add(new mdlEntrada(
							pmtCodigo,
							pmtNomeVisitante, pmtVisitado, 
							pmtCpf, pmtCnpj, 
							pmtPlacaVeiculo, pmtDataEntrada, 
							pmtDataSaida, pmtHoraEntrada, 
							pmtHoraSaida, pmtPesoEntrada, 
							pmtPesoSaida, pmtIdUsuarioEntrada, 
							pmtIdUsuarioSaida, pmtTransportadora, pmtNatureza));
					}
					return entradaFinalizada;
				}
				else
				{
					return null;
				}

			}
			catch (Exception ex)
			{
				conn.Close();
				return null;
				throw new Exception("Erro interno" + ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}
		//Getters de atributo
		public static int GetReferencia()
		{
			return referencia;
		}
		public static string GetNomeVisitante()
		{
			return nomeVisitante;
		}
		public static long GetCpf()
		{
			return cpf;
		}
		public static long GetCnpj()
		{
			return cnpj;
		}
		public static double GetPesoEntrada()
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
		public static string GetTransportadora()
		{
			return transportadora;
		}
		public static string GetNatureza()
		{
			return natureza;
		}
		public static string GetDataSaida()
		{
			return dataSaida;
		}
		public static string GetHoraSaida()
		{
			return horaSaida;
		}
		public static double GetPesoSaida()
		{
			return pesoSaida;
		}
	}
}
