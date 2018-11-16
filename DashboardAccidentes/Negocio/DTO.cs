using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    class DTO
    {
        private List<string> provincias;
        private List<string> cantones;
        private List<string> distritos;
        private List<string> anios;
        private List<string> indicadores; // solo cargar info
        private Dictionary<string, string> misIndicadores; // indicadores del usuario cuando consulta
        private List<string> generico; // utilizado para transportar los datos cuando el usuario selecciona una provincia, indicador, etc. (más que todo por la sobrecarga de constructores)

        public DTO(List<string> provincias, List<string> cantones, List<string> distritos, List<string> indicadores, List<string> anios)
        {
            this.provincias = provincias;
            this.cantones = cantones;
            this.distritos = distritos;
            this.anios = anios;
            this.indicadores = indicadores;
        }

        public DTO(List<string> provincias, List<string> anios, List<string> indicadores)
        {
            this.provincias = provincias;
            this.anios = anios;
            this.indicadores = indicadores;
        }

        public DTO(List<string> generico)
        {
            this.generico = generico;
        }

        public DTO(List<string> provincias, List<string> cantones, List<string> distritos, List<string> anios, Dictionary<string, string> misIndicadores)
        {
            this.provincias = provincias;
            this.cantones = cantones;
            this.distritos = distritos;
            this.anios = anios;
            this.misIndicadores = misIndicadores;
        }

        public List<string> getProvincias()
        {
            return provincias;
        }

        public List<string> getCantones()
        {
            return cantones;
        }

        public List<string> getDistritos()
        {
            return distritos;
        }

        public List<string> getAnios()
        {
            return anios;
        }

        public List<string> getIndicadores()
        {
            return indicadores;
        }

        public List<string> getGenerico()
        {
            return generico;
        }

        public Dictionary<string, string> getMisIndicadores()
        {
            return misIndicadores;
        }
    }
}