using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using DAO;

namespace CONTROL
{
    //Controle de entrada
    public class ctrlEntrada
    {
        //Método para entrada de dados
        public static bool EfetuarEntrada(mdlEntrada dados)
        {
           return daoEntrada.InserirEntrada(dados);
        }
		//Método para pesquisa de dados
		public static bool Pesquisar (int referencia)
        {
         return daoEntrada.PesquisarEntrada(referencia);
        }
		//Método para pesquisa finalizada
		public static bool PesquisarEntradaFinalizada(int referencia)
		{
			return daoEntrada.PesquisarEntradaFinalizada(referencia);
		}



	}
}
