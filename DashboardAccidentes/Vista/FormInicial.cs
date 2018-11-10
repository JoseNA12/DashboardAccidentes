using DashboardAccidentes.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardAccidentes
{
    public partial class FormInicial : Form
    {
        private FormConsultaDinamica mFormConsultaDinamica;
        private FormConsultaIndicadores mFormConsultaIndicadores;
        private FormConsultaLibre mFormConsultaLibre;

        public FormInicial()
        {
            InitializeComponent();
        }

        private void btn_consulta_dinamica_Click(object sender, EventArgs e)
        {
            mFormConsultaDinamica = new FormConsultaDinamica();
            mFormConsultaDinamica.Show();
        }

        private void btn_consulta_indicadores_Click(object sender, EventArgs e)
        {
            mFormConsultaIndicadores = new FormConsultaIndicadores();
            mFormConsultaIndicadores.Show();
        }

        private void btn_consulta_libre_Click(object sender, EventArgs e)
        {
            mFormConsultaLibre = new FormConsultaLibre();
            mFormConsultaLibre.Show();
        }
    }
}
