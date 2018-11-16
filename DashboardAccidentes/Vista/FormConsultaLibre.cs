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
        }

        private void CargarDatos()
        {
            miControlador = new Controlador();
            DTO miCarrito = miControlador.CargarDatos();

            comboBox_provincias.Items.AddRange(miCarrito.getProvincias().ToArray());
            comboBox_anios.Items.AddRange(miCarrito.getAnios().ToArray());
        }
    }
}
