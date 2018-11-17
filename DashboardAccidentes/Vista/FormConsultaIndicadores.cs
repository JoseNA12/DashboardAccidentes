using DashboardAccidentes.Negocio;
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
        private Controlador miControlador;

        public FormConsultaIndicadores()
        {
            InitializeComponent();
        }

        private void FormConsultaIndicadores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            miControlador = new Controlador();
            DTO miCarrito = miControlador.CargarDatos();

            comboBox_indicador.Items.AddRange(DarFormatoEnumIndicador(miCarrito.getIndicadores()).ToArray());
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            CrearGrafico();
        }

        private void CrearGrafico()
        {
            DTO miCarrito = miControlador.getValores_De_Indicador(comboBox_indicador.SelectedItem.ToString());
            List<string> valores_de_indicador = miCarrito.getGenerico();

            //Remove the Default Series.
            if (grafico_consulta_indicadores.Series.Count() == 1)
            {
                grafico_consulta_indicadores.Series.Remove(grafico_consulta_indicadores.Series[0]);
            }

            //Loop through the Countries.
            foreach (string valor in valores_de_indicador)
            {

                //Get the Year for each Country.
                int[] x = { 2016, 2017, 2018 };

                //Get the Total of Orders for each Country.
                int[] y = { 13, 20, 60 };

                //Add Series to the Chart.
                grafico_consulta_indicadores.Series.Add(new Series(valor));
                grafico_consulta_indicadores.Series[valor].IsValueShownAsLabel = true;
                grafico_consulta_indicadores.Series[valor].BorderWidth = 3;
                grafico_consulta_indicadores.Series[valor].ChartType = SeriesChartType.Line;
                grafico_consulta_indicadores.Series[valor].Points.DataBindXY(x, y);
            }

            grafico_consulta_indicadores.Legends[0].Enabled = true;
        }

        // Una vez recibidos los nombres de los enum's, tratar los strings para ser mostrador en pantalla
        private List<string> DarFormatoEnumIndicador(List<string> pIndicadores)
        {
            List<string> indicadores = new List<string>();

            for (int i = 0; i < pIndicadores.Count; i++)
            {
                indicadores.Add(pIndicadores[i].Replace("_", " "));
            }
            return indicadores;
        }
    }
}
