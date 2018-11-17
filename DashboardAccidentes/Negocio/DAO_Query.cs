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
        //Lista de tareas pendientes en esta clase:
        //  * TODO: Agregar un parametro de tipo QueryDinamica a correrQueryDinamico
        //  * TODO: Programar correrQueryDinamico

        public DataTable correrQueryDinamico()
        {
            return null;
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

            return  RealizarConsulta(query);
        }
    }
}
