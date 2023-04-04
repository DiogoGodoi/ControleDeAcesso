using DAO;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL
{
    public class ctrlAlteracao
    {
        public static bool BuscarEntrada(int referencia)
        {
            return daoEntrada.PesquisarEntrada(referencia);
        }
    }
}
