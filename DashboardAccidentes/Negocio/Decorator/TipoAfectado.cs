using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class TipoAfectado : QueryDecorador
    {
        public TipoAfectado(Query query, List<Indicador> indicadores) : base(query, indicadores)
        {

        }

        public override string construirConsulta()
        {
            string valor_indicador = obtenerValorIndicador("Rol afectado");

            if (valor_indicador != null)
            {
                string condicion = "rol.rol = '" + valor_indicador + "'";
                return base.construirConsulta().Replace("{4}", condicion + " AND {4}");
            }

            return base.construirConsulta();
        }
    }
}
