using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioModel;
using MySqlConnector;

//Data access object de usuário
namespace UsuarioDao
{
	public class DaoUsuario
	{
		//Atributos
		public static int idUsuario { get; set; }
		private string nome { get; set; }
		private string senha { get; set; }
		public int getIdUsuario() { return idUsuario; }
		public string getNome() { return nome; }
		public string getSenha() { return senha; }

		//Método de autenticação de usuário junto ao banco de dados
		public static bool Autenticar(mdlUsuario dados)
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
				string query = $"SELECT * FROM Usuario WHERE nome='{dados.nome}'";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				var leitura = cmd.ExecuteReader();
				
				if(leitura.Read() == true)
				{
				  if (leitura["nome"].ToString() == dados.nome && leitura["senha"].ToString() == dados.senha)
				  {
				  idUsuario = Convert.ToInt16(leitura["idUsuario"]);
			      return true;
				  }else
			   	  {
				  return false;
				  }
				}
				else
				{
					return false;
				}
			}catch(Exception ex)
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
	}
}
