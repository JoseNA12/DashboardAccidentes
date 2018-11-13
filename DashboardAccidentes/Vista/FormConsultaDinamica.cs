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
    public partial class FormConsultaDinamica : Form
    {
        private Controlador miControlador;

        public FormConsultaDinamica()
        {
            InitializeComponent();
        }

        private void FormConsultaDinamica_Load(object sender, EventArgs e)
        {
            ConfigurarComponentes();
            miControlador = new Controlador();
            DTO miCarrito = miControlador.CargarDatosConsultaDinamica();

            comboBox_fechaInicial.Items.AddRange(miCarrito.getAnios().ToArray());
            comboBox_fechaFinal.Items.AddRange(miCarrito.getAnios().ToArray());
            checkedListBox_provincias.Items.AddRange(miCarrito.getProvincias().ToArray());
            comboBox_indicador.Items.AddRange(miCarrito.getIndicadores().ToArray());
        }

        #region Lógica IU (Handler's, botones, paneles, etc)

        private void ConfigurarComponentes()
        {
            pnlMenuGroup_provincias.Height = 25;
            pnlMenuGroup_cantones.Height = 25;
            pnlMenuGroup_distritos.Height = 25;

            btn_provincias.Image = Properties.Resources.down;
            btn_cantones.Image = Properties.Resources.down;
            btn_distritos.Image = Properties.Resources.down;

            ocultarComponentes();
        }

        private void btn_provincias_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup_provincias.Height == 25)
            {
                pnlMenuGroup_provincias.Height = (25 * 4) + 32;
                btn_provincias.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup_provincias.Height = 25;
                btn_provincias.Image = Properties.Resources.down;
            }

            ocultarComponentes();
        }

        private void btn_cantones_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup_cantones.Height == 25)
            {
                pnlMenuGroup_cantones.Height = (25 * 4) + 32;
                btn_cantones.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup_cantones.Height = 25;
                btn_cantones.Image = Properties.Resources.down;
            }

            ocultarComponentes();
        }

        private void btn_distritos_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup_distritos.Height == 25)
            {
                pnlMenuGroup_distritos.Height = (25 * 4) + 32;
                btn_distritos.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup_distritos.Height = 25;
                btn_distritos.Image = Properties.Resources.down;
            }

            ocultarComponentes();
        }

        private void ocultarComponentes()
        {
            int cantidadPanelesOcultar = 3;


            if (pnlMenuGroup_provincias.Height == 25)
            {
                cantidadPanelesOcultar -= 1;
            }

            if (pnlMenuGroup_cantones.Height == 25)
            {
                cantidadPanelesOcultar -= 1;
            }

            if (pnlMenuGroup_distritos.Height == 25)
            {
                cantidadPanelesOcultar -= 1;
            }

            switch (cantidadPanelesOcultar)
            {
                case 0:
                    panel_anios.Visible = true;
                    panel_indicadores.Visible = true;
                    panel_mi_busqueda.Visible = true;
                    break;

                case 1:
                    panel_anios.Visible = false;
                    panel_indicadores.Visible = true;
                    panel_mi_busqueda.Visible = true;
                    break;

                case 2:
                    panel_anios.Visible = false;
                    panel_indicadores.Visible = false;
                    panel_mi_busqueda.Visible = true;
                    break;

                case 3:
                    panel_anios.Visible = false;
                    panel_indicadores.Visible = false;
                    panel_mi_busqueda.Visible = false;
                    break;
            }

        }
        #endregion

        private void checkedListBox_provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidadSeleccionados = checkedListBox_provincias.CheckedItems.Count;

            if (cantidadSeleccionados == 1)
            {
                DTO miCarrito = miControlador.getCantones(new DTO
                    (
                    new List<string> { checkedListBox_provincias.CheckedItems[0].ToString() })
                    );

                checkedListBox_cantones.Items.AddRange(miCarrito.getGenerico().ToArray());
            }
            else
            {
                checkedListBox_cantones.Items.Clear();
                checkedListBox_distritos.Items.Clear();
            }
        }

        private void checkedListBox_cantones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidadSeleccionados = checkedListBox_cantones.CheckedItems.Count;

            if (cantidadSeleccionados == 1)
            {
                DTO miCarrito = miControlador.getDistritos(new DTO
                    (
                    new List<string> { checkedListBox_cantones.CheckedItems[0].ToString() })
                    );

                checkedListBox_distritos.Items.AddRange(miCarrito.getGenerico().ToArray());
            }
            else
            {
                checkedListBox_distritos.Items.Clear();
            }
        }

        private void checkedListBox_distritos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
