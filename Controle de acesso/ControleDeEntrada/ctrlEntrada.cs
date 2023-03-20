using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntradaModel;
using EntradaDao;

namespace ControleDeEntrada
{
    //Controle de entrada
    public class ctrlEntrada
    {
        //Método para entrada de dados
        public static bool EfetuarEntrada(mdlEntrada dados)
        {
           return DaoEntrada.InserirEntrada(dados);
        }
		//Método de exibição de dados

		/* public static List<mdlEntrada> ExibirEntrada()
		{

		}

		public static List<mdlEntrada> Exibir ()
		{

		}*/

		//Método para pesquisa finalizada
		public static bool PesquisarEntradaFinalizada(int referencia)
		{
			return DaoEntrada.PesquisarEntradaFinalizada(referencia);
		}
		//Método para pesquisa de dados
		public static bool Pesquisar (int referencia)
        {
         return DaoEntrada.PesquisarEntrada(referencia);
        }

       


    }
}
