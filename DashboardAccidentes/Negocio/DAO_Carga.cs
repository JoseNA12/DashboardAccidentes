using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class DAO_Carga : DAO_SQL
    {
        // Obtener todas las provincias
        public List<string> getProvincias()
        {
            string query = "select p.nombre_provincia from PROVINCIA p order by p.nombre_provincia asc";
            return RealizarSelect(query, "nombre_provincia");
        }

        // Obtener los años de los registro de los accidentes
        public List<string> getAnnios()
        {
            string query = "select distinct annio from ACCIDENTE";
            return RealizarSelect(query, "annio");
        }

        // Dada una provincia obtener sus respectivos cantones
        public List<string> getCantones(string provincia)
        {
            string query = "select distinct c.ID_Canton, c.nombre_canton from canton c " +
                           "inner join LOCALIZACION l on l.ID_Canton = c.ID_Canton " +
                           "inner join PROVINCIA p on l.ID_Provincia = p.ID_Provincia " +
                           "where p.nombre_provincia = " + "'" + provincia + "'" +
                           " order by c.nombre_canton asc";
            return RealizarSelect(query, "nombre_canton");
        }

        // Dado un canton obtener sus respectivos distritos
        public List<string> getDistritos(string canton)
        {
            string query = "select distinct d.ID_Distrito, d.nombre_distrito from DISTRITO d " +
                           "inner join LOCALIZACION l on l.ID_Distrito = d.ID_Distrito " +
                           "inner join CANTON c on l.ID_Canton = c.ID_Canton " +
                           "where c.nombre_canton = " + "'" + canton + "'" +
                           " order by d.nombre_distrito asc";
            return RealizarSelect(query, "nombre_distrito");
        }

        public List<string> getValores_De_TipoLesion()
        {
            string query = "SELECT tipo_lesion FROM LESION";

            return RealizarSelect(query, "tipo_lesion");
        }

        public List<string> getValores_De_RolAfectado()
        {
            string query = "SELECT rol FROM ROLAFECTADO";

            return RealizarSelect(query, "rol");
        }

        public List<string> getValores_De_Genero()
        {
            string query = "SELECT sexo FROM GENERO";

            return RealizarSelect(query, "sexo");
        }

        public List<string> getValores_De_EdadQuincenal()
        {
            string query = "SELECT distinct a.edad_quinquenal FROM AFECTADO a order by a.edad_quinquenal asc";

            return RealizarSelect(query, "edad_quinquenal");
        }

        // Mandar a ejecutar el metodo de DAO_SQL para realizar la petición a la BD, se ingresa la consulta deseada
        // Recibe el query de SQL y el nombre de la columna donde recide el resultado
        private List<string> RealizarSelect(string query, string columnaTabla)
        {
            DataTable dt = RealizarConsulta(query);
            List<string> datos = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                datos.Add(row[columnaTabla].ToString());
            }
            return datos;
        }
    }
}
