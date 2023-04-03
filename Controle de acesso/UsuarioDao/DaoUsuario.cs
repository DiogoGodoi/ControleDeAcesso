using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioModel;
using MySqlConnector;
using ControlAcessIP;

//Data access object de usuário
namespace UsuarioDao
{
	public class daoUsuario
	{
		//Atributos
		public static int idUsuario { get; set; }
		public static string sNome {get;set;}
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
				string query = $"SELECT * FROM Usuario WHERE nome='{dados.nome}'";
				MySqlCommand cmd = new MySqlCommand(query, conn);
				var leitura = cmd.ExecuteReader();
				
				if(leitura.Read() == true)
				{
				  if (leitura["nome"].ToString() == dados.nome && leitura["senha"].ToString() == dados.senha)
				  {
				  idUsuario = Convert.ToInt16(leitura["idUsuario"]);
				  sNome = leitura["nome"].ToString();
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
