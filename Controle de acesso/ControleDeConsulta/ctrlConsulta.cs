using EntradaDao;
using EntradaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeConsulta
{
    public class ctrlConsulta
    {
        public static List<mdlEntrada> ExibirEntradas()
        {
			return DaoEntrada.ExibirEntrada();
        }

		/*
		public static List<DaoEntrada> ExibirSaidas()
		{

		}
		public static List<DaoEntrada> ExibirEntradaFinalizada()
		{

		}
		*/
	}
}
