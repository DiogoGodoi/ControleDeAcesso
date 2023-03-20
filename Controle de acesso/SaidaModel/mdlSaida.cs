using EntradaDao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioDao;

namespace SaidaModel
{
    //Model de saída
    public class mdlSaida
    {
        //Atributos
        public int referencia { get; set; }
        public int idUsuario = DaoUsuario.idUsuario;
        public string dataSaida { get; set; }
        public string horaSaida { get; set; }
        public double pesoSaida { get; set; }


        public mdlSaida(int referenciia, string dtSaida, string hrSaida, double pSaida) {
            referencia = referenciia;
            dataSaida = dtSaida;
            horaSaida = hrSaida;
            pesoSaida = pSaida;
        }

    }
}
