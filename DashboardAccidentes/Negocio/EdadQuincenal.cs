using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class EdadQuincenal : QueryDecorador
    {
        public EdadQuincenal(Query query, List<Indicador> indicadores) : base(query, indicadores)
        {

        }

        public override string construirConsulta()
        {
            string valor_indicador = obtenerValorIndicador("Edad quincenal");

            if (valor_indicador != null)
            {
                string condicion = "af.edad_quinquenal = '" + valor_indicador + "'";
                return base.construirConsulta().Replace("{4}", condicion + " AND {4}");
            }

            return base.construirConsulta();
        }
    }
}
