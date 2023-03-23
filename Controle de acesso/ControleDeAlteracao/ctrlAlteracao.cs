using EntradaDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAlteracao
{
    public class ctrlAlteracao
    {
        public static bool BuscarEntrada(int referencia)
        {
            return daoEntrada.PesquisarEntrada(referencia);
        }
    }
}
