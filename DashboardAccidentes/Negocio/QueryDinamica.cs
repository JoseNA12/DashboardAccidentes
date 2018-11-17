using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class QueryDinamica : Query
    {
        private Localizaciones localizaciones;

        private int annoInicio;
        private int annoFin;

        public List<Indicador> indicadores { get; private set; }

        public QueryDinamica(
            List<string> provincias, 
            List<string> cantones, 
            List<string> distritos, 
            int annoInicio, 
            int annoFin, 
            List<Indicador> indicadores)
        {
            this.localizaciones = new Localizaciones(provincias, cantones, distritos);
            this.annoInicio = annoInicio;
            this.annoFin = annoFin;
            this.indicadores = indicadores;
        }

        public string construirConsulta()
        {
            string esqueleto_query = Properties.Resources.ResourceManager.GetString("QUERY_DINAMICA_ESQUELETO");

            string columna_select = localizaciones.obtenerColumnaSelect();
            string condiciones_localizaciones = localizaciones.ToQueryString();

            esqueleto_query = esqueleto_query.Replace("{0}", columna_select);
            esqueleto_query = esqueleto_query.Replace("{1}", annoInicio.ToString());
            esqueleto_query = esqueleto_query.Replace("{2}", annoFin.ToString());
            esqueleto_query = esqueleto_query.Replace("{3}", condiciones_localizaciones);

            return esqueleto_query;
        }
    }
}
