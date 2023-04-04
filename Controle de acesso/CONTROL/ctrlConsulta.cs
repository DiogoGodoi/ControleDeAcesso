using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
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
