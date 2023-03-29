using SaidaModel;
using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using UsuarioModel;
using ControlAcessIP;

//Data access object de saída
namespace SaidaDao
{
    public class daoSaida
    {
		//Método para inserir saída no banco de dados
        public static bool InserirSaida(mdlSaida Saida)
        {
            var builder = new MySqlConnectionStringBuilder
            {
				Server = ctrlAcessIP.getIP(),
				Port = ctrlAcessIP.getPort(),
				Database = "Portaria",
				UserID = mdlUsuario.staticNome,
				Password = mdlUsuario.staticSenha
			};
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                string query = "INSERT INTO Saida (ref, dataSaida, horaSaida, pesoSaida, idUsuario) VALUES " +
                    "(@ref, @dataSaida, @horaSaida, @pesoSaida, @idUsuario)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                var pmtReferencia = cmd.CreateParameter();
                pmtReferencia.ParameterName = "@ref";
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
		//public static bool AlterarSaida(mdlSaida saida)
		//{

		//}
		public static List<mdlSaida> ExibirSaida()
		{
			List<mdlSaida> saidas = new List<mdlSaida>();
			var builder = new MySqlConnectionStringBuilder
			{
				Server = ctrlAcessIP.getIP(),
				Port = ctrlAcessIP.getPort(),
				Database = "Portaria",
				UserID = mdlUsuario.staticNome,
				Password = mdlUsuario.staticSenha
			};
			MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
			try
			{
				conn.Open();
				string query = "SELECT Saida.ref, Entrada.nomeVisitante, Saida.dataSaida, Saida.horaSaida, Saida.pesoSaida, Saida.IdUsuario " +
					"FROM Saida INNER JOIN Entrada ON Entrada.ref=Saida.ref ORDER BY Saida.dataSaida, Saida.horaSaida ASC";
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
						var pmtSaidaRef = Convert.ToInt32(dados["ref"]);
						var pmtEntradaNomeVisitante = dados["nomeVisitante"].ToString().ToUpper();
						var pmtSaidaDataSaida = dados["dataSaida"].ToString();
						var pmtSaidaHoraSaida = dados["horaSaida"].ToString();
						var pmtSaidaPesoSaida = Convert.ToDouble(dados["pesoSaida"]);
						saidas.Add(new mdlSaida(pmtSaidaRef, pmtEntradaNomeVisitante, pmtSaidaDataSaida, pmtSaidaHoraSaida, pmtSaidaPesoSaida));
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
