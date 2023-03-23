using EntradaDao;
using EntradaModel;
using SaidaDao;
using SaidaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeConsulta
{
    public class ctrlConsulta
    {
        public static List<mdlEntrada> ExibirEntrada()
        {
			return daoEntrada.ExibirEntrada();
        }
		public static List<mdlSaida> ExibirSaida()
		{
			return daoSaida.ExibirSaida();
		}
		public static List<mdlEntrada> ExibirEntradaFinalizada()
		{
			return daoEntrada.ExibirEntradaFinalizada();
		}
		
	}
}
