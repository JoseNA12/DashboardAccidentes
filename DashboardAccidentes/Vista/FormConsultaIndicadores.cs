using DashboardAccidentes.Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Referencia de API de graficos de Windows Forms:
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

        // Una vez recibidos los nonmbre de los enum's, tratar los strings para ser mostrador en pantalla
        private List<string> DarFormatoEnumIndicador(List<string> pIndicadores)
        {
            List<string> indicadores = new List<string>();

            for (int i = 0; i < pIndicadores.Count; i++)
            {
                indicadores.Add(pIndicadores[i].Replace("_", " "));
            }
            return indicadores;
        }

        // Al hacer click en consultar llama al controlador y le pasa la ref. al grafico para que lo dibuje
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            // Aplica un proceso inverso de formateo y lo pasa a mayuscula, esto para que coincida el nombre del recurso
            // donde se encuentra el string de query. Ver DAO_Query y Resources.resx.
            string indicador_seleccionado = comboBox_indicador.SelectedItem.ToString().Replace(" ", "_").ToUpper();
            miControlador.generarGrafico(indicador_seleccionado, grafico_consulta_indicadores);
        }
    }
}
