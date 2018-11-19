using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class DAO_Query : DAO_SQL
    {
        public DataTable correrQueryDinamico(QueryDinamica queryDinamica)
        {
            TipoLesion tipoLesionDecorador = new TipoLesion(queryDinamica, queryDinamica.indicadores);
            Genero generoDecorador = new Genero(tipoLesionDecorador, tipoLesionDecorador.indicadores);
            EdadQuincenal edadQuincenal = new EdadQuincenal(generoDecorador, generoDecorador.indicadores);
            TipoAfectado tipoAfectado = new TipoAfectado(edadQuincenal, edadQuincenal.indicadores);

            string query = tipoAfectado.construirConsulta();
            query = query.Replace(" AND {4}", "");

            return RealizarConsulta(query);
        }

        public DataTable correrQueryIndicador(string indicador)
        {
            string query = Properties.Resources.ResourceManager.GetString("QUERY_" + indicador);
            return RealizarConsulta(query);
        }

        public DataTable correrQueryLibre(string provincia, int annio)
        {
            string query = Properties.Resources.ResourceManager.GetString("QUERY_LIBRE");
            query = string.Format(query, provincia, annio);

            return RealizarConsulta(query);
        }
    }
}
