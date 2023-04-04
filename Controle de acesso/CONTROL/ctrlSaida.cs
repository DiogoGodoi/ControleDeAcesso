using MODEL;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Controle de saída
namespace CONTROL
{
    public class ctrlSaida
    {
        //Método para efetuar a saida de pessoal
        public static bool EfetuarSaida(mdlSaida dados)
        {
            return daoSaida.InserirSaida(dados);
        }
        //Método para alterar a saida de pessoal
        public static bool Alterar(mdlSaida dados, int referencia)
        {
            return daoSaida.AlterarSaida(dados, referencia);
        }
    }
}
