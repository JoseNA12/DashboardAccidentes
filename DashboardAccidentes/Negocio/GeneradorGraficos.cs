using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardAccidentes.Negocio
{
    public class GeneradorGraficos
    {
        private readonly int INDICE_COLUMNA_SERIE = 0; //Columna donde estan los valores del indicador

        public void procesarDatos(string indicador, Chart grafico)
        {
            limpiarGrafico(grafico);

            DataTable dt = new DAO_Query().correrQueryIndicador(indicador);
            List<string> series_grafico = obtenerValoresIndicador(dt);

            foreach(string serie in series_grafico)
            {
                List<int> x = new List<int>();
                List<int> y = new List<int>();

                foreach(DataRow row in dt.Rows)
                {
                    if (row[INDICE_COLUMNA_SERIE].ToString().Equals(serie))
                    {
                        x.Add((int) row["annio"]);
                        y.Add((int) row["accidentes"]);
                    }                 
                }

                grafico.Series.Add(new Series(serie));
                grafico.Series[serie].IsValueShownAsLabel = true;
                grafico.Series[serie].BorderWidth = 3;
                grafico.Series[serie].ChartType = SeriesChartType.Line;
                grafico.Series[serie].Points.DataBindXY(x, y);
            }      
        }

        private List<string> obtenerValoresIndicador(DataTable dt)
        {
            //Obtiene el nombre de la columna (en el query) donde estan los valores del indicador
            string columna_valores = dt.Columns[INDICE_COLUMNA_SERIE].ColumnName;     
            //Hace un select de LINQ sobre esta columna y elimina duplicados (Distinct())
            var valores = (from p in dt.AsEnumerable()
                           select p.Field<string>(columna_valores)
                           ).Distinct().ToList();

            return valores;
        }

        private void limpiarGrafico(Chart grafico)
        {
            foreach(var series in grafico.Series)
            {
                series.Points.Clear();
            }

            grafico.Series.Clear();
        }
    }
}
