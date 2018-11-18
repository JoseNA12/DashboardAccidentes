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

            List<string> info = new List<string>();

            foreach (DataRow row in datos.Rows)
            {
                info.Add(row["Accidentes"].ToString());

                convertirCoordenadas(row["latitud"].ToString(), row["longitud"].ToString());

                // nombre_[provincia|canton|distrito], latitud, longitud, Accidentes
            }
        }

        private List<string> convertirCoordenadas(string latitud, string longitud)
        {
            /*
               Las coordenadas vienen así: -81°53'24"
               El primer número son grados, el segundo minutos y el tercero segundos 
               La coordenada en decimales es así:
               c = grados + (minutos/60) + (segundos / 3600) 
               Pero los grados tienen que estar positivos, si es negativo nada más es de multiplicar por -1 los grados, hacer el cálculo y multiplicar por -1 el resultado
            */

            char[] delimitadores = { '°', '\'', '"' };
            string[] numerosLatitud = latitud.Split(delimitadores);
            string[] numerosLongitud = longitud.Split(delimitadores);

            string utm_latitud = "";
            string utm_longitud = "";
            double grados = 0;
            double minutos = 0;
            double segundos = 0;

            // -- Latitud -- \\
            grados = double.Parse(numerosLatitud[0]);
            minutos = double.Parse(numerosLatitud[1]) / 60;
            segundos = double.Parse(numerosLatitud[2]) / 3600;

            if (grados < 0) { grados *= -1; }

            utm_latitud = (grados + minutos + segundos).ToString();


            // -- Logitud -- \\
            grados = double.Parse(numerosLongitud[0]);
            minutos = double.Parse(numerosLongitud[1]) / 60;
            segundos = double.Parse(numerosLongitud[2]) / 3600;

            if (grados < 0) { grados *= -1; }

            utm_longitud = (-1 * (grados + minutos + segundos)).ToString();

            return new List<string>() { utm_latitud.Replace(",", "."), utm_longitud.Replace(",", ".") };
        }
    }
}
