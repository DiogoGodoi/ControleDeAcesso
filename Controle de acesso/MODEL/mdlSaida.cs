using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    //Model de saída
    public class mdlSaida
    {
        //Atributos
        public int referencia { get; set; }
        public int idUsuario { get; set; }
        public string dataSaida { get; set; }
        public string horaSaida { get; set; }
        public double pesoSaida { get; set; }
        public mdlEntrada dados = new mdlEntrada();
        public string visitante { get; set; }
        public string transportadora { get; set; }
        public string natureza { get; set; } 

        //Construtor
        public mdlSaida (int referenci, string info, string dtSaida, string hrSaida, double pSaida, string natureza, string transportadora, int idUsuario)
        {
            referencia = referenci;
            dados.nomeVisitante = info;
            visitante = info;
            dataSaida = dtSaida;
            horaSaida = hrSaida;
            pesoSaida = pSaida;
			dados.natureza = natureza;
            this.natureza = natureza;
			dados.transportadora = transportadora;
            this.transportadora = transportadora;
            this.idUsuario = idUsuario;

		}

		//Construtor
		public mdlSaida(int referenciia, string dtSaida, string hrSaida, double pSaida) {
            referencia = referenciia;
            dataSaida = dtSaida;
            horaSaida = hrSaida;
            pesoSaida = pSaida;          
        }
		public mdlSaida(string dtSaida, string hrSaida, double pSaida)
		{
			dataSaida = dtSaida;
			horaSaida = hrSaida;
			pesoSaida = pSaida;
		}

	}
}
