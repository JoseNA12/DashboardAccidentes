using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    class ConfigMapa
    {
        private readonly string URL_base = "https://open.mapquestapi.com/staticmap/v5/map?key=";
        private readonly string keyMap = "5vUpKQGPuRhI9lkAbxKaMA2RU7wDGvnj";
        private readonly string ubicaciones = "&locations=";
        private readonly string tamanio = "&size=";
        private readonly string marcador = "flag-";

        public string getURL_base()
        {
            return URL_base;
        }

        public string getKeyMap()
        {
            return keyMap;
        }

        public string getTagUbicaciones()
        {
            return ubicaciones;
        }

        public string getTagTamanio()
        {
            return tamanio;
        }

        public string getTagMarcador()
        {
            return marcador;
        }
    }
}
