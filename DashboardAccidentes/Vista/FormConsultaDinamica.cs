﻿using DashboardAccidentes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
            comboBox_indicador.Items.AddRange(TratarEnum.DarFormatoEnumIndicador(miCarrito.getIndicadores()).ToArray());

            comboBox_fechaFinal.Items.Add("Sin año");
        }

        #region Obtención de datos cuando se realiza la acción consultar

        private List<string> getProvincasMarcadas()
        {
            List<string> misProvincias = new List<string>();

            for (int i = 0; i <= (checkedListBox_provincias.Items.Count - 1); i++)
            {
                if (checkedListBox_provincias.GetItemChecked(i))
                {
                    misProvincias.Add(checkedListBox_provincias.Items[i].ToString());
                }
            }
            return misProvincias;
        }

        private List<string> getCantonesMarcados()
        {
            List<string> misCantones = new List<string>();

            for (int i = 0; i <= (checkedListBox_cantones.Items.Count - 1); i++)
            {
                if (checkedListBox_cantones.GetItemChecked(i))
                {
                    misCantones.Add(checkedListBox_cantones.Items[i].ToString());
                }
            }
            return misCantones;
        }

        private List<string> getDistritosMarcados()
        {
            List<string> misDistritos = new List<string>();

            for (int i = 0; i <= (checkedListBox_distritos.Items.Count - 1); i++)
            {
                if (checkedListBox_distritos.GetItemChecked(i))
                {
                    misDistritos.Add(checkedListBox_distritos.Items[i].ToString());
                }
            }
            return misDistritos;
        }

        private List<string> getAniosMarcados()
        {
            string anioInicio = "";
            string anioFinal = "";

            if (comboBox_fechaInicial.SelectedItem != null)
            {
                anioInicio = comboBox_fechaInicial.SelectedItem.ToString();

                if (comboBox_fechaFinal.SelectedItem != null)
                {
                    if (!comboBox_fechaFinal.SelectedItem.ToString().Equals("Sin año"))
                    {
                        anioFinal = comboBox_fechaFinal.SelectedItem.ToString();
                    }
                    else
                    {
                        anioFinal = comboBox_fechaInicial.SelectedItem.ToString(); 
                    }

                    if (int.Parse(anioInicio) <= int.Parse(anioFinal))
                    {
                        List<string> anios = new List<string> { anioInicio, anioFinal };
                        return anios;
                    }
                }
            }
            return null;
        }

        private Dictionary<string, string> getIndicadoresMarcados()
        {
            Dictionary<string, string> misIndicadores = new Dictionary<string, string>(); // Orden: <indicador, valor>

            foreach (ListViewItem itemRow in this.listView_misIndicadores.Items)
            {
                misIndicadores.Add(itemRow.SubItems[0].Text, itemRow.SubItems[1].Text);
            }
            return misIndicadores;
        }
        #endregion

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
                TratarEnum.FormatearEnumIdicadores(comboBox_indicador.SelectedItem.ToString()));

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
                    MessageBox.Show("El indicador ya ha sido registrado!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Los campos del indicador y el valor deben tener un valor seleccionado!", "Error");
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
                MessageBox.Show("Debe seleccionar un indicador para poder eliminarlo de su busqueda!", "Error");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            List<string> anios = getAniosMarcados();

            if (anios != null)
            {
                List<string> misProvincias = getProvincasMarcadas();
                List<string> misCantones = getCantonesMarcados();
                List<string> misDistritos = getDistritosMarcados();
                Dictionary<string, string> misIndicadores = getIndicadoresMarcados();

                // RESULTADO PARA ENVIAR
                
                DTO miCarrito = new DTO(misProvincias, misCantones, misDistritos, anios, misIndicadores);
                //DTO miResultado = miControlador.RealizarConsultaDinamica(miCarrito);
                DTO miResultado = miControlador.RealizarConsultaDinamica(miCarrito);

                if (miResultado.getURL() != null)
                {
                    progressBar_consulta.Visible = true;
                    btn_consultar.Enabled = false;
                    lb_msg.Text = "Generando imagen GPS...";

                    Thread currentThread = new Thread(delegate ()
                    {
                        DesplegarImagenMapa(miResultado.getURL());

                        Invoke((MethodInvoker)delegate ()
                        {
                            progressBar_consulta.Visible = false;
                            btn_consultar.Enabled = true;
                            lb_msg.Text = "";
                        });
                    }
                    );
                    currentThread.Start();
                }
                else
                {
                    MessageBox.Show("No se han encontrado accidentes con los parametros indicados!.", "Atención!");
                }
            }
            else
            {
                MessageBox.Show("Error, por favor indique los años correctamente!.", "Atención!");
            }
        }

        private void DesplegarImagenMapa(string URL) // recibiria un string solamente
        {
            //string miURL = miControlador.ConstruirURL(miResultado.getResultadoDinamica());
 
            Uri uri = new Uri(URL);
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(uri);

            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            Stream imageStream = httpResponse.GetResponseStream();
            Bitmap buddyIcon = new Bitmap(imageStream);
            httpResponse.Close();
            imageStream.Close();

            //Cargar imagen
            pb_imagenMapa.Image = buddyIcon;
        }
    }
}
