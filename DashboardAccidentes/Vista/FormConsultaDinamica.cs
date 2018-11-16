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
            CargarDatos();
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

        private void CargarDatos()
        {
            miControlador = new Controlador();
            DTO miCarrito = miControlador.CargarDatos();

            comboBox_fechaInicial.Items.AddRange(miCarrito.getAnios().ToArray());
            comboBox_fechaFinal.Items.AddRange(miCarrito.getAnios().ToArray());
            checkedListBox_provincias.Items.AddRange(miCarrito.getProvincias().ToArray());
            comboBox_indicador.Items.AddRange(DarFormatoEnumIndicador(miCarrito.getIndicadores()).ToArray());

            comboBox_fechaFinal.Items.Add("Sin año");
        }

        private void checkedListBox_provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string s;
            //s = "Checked items:\n";
            int cantidadSeleccionados = 0;

            for (int i = 0; i <= (checkedListBox_provincias.Items.Count - 1); i++)
            {
                if (checkedListBox_provincias.GetItemChecked(i))
                {
                    cantidadSeleccionados++;
                    //s = s + "Item " + (i + 1).ToString() + " = " + checkedListBox_provincias.Items[i].ToString() + "\n";
                }
            }

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
            int cantidadSeleccionados = 0;

            for (int i = 0; i <= (checkedListBox_cantones.Items.Count - 1); i++)
            {
                if (checkedListBox_cantones.GetItemChecked(i))
                {
                    cantidadSeleccionados++;
                }
            }

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

        private void comboBox_indicador_TextChanged(object sender, EventArgs e)
        {
            comboBox_valorIndicador.Items.Clear();

            DTO miCarrito = miControlador.getValores_De_Indicador(
                FormatearEnumIdicadores(comboBox_indicador.SelectedItem.ToString()));

            comboBox_valorIndicador.Items.AddRange(miCarrito.getGenerico().ToArray());
        }

        private void btn_agregarIndicador_Click(object sender, EventArgs e)
        {
            bool puedoAgregar = true;
            if (comboBox_indicador.SelectedItem != null && comboBox_valorIndicador.SelectedItem != null)
            {
                foreach (ListViewItem itemRow in this.listView_misIndicadores.Items)
                {
                    if (comboBox_indicador.SelectedItem.Equals(itemRow.SubItems[0].Text))
                    {
                        puedoAgregar = false;
                    }
                }

                if (puedoAgregar)
                {
                    ListViewItem items = new ListViewItem(new string[]
                                    { comboBox_indicador.SelectedItem.ToString(), comboBox_valorIndicador.SelectedItem.ToString() });

                    listView_misIndicadores.Items.AddRange(new ListViewItem[] { items });
                }
                else
                {
                    MessageBox.Show("Error, el indicador ya ha sido registrado!");
                }
            }
            else
            {
                MessageBox.Show("Error, los campos del indicador y el valor deben tener un valor seleccionado!");
            }
        }

        private void btn_eliminarIndicador_Click(object sender, EventArgs e)
        {
            if (listView_misIndicadores.SelectedIndices.Count > 0)
            {
                listView_misIndicadores.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Error, debe seleccionar un indicador para poder eliminarlo de su busqueda!");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            // HACER LA VALIDACIONES NECESARIAS

            // Provincias
            List<string> misProvincias = new List<string>();

            for (int i = 0; i <= (checkedListBox_provincias.Items.Count - 1); i++)
            {
                if (checkedListBox_provincias.GetItemChecked(i))
                {
                    misProvincias.Add(checkedListBox_provincias.Items[i].ToString());
                }
            }

            // Cantones
            List<string> misCantones = new List<string>();

            for (int i = 0; i <= (checkedListBox_cantones.Items.Count - 1); i++)
            {
                if (checkedListBox_cantones.GetItemChecked(i))
                {
                    misCantones.Add(checkedListBox_cantones.Items[i].ToString());
                }
            }

            // Distritos
            List<string> misDistritos = new List<string>();

            for (int i = 0; i <= (checkedListBox_distritos.Items.Count - 1); i++)
            {
                if (checkedListBox_distritos.GetItemChecked(i))
                {
                    misCantones.Add(checkedListBox_distritos.Items[i].ToString());
                }
            }

            // Indicadores
            Dictionary<string, string> misIndicadores = new Dictionary<string, string>();
            //       <indicador, valor>

            foreach (ListViewItem itemRow in this.listView_misIndicadores.Items)
            {
                misIndicadores.Add(itemRow.SubItems[0].Text, itemRow.SubItems[1].Text);
            }

            // Años
            string anioInicio = comboBox_fechaInicial.SelectedText;
            string anioFinal = "";
            if (!comboBox_fechaFinal.SelectedText.Equals("Sin año")) { anioFinal = comboBox_fechaFinal.SelectedText; }

            List<string> anios = new List<string>(); anios.Add(anioInicio); anios.Add(anioFinal);



            // RESULTADO PARA ENVIAR
            DTO miLambo = new DTO(misProvincias, misCantones, misCantones, anios, misIndicadores);
            miControlador.RealizarConsultaDinamica(miLambo);
        }

        // Una vez recibidos los nonmbre de los enum's, tratar los strings para ser mostrador en pantalla
        private List<string> DarFormatoEnumIndicador(List<string> pIndicadores)
        {
            List<string> indicadores = new List<string>();

            for(int i = 0; i < pIndicadores.Count; i++)
            {
                indicadores.Add(pIndicadores[i].Replace("_", " "));
            }
            return indicadores;
        }

        // Para cuando envio al controlador el indicador que seleccioné, enviarle el mismo nombre "original" del enum como tal
        private string FormatearEnumIdicadores(string pIndicador)
        {
            return pIndicador.Replace(" ", "_");
        }
    }
}
