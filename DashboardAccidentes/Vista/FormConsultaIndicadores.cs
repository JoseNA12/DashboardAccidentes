using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// https://www.aspsnippets.com/Articles/Create-Multi-Series-Line-Chart-Graph-in-Windows-Forms-Application-using-C-and-VBNet.aspx

namespace DashboardAccidentes.Vista
{
    public partial class FormConsultaIndicadores : Form
    {

        public FormConsultaIndicadores()
        {
            InitializeComponent();
        }

        private void FormConsultaIndicadores_Load(object sender, EventArgs e)
        {
            //Get the DISTINCT Countries.
            List<string> countries = new List<string>();
            countries.Add("San José");
            countries.Add("Limón");
            countries.Add("Heredia");

            //Remove the Default Series.
            if (grafico_consulta_indicadores.Series.Count() == 1)
            {
                grafico_consulta_indicadores.Series.Remove(grafico_consulta_indicadores.Series[0]);
            }

            //Loop through the Countries.
            foreach (string country in countries)
            {

                //Get the Year for each Country.
                int[] x = { 2016, 2017, 2018 };

                //Get the Total of Orders for each Country.
                int[] y = { 13, 20, 60 };

                //Add Series to the Chart.
                grafico_consulta_indicadores.Series.Add(new Series(country));
                grafico_consulta_indicadores.Series[country].IsValueShownAsLabel = true;
                grafico_consulta_indicadores.Series[country].BorderWidth = 3;
                grafico_consulta_indicadores.Series[country].ChartType = SeriesChartType.Line;
                grafico_consulta_indicadores.Series[country].Points.DataBindXY(x, y);
            }

            grafico_consulta_indicadores.Legends[0].Enabled = true;
        }
    }
}
