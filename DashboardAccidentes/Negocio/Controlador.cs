﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    class Controlador
    {
        private DAO_Carga miDao;

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

        public void RealizarConsultaDinamica(DTO miDTO)
        {
            List<string> provincias = miDTO.getProvincias();
            List<string> cantones = miDTO.getCantones();
            List<string> distritos = miDTO.getDistritos();
            string anioInicio = miDTO.getAnios()[0];
            string aniFinal = miDTO.getAnios()[1];
            Dictionary<string, string> indicadores = miDTO.getMisIndicadores();

            // Decorador
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
    }
}
