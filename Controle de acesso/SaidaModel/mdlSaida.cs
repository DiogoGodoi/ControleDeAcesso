using EntradaDao;
using EntradaModel;
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

        public mdlEntrada dados = new mdlEntrada();

        public int idUsuario = daoUsuario.idUsuario;
        public string dataSaida { get; set; }
        public string horaSaida { get; set; }
        public double pesoSaida { get; set; }

        public mdlSaida (int referenci, string info, string dtSaida, string hrSaida, double pSaida)
        {
            referencia = referenci;
            dados.nomeVisitante = info;
            dataSaida = dtSaida;
            horaSaida = hrSaida;
            pesoSaida = pSaida;
            idUsuario.ToString();
        }
        public mdlSaida(int referenciia, string dtSaida, string hrSaida, double pSaida) {
            referencia = referenciia;
            dataSaida = dtSaida;
            horaSaida = hrSaida;
            pesoSaida = pSaida;
        }

    }
}
