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
        private int tamanioPanel = 25;
        private int tamanioPanelApertura = 32;

        public FormConsultaDinamica()
        {
            InitializeComponent();
        }

        #region Lógica IU (Handler's, botones, paneles, etc)

        private void FormConsultaDinamica_Load(object sender, EventArgs e)
        {

            pnlMenuGroup_provincias.Height = tamanioPanel;
            pnlMenuGroup_cantones.Height = tamanioPanel;
            pnlMenuGroup_distritos.Height = tamanioPanel;

            btn_provincias.Image = Properties.Resources.down;
            btn_cantones.Image = Properties.Resources.down;
            btn_distritos.Image = Properties.Resources.down;

            ocultarComponentes();
        }

        private void btn_provincias_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup_provincias.Height == tamanioPanel)
            {
                pnlMenuGroup_provincias.Height = (tamanioPanel * 4) + tamanioPanelApertura;
                btn_provincias.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup_provincias.Height = tamanioPanel;
                btn_provincias.Image = Properties.Resources.down;
            }

            ocultarComponentes();
        }

        private void btn_cantones_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup_cantones.Height == tamanioPanel)
            {
                pnlMenuGroup_cantones.Height = (tamanioPanel * 4) + tamanioPanelApertura;
                btn_cantones.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup_cantones.Height = tamanioPanel;
                btn_cantones.Image = Properties.Resources.down;
            }

            ocultarComponentes();
        }

        private void btn_distritos_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup_distritos.Height == tamanioPanel)
            {
                pnlMenuGroup_distritos.Height = (tamanioPanel * 4) + tamanioPanelApertura;
                btn_distritos.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup_distritos.Height = tamanioPanel;
                btn_distritos.Image = Properties.Resources.down;
            }

            ocultarComponentes();
        }

        private void ocultarComponentes()
        {
            int cantidadPanelesOcultar = 3;


            if (pnlMenuGroup_provincias.Height == tamanioPanel)
            {
                cantidadPanelesOcultar -= 1;
            }

            if (pnlMenuGroup_cantones.Height == tamanioPanel)
            {
                cantidadPanelesOcultar -= 1;
            }

            if (pnlMenuGroup_distritos.Height == tamanioPanel)
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
    }
}
