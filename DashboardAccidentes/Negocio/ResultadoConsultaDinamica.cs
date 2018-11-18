using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    class ResultadoConsultaDinamica
    {
        private string provincia;
        private string canton;
        private string distrito;
        private string latitud;
        private string longitud;

        public ResultadoConsultaDinamica(string provincia, string canton, string distrito, string latitud, string longitud)
        {
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        public string getProvincia()
        {
            return provincia;
        }

        public string getCanton()
        {
            return canton;
        }

        public string getDistrito()
        {
            return distrito;
        }

        public string getLatitud()
        {
            return latitud;
        }

        public string getLongitud()
        {
            return longitud;
        }
    }
}
