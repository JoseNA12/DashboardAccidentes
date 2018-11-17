using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class Genero : QueryDecorador
    {
        public Genero(Query query, List<Indicador> indicadores) : base(query, indicadores)
        {

        }

        public string construirConsulta()
        {
            string valor_indicador = obtenerValorIndicador("Genero");

            if(valor_indicador != null)
            {
                string condicion = "g.sexo = '" + valor_indicador + "'";
                string query_intermedia = query.construirConsulta();

                return query_intermedia.Replace("{4}", condicion + " AND {4}");
            }

            return query.construirConsulta();
        }
    }
}
