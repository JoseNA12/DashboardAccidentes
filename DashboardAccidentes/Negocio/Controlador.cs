using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace DashboardAccidentes.Negocio
{
    class Controlador
    {
        private DAO_Carga miDao;
        private DatosGrafico datosGrafico;

        // Datos visuales unicamente
        public DTO CargarDatos()
        {
            miDao = new DAO_Carga();

            DTO miCarrito = new DTO
                (
                    miDao.getProvincias(),
                    miDao.getAnnios(),
                    getIndicadores()
                );
            return miCarrito;
        }

        // Dada una provincia obtener los cantones
        public DTO getCantones(DTO miDTO)
        {
            DTO miCarrito = new DTO
                (
                    miDao.getCantones(miDTO.getGenerico()[0])
                );
            return miCarrito;
        }

        // Dado un canton obtener los distritos
        public DTO getDistritos(DTO miDTO)
        {
            DTO miCarrito = new DTO
                (
                    miDao.getDistritos(miDTO.getGenerico()[0])
                );
            return miCarrito;
        }
        
        // Dado el nombre de un indicador (por el enum) obtener los valores respectivos
        public DTO getValores_De_Indicador(string pIndicador)
        {
            DTO miCarrito = null;

            if (pIndicador.Equals(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Tipo_lesion)))
            {
                miCarrito = new DTO(miDao.getValores_De_TipoLesion());
            }
            else if (pIndicador.Equals(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Rol_afectado)))
            {
                miCarrito = new DTO(miDao.getValores_De_RolAfectado());
            }
            else if (pIndicador.Equals(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Genero)))
            {
                miCarrito = new DTO(miDao.getValores_De_Genero());
            }
            else
            {
                miCarrito = new DTO(miDao.getValores_De_EdadQuincenal());
            }
            return miCarrito;
        }

        // Al no tener almacenados los nombres de los indicadores, el controlador los maneja y "setea" para la vista mediante un enum
        private List<string> getIndicadores()
        {
            List<string> indicadores = new List<string>();

            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Tipo_lesion));
            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Rol_afectado));
            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Genero));
            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Edad_quincenal));

            return indicadores;
        }

        public DTO RealizarConsultaDinamica(DTO miDTO)
        {
            List<string> provincias = miDTO.getProvincias();
            List<string> cantones = miDTO.getCantones();
            List<string> distritos = miDTO.getDistritos();
            string anioInicio = miDTO.getAnios()[0];
            string anioFinal = miDTO.getAnios()[1];

            List<Indicador> indicadores = new List<Indicador>();

            foreach (KeyValuePair<string, string> entry in miDTO.getIndicadoresUsuario())
            {
                indicadores.Add(new Indicador(entry.Key, entry.Value));
            }

            Localizaciones localizaciones = new Localizaciones(provincias, cantones, distritos);
            QueryDinamica queryDinamica = new QueryDinamica(
                provincias, 
                cantones, 
                distritos, 
                int.Parse(anioInicio), 
                int.Parse(anioFinal), 
                indicadores
            );

            Handler_Mapas miManejador = new Handler_Mapas();

            DTO miCarrito = new DTO(miManejador.realizarConsulta(queryDinamica));

            return miCarrito;
        }

        public void generarGrafico(string indicador, Chart grafico)
        {
            GeneradorGraficos generador = new GeneradorGraficos();
            generador.procesarDatos(indicador, grafico);
        }

        public void actualizarDatosGrafico(string provincia, int annio)
        {
            datosGrafico.actualizarDatos(provincia, annio);
        }

        public void registrarGraficoObservador(Chart grafico)
        {
            if (datosGrafico == null)
                datosGrafico = new DatosGrafico();

            datosGrafico.subscribir(new GraficoBarras(grafico));
        }

        public string ConstruirURL(List<ResultadoDinamica> lista)
        {
            string URL_base = "https://open.mapquestapi.com/staticmap/v5/map?key=";
            string keyMap = "5vUpKQGPuRhI9lkAbxKaMA2RU7wDGvnj";
            string ubicaciones = "&locations=";
            string tamanio = "&size=790,575";
            string marcador = "flag-";

            string url = URL_base + keyMap + tamanio + tamanio + ubicaciones;

            for (int i = 0; i < lista.Count(); i++)
            {
                ResultadoDinamica result = lista[i];

                url += result.getLatitud() + "," + result.getLongitud() + "|"
                    + marcador + result.getAccidentes();

                if (i != lista.Count() - 1)
                {
                    url += "||";
                }
            }
            return url;
        }

    }
}
