using DashboardAccidentes.Negocio.Iterator;
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
            string nombre_columna = dt.Columns[0].ColumnName;

            //Solo se procesan las consultas a nivel de provincia y canton
            if (!nombre_columna.Equals("nombre_distrito") && !nombre_columna.Equals("latitud")) 
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

        public ColeccionResultado realizarConsulta(QueryDinamica query) //TODO no se si vamos a pasarle el query por un dto o por parametros separados
        {
            DAO_Query dao = new DAO_Query();
            DataTable datos = procesarResultadosQuery(dao.correrQueryDinamico(query));

            //List<ResultadoDinamica> info = new List<ResultadoDinamica>();

            //--
            ColeccionResultado resultados = new ColeccionResultado();
            //--

            foreach (DataRow row in datos.Rows) // nombre_[provincia|canton|distrito], latitud, longitud, Accidentes
            {
                //--
                resultados.addResultado
                    (
                    row["Accidentes"].ToString(),
                    convertirCoordenada(row["latitud"].ToString()),
                    convertirCoordenada(row["longitud"].ToString())
                    );
                //--

                /*ResultadoDinamica miResultado = new ResultadoDinamica();
                //resultado.setProvincia(row["nombre_provincia"].ToString());
                //resultado.setCanton(row["nombre_canton"].ToString());
                //resultado.setDistrito(row["nombre_distrito"].ToString());
                miResultado.setLatitud(convertirCoordenada(row["latitud"].ToString()));
                miResultado.setLongitud(convertirCoordenada(row["longitud"].ToString()));
                miResultado.setAccidentes(row["Accidentes"].ToString());

                info.Add(miResultado);*/
            }

            return resultados;
        }

        private string convertirCoordenada(string coordenada)
        {
            /*
               Las coordenadas vienen así: -81°53'24"
               El primer número son grados, el segundo minutos y el tercero segundos 
               La coordenada en decimales es así:
               c = grados + (minutos/60) + (segundos / 3600) 
               Pero los grados tienen que estar positivos, si es negativo nada más es de multiplicar por -1 
               los grados, hacer el cálculo y multiplicar por -1 el resultado
            */

            char[] delimitadores = { '°', '\'', '"' };
            string[] numerosCoordenada = coordenada.Split(delimitadores);
            string utm_coordenada = "";
            bool gradosNegativo = false;
            double grados = 0;
            double minutos = 0;
            double segundos = 0;

            grados = double.Parse(numerosCoordenada[0]);
            minutos = double.Parse(numerosCoordenada[1]) / 60;
            segundos = double.Parse(numerosCoordenada[2]) / 3600;

            if (grados < 0)
            {
                grados *= -1;
                gradosNegativo = true;
            }

            if (gradosNegativo)
            {
                utm_coordenada = (-1 * (grados + minutos + segundos)).ToString();
            }
            else
            {
                utm_coordenada = ((grados + minutos + segundos)).ToString();
            }

            return utm_coordenada.Replace(",", ".");
        }
    }
}
