using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class mdlAlteracao
    {
        public int referencia { get; set; }
        public mdlEntrada dadosEntrada;
        public mdlSaida dadosSaida;

        public mdlAlteracao(mdlEntrada _mdlEntrada, mdlSaida _mdlSaida)
        {
            dadosEntrada = _mdlEntrada;
            dadosSaida = _mdlSaida;
        }
    }
}
