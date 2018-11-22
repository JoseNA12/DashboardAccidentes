using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class Localizaciones
    {
        private List<string> provincias;
        private List<string> cantones;
        private List<string> distritos;

        public Localizaciones(List<string> provincias, List<string> cantones, List<string> distritos)
        {
            this.provincias = provincias;
            this.cantones = cantones;
            this.distritos = distritos;
        }

        public string obtenerColumnaSelect()
        {
            if(distritos.Count > 0) //Si es a nivel de distritos
            {
                return "d.nombre_distrito,";
            }
            else if (cantones.Count > 0) //Si es a nivel de cantones
            {
                return "c.nombre_canton,";
            }
            else //Si es a nivel de provincias
            {
                return "p.nombre_provincia,";
            }
        }

        private List<string> formatearStringsCondiciones(string columna, List<string> valores)
        {
            List<string> condiciones = new List<string>();

            foreach(string valor in valores)
            {
                condiciones.Add(string.Format("{0} = '{1}'", columna, valor));
            }

            return condiciones;
        }

        public string ToQueryString()
        {
            List<string> partes_condicion = new List<string>();

            if (provincias.Count > 0)
                partes_condicion.Add("(" + string.Join(" OR ", formatearStringsCondiciones("p.nombre_provincia", provincias)) + ")");

            if (cantones.Count > 0)
                partes_condicion.Add("(" + string.Join(" OR ", formatearStringsCondiciones("c.nombre_canton", cantones)) + ")");

            if (distritos.Count > 0)
                partes_condicion.Add("(" + string.Join(" OR ", formatearStringsCondiciones("d.nombre_distrito", distritos)) + ")");

            string result = string.Join(" AND ", partes_condicion);

            if (!result.Equals(string.Empty))
            {
                return result;
            }
            else
            {
                return "1 = 1";
            }
        }
    }
}
