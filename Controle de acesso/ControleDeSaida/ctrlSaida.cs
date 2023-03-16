using SaidaDao;
using SaidaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Controle de saída
namespace ControleDeSaida
{
    public class ctrlSaida
    {
        //Método para efetuar a saida de pessoal
        public static bool EfetuarSaida(mdlSaida dados)
        {
            return DaoSaida.InserirSaida(dados);
        }
    }
}
