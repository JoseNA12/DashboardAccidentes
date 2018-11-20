using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class TipoLesion : QueryDecorador
    {
        public TipoLesion(Query query, List<Indicador> indicadores) : base(query, indicadores)
        {

        }

        public override string construirConsulta()
        {
            string valor_indicador = obtenerValorIndicador("Tipo lesion");

            if (valor_indicador != null)
            {
                string condicion = "le.tipo_lesion = '" + valor_indicador + "'";
                string query_intermedia = query.construirConsulta();

                return query_intermedia.Replace("{4}", condicion + " AND {4}");
            }

            return query.construirConsulta();
        }
    }
}
