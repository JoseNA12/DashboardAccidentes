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
            var dt_procesado = dt;

            if (!dt.Columns[0].ColumnName.Equals("nombre_distrito")) //Solo se procesan las consultas a nivel de provincia y canton
            {
                dt_procesado = dt.AsEnumerable()
                    .GroupBy(r => r.Field<string>(0)) //Hace un group by por nombre de canton/provincia
                    .Select(g =>
                    {
                        var row = dt.NewRow();
                        row[0] = g.Key; //g.Key es el nombre del canton o provincia actual

                        row["latitud"] = 

                        dt.AsEnumerable()
                        .Where(r => r.Field<string>(0) == g.Key)
                        .Select(r => r.Field<string>("latitud"))
                        .First(); //Extrae la primera latitud encontrada para la ubicacion

                        row["longitud"] = 
                        dt.AsEnumerable()
                        .Where(r => r.Field<string>(0) == g.Key)
                        .Select(r => r.Field<string>("longitud"))
                        .First(); //Extrae la primera longitud encontrada para la ubicacion

                        row["Accidentes"] = g.Sum(r => r.Field<int>("Accidentes")); //Suma todos los accidentes para una ubicacion

                        return row;

                    }).CopyToDataTable();
            }

            return dt_procesado;
        }

        public void formatearCoordenadas()
        {
            //Aqui va lo del iteraror
        }

        public void realizarConsulta(QueryDinamica q) //TODO no se si vamos a pasarle el query por un dto o por parametros separados
        {
            DAO_Query dao = new DAO_Query();
            DataTable datos = procesarResultadosQuery(dao.correrQueryDinamico(q));
        }
    }
}
