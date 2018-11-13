using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    class Controlador
    {
        private DAO_Carga miDao;

        public DTO CargarDatosConsultaDinamica()
        {
            miDao = new DAO_Carga();

            DTO miCarrito = new DTO
                (
                    miDao.getProvincias(),
                    miDao.getAnnios(),
                    ObtenerIndicadores()
                );
            return miCarrito;
        }

        public DTO getCantones(DTO miDTO)
        {
            DTO miCarrito = new DTO
                (
                    miDao.getCantones(miDTO.getGenerico()[0])
                );
            return miCarrito;
        }

        public DTO getDistritos(DTO miDTO)
        {
            DTO miCarrito = new DTO
                (
                    miDao.getDistritos(miDTO.getGenerico()[0])
                );
            return miCarrito;
        }

        private List<string> ObtenerIndicadores()
        {
            List<string> indicadores = new List<string>();

            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Tipo_lesion).Replace("_", " "));
            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Rol_afectado).Replace("_", " "));
            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Genero).Replace("_", " "));
            indicadores.Add(Enum.GetName(typeof(TipoIdentificador), TipoIdentificador.Edad_quincenal).Replace("_", " "));

            return indicadores;
        }
    }
}
