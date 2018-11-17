using System.Collections.Generic;
using System.Data;

namespace DashboardAccidentes.Negocio
{
    public class DatosGrafico
    {
        public DataTable datos;
        private List<IGraficoSubscriptor> subscriptores = new List<IGraficoSubscriptor>();

        public void subscribir(IGraficoSubscriptor s)
        {
            subscriptores.Add(s);
        }

        public void notificarSubscriptores()
        {
            foreach(IGraficoSubscriptor subscriptor in subscriptores)
            {
                subscriptor.update(datos);
            }
        }

        public void actualizarDatos(string provincia, int annio)
        {
            datos = new DAO_Query().correrQueryLibre(provincia, annio);
            notificarSubscriptores();
        }
    }
}
