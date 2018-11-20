using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardAccidentes.Negocio
{
    public class GraficoBarras : IGraficoSubscriptor
    {
        private Chart grafico;

        public GraficoBarras(Chart g)
        {
            grafico = g;
        }

        public void update(DataTable datos)
        {
            foreach(var series in grafico.Series)
            {
                series.Points.Clear();
            }
            grafico.Series.Clear();

            grafico.ChartAreas[0].AxisX.Interval = 1;
            grafico.DataBindTable(datos.AsDataView(), "rol");
            grafico.Series[0].IsValueShownAsLabel = true;
        }
    }
}
