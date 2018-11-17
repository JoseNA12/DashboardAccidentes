using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public abstract class QueryDecorador : Query
    {
        protected Query query;
        public List<Indicador> indicadores { get; private set; }

        public QueryDecorador(Query query, List<Indicador> indicadores)
        {
            this.query = query;
            this.indicadores = indicadores;
        }

        public string obtenerValorIndicador(string indicador)
        {
            foreach(var ind in indicadores)
            {
                if (ind.indicador.Equals(indicador))
                    return ind.valor;
            }

            return null;
        }

        public override string construirConsulta()
        {
            return query.construirConsulta();
        }
    }
}
