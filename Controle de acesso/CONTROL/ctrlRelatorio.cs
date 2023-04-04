using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROL
{
	public class ctrlRelatorio
	{
		public static DataTable relEntrada (DataTable dt, DateTimePicker dtBusca)
		{
			dt = new DataTable();
			dt.Columns.Add("dataSaida", typeof(string));
			dt.Columns.Add("nomeVisitante", typeof(string));
			dt.Columns.Add("transportadora", typeof(string));
			dt.Columns.Add("Visitado", typeof(string));
			dt.Columns.Add("Natureza", typeof(string));

			List<mdlEntrada> entrada = ctrlConsulta.ExibirEntrada();
			var filtro = entrada.Where(i => i.dataEntrada == dtBusca.Value.ToString("dd-MM-yyyy"));
			foreach (var item in filtro)
			{
				dt.Rows.Add(item.dataEntrada, item.nomeVisitante, item.transportadora, item.visitado, item.natureza);
			}

			return dt;
		}
		public static DataTable relSaida (DataTable dt, DateTimePicker dtBusca)
		{
			dt = new DataTable();
			dt.Columns.Add("dataSaida", typeof(string));
			dt.Columns.Add("visitante", typeof(string));
			dt.Columns.Add("transportadora", typeof(string));
			dt.Columns.Add("Natureza", typeof(string));
			dt.Columns.Add("pesoSaida", typeof(double));
			dt.Columns.Add("horaSaida", typeof(string));

			List<mdlSaida> saida = ctrlConsulta.ExibirSaida();
			var filtro = saida.Where(i => i.dataSaida == dtBusca.Value.ToString("dd-MM-yyyy"));
			foreach (var item in filtro)
			{
				dt.Rows.Add(item.dataSaida, item.dados.nomeVisitante, item.dados.transportadora, item.dados.natureza, item.pesoSaida, item.horaSaida);
			}

			return dt;
		}
	}
}
