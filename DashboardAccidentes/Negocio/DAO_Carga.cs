using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    class DAO_Carga : DAO_SQL
    {
        
        public List<string> getProvincias()
        {
            string query = "select nombre_provincia from PROVINCIA";
            return RealizarSelect(query, "nombre_provincia");
        }

        public List<string> getAnnios()
        {
            string query = "select distinct annio from ACCIDENTE";
            return RealizarSelect(query, "annio");
        }

        public List<string> getCantones(string provincia)
        {
            string query = "select distinct c.ID_Canton, c.nombre_canton from canton c " +
                           "inner join LOCALIZACION l on l.ID_Canton = c.ID_Canton " +
                           "inner join PROVINCIA p on l.ID_Provincia = p.ID_Provincia " +
                           "where p.nombre_provincia = " + "'" + provincia + "'";
            return RealizarSelect(query, "nombre_canton");
        }

        public List<string> getDistritos(string canton)
        {
            string query = "select distinct d.ID_Distrito, d.nombre_distrito from DISTRITO d " +
                           "inner join LOCALIZACION l on l.ID_Distrito = d.ID_Distrito " +
                           "inner join CANTON c on l.ID_Canton = c.ID_Canton " +
                           "where c.nombre_canton = " + "'" + canton + "'";
            return RealizarSelect(query, "nombre_distrito");
        }

        private List<string> RealizarSelect(string query, string columna)
        {
            DataTable dt = RealizarConsulta(query);
            List<string> datos = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                datos.Add(row[columna].ToString());
            }
            return datos;
        }
    }
}
