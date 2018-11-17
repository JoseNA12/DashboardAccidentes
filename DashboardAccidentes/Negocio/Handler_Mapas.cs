using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class Handler_Mapas
    {
        public DataTable procesarResultadosQuery(DataTable dt)
        {
            //Aqui va el procesamiento de LINQ
            return null;
        }

        public void formatearCoordenadas()
        {
            //Aqui va lo del iteraror
        }

        public void realizarConsulta() //TODO no se si vamos a pasarle el query por un dto o por parametros separados
        {
            DAO_Query dao = new DAO_Query();
            //DataTable datos = procesarResultadosQuery(dao.correrQueryDinamico());
        }
    }
}
