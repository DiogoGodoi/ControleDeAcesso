using MODEL;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class DaoConexao
	{
		private static string IP { get; set; }
		private static uint port { get; set; }

		public DaoConexao(string pmtIp, uint pmtPort)
		{
			IP = pmtIp;
			port = pmtPort;
		}

		public static MySqlConnection GetConnection()
		{
			var builder = new MySqlConnectionStringBuilder
			{
				Server = IP,
				Port = port,
				Database = "Portaria",
				UserID = mdlUsuario.staticNome,
				Password = mdlUsuario.staticSenha
			};

			MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
			return conn;
		}

		public static string getIP()
		{
			return IP;
		}

		public static uint getPort()
		{
			return port;
		}
	}
}
