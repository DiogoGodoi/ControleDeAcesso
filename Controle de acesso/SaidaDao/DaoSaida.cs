using SaidaModel;
using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Data access object de saída
namespace SaidaDao
{
    public class DaoSaida
    {
		//Método para inserir saída no banco de dados
        public static bool InserirSaida(mdlSaida Saida)
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

    }
}
