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
        //  * TODO: Programar correrQueryLibre
        //  * TODO: Hacer que DAO_Query sea cliente de DatosGrafico segun el patron observer (Ver UML).

        public DataTable correrQueryDinamico()
        {
            return null;
        }

        public DataTable correrQueryIndicador(string indicador)
        {
            string query = Properties.Resources.ResourceManager.GetString("QUERY_" + indicador);
            return RealizarConsulta(query);
        }

        public DataTable correrQueryLibre()
        {
            return null;
        }
    }
}
