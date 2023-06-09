﻿using MODEL;
using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Data access object de saída
namespace DAO
{
    public class daoSaida
    {
		private static MySqlConnection conn = DaoConexao.GetConnection();
		//Método para inserir saída no banco de dados
        public static bool InserirSaida(mdlSaida Saida)
        {
            
            try
            {
                conn.Open();
                string query = "INSERT INTO Saida (referencia, dataSaida, horaSaida, pesoSaida, idUsuario) VALUES " +
                    "(@referencia, @dataSaida, @horaSaida, @pesoSaida, @idUsuario)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                var pmtReferencia = cmd.CreateParameter();
                pmtReferencia.ParameterName = "@referencia";
                pmtReferencia.DbType = DbType.Int32;
                pmtReferencia.Value = Saida.referencia;
                cmd.Parameters.Add(pmtReferencia);

				var pmtDataSaida = cmd.CreateParameter();
				pmtDataSaida.ParameterName = "@dataSaida";
				pmtDataSaida.DbType = DbType.String;
				pmtDataSaida.Value = Saida.dataSaida;
				cmd.Parameters.Add(pmtDataSaida);

				var pmtHoraSaida = cmd.CreateParameter();
				pmtHoraSaida.ParameterName = "@horaSaida";
				pmtHoraSaida.DbType = DbType.String;
				pmtHoraSaida.Value = Saida.horaSaida;
				cmd.Parameters.Add(pmtHoraSaida);

				var pmtPesoSaida = cmd.CreateParameter();
				pmtPesoSaida.ParameterName = "@pesoSaida";
				pmtPesoSaida.DbType = DbType.String;
				pmtPesoSaida.Value = Saida.pesoSaida;
				cmd.Parameters.Add(pmtPesoSaida);

				var pmtIdUsuario = cmd.CreateParameter();
				pmtIdUsuario.ParameterName = "@idUsuario";
				pmtIdUsuario.DbType = DbType.Int32;
				pmtIdUsuario.Value = Saida.idUsuario;
				cmd.Parameters.Add(pmtIdUsuario);

				if(cmd.ExecuteNonQuery() >0)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
            catch (Exception ex)
            {

                throw new Exception("Erro interno"+ex.Message);
            }
            finally
            {
                conn.Close();
            }

		}
		public static bool AlterarSaida(mdlSaida saida, int pmtReferencia)
		{
			try
			{
				conn.Open();
				string query = $"UPDATE Saida SET dataSaida = @dataSaida, horaSaida = @horaSaida, pesoSaida = @pesoSaida WHERE referencia = {pmtReferencia}";
				MySqlCommand cmd = new MySqlCommand(query, conn);

				var pmtDataSaida = cmd.CreateParameter();
				pmtDataSaida.ParameterName = "@dataSaida";
				pmtDataSaida.DbType = DbType.String;
				pmtDataSaida.Value = saida.dataSaida;
				cmd.Parameters.Add(pmtDataSaida);

				var pmtHoraSaida = cmd.CreateParameter();
				pmtHoraSaida.ParameterName = "@horaSaida";
				pmtHoraSaida.DbType = DbType.String;
				pmtHoraSaida.Value = saida.horaSaida;
				cmd.Parameters.Add(pmtHoraSaida);

				var pmtPesoSaida = cmd.CreateParameter();
				pmtPesoSaida.ParameterName = "@pesoSaida";
				pmtPesoSaida.DbType = DbType.String;
				pmtPesoSaida.Value = saida.pesoSaida;
				cmd.Parameters.Add(pmtPesoSaida);

				if (cmd.ExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{
					return false;
				}

			}
			catch (Exception ex)
			{

				throw new Exception("Erro interno" + ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}
		public static List<mdlSaida> ExibirSaida()
		{
			List<mdlSaida> saidas = new List<mdlSaida>();
			try
			{
				conn.Open();
				string query = "SELECT Saida.referencia, Entrada.nomeVisitante, Entrada.transportadora, Entrada.Natureza, Saida.dataSaida, Saida.horaSaida, Saida.pesoSaida, Saida.idUsuario FROM Saida INNER JOIN Entrada ON Entrada.referencia=Saida.referencia ORDER BY Saida.dataSaida, Saida.horaSaida ASC";
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
						var pmtSaidaRef = Convert.ToInt32(dados["referencia"]);
						var pmtEntradaNomeVisitante = dados["nomeVisitante"].ToString().ToUpper();
						var pmtSaidaDataSaida = dados["dataSaida"].ToString();
						var pmtSaidaHoraSaida = dados["horaSaida"].ToString();
						var pmtSaidaPesoSaida = Convert.ToDouble(dados["pesoSaida"]);
						var pmtTransportadora = dados["transportadora"].ToString();
						var pmtNatureza = dados["natureza"].ToString();
						var pmtIdUsuario = Convert.ToInt32(dados["idUsuario"]);
                        saidas.Add(new mdlSaida(pmtSaidaRef, pmtEntradaNomeVisitante, pmtSaidaDataSaida, pmtSaidaHoraSaida, pmtSaidaPesoSaida, pmtNatureza, pmtTransportadora, pmtIdUsuario));
					}

					return saidas;
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
	}
}
