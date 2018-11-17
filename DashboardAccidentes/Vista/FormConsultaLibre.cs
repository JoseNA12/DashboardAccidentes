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

namespace DashboardAccidentes.Vista
{
    public partial class FormConsultaLibre : Form
    {
        private Controlador miControlador;

        public FormConsultaLibre()
        {
            InitializeComponent();
        }

        private void FormConsultaLibre_Load(object sender, EventArgs e)
        {
            CargarDatos();
            miControlador.registrarGraficoObservador(grafico_consulta_libre);
        }

        private void CargarDatos()
        {
            miControlador = new Controlador();
            DTO miCarrito = miControlador.CargarDatos();

            comboBox_provincias.Items.AddRange(miCarrito.getProvincias().ToArray());
            comboBox_anios.Items.AddRange(miCarrito.getAnios().ToArray());
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string provincia_seleccionada = comboBox_provincias.SelectedItem.ToString();
            int annio_seleccionado = int.Parse(comboBox_anios.SelectedItem.ToString());

            string titulo = string.Format("Roles de accidentados: {0} ({1})", provincia_seleccionada, annio_seleccionado);
            grafico_consulta_libre.Titles["Title1"].Text = string.Format(titulo);

            miControlador.actualizarDatosGrafico(provincia_seleccionada, annio_seleccionado);
        }
    }
}
