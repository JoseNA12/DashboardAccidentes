using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class ResultadoConsultaDinamica
    {
        private string provincia;
        private string canton;
        private string distrito;
        private string latitud;
        private string longitud;
        private string accidentes;

        public ResultadoConsultaDinamica(string provincia, string canton, string distrito, string latitud, string longitud, string accidentes)
        {
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.latitud = latitud;
            this.longitud = longitud;
            this.accidentes = accidentes;
        }

        public ResultadoConsultaDinamica() { }

        public void setProvincia(string provincia)
        {
            this.provincia = provincia;
        }

        public void setCanton(string canton)
        {
            this.canton = canton;
        }

        public void setDistrito(string distrito)
        {
            this.distrito = distrito;
        }

        public void setLatitud(string latitud)
        {
            this.latitud = latitud;
        }

        public void setLongitud(string longitud)
        {
            this.longitud = longitud;
        }

        public void setAccidentes(string accidentes)
        {
            this.accidentes = accidentes;
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

        public string getAccidentes()
        {
            return accidentes;
        }
    }
}
