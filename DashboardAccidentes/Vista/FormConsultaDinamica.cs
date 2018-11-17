using DashboardAccidentes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

            ObtenerImagenMapa();
        }

        private void ObtenerImagenMapa()
        {
            /* Guias
            // https://developers.google.com/maps/documentation/maps-static/dev-guide
            // https://csharp.hotexamples.com/examples/System.Windows.Forms/PictureBox/Load/php-picturebox-load-method-examples.html
            // https://developers.google.com/maps/documentation/maps-static/intro?csw=1
            // --------------
            string googleKey = "AIzaSyARQO1lorK1UyiWJk438q1U7jCzZkXIj7c"; // NO modificar
            string signature = "signature=p0Jo36aoj_ML4N0X1FjdH4P_6PE=";

            string dir = "https://maps.googleapis.com/maps/api/staticmap?center=63.259591,-144.667969&zoom=6&size=400x400&markers=color:blue|label:S|62.107733,-145.541936&markers=size:tiny|color:green|Delta+Junction,AK&markers=size:mid|color:0xFFFF00|label:C|Tok,AK&key=" + googleKey;
            string dir_2 = "https://maps.googleapis.com/maps/api/staticmap?center=63.259591,-144.667969&zoom=13&size=600x300&maptype=roadmap " +
                   " & markers = color:blue % 7Clabel: S % 7C40.702147,-74.015794 & markers = color:green % 7Clabel: G % 7C40.711614,-74.012318" +
                   "& markers = color:red % 7Clabel: C % 7C40.718217,-73.998284" +
                   "& key = " + googleKey;
            */

            Uri uri_1 = new Uri("https://open.mapquestapi.com/staticmap/v5/map?key=" + miControlador.getKeyMap() + "&locations=New+York,NY|flag-putojaja||Buffalo,NY|flag-Holakh12||Rochester,NY|flag-drinkaa-md&size=790,575");

            Uri uri_2 = new Uri("https://open.mapquestapi.com/staticmap/v5/map?key=" + miControlador.getKeyMap() + "&center=40.039401,-76.307078&size=686,520");

            HttpWebRequest httpRequest = (HttpWebRequest)HttpWebRequest.Create(uri_1);

            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            Stream imageStream = httpResponse.GetResponseStream();
            Bitmap buddyIcon = new Bitmap(imageStream);
            httpResponse.Close();
            imageStream.Close();

            //Load Image
            pb_imagenMapa.Image = buddyIcon;

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
