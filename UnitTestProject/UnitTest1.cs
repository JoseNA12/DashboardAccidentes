using System;
using System.Collections.Generic;
using DashboardAccidentes.Negocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var provincias = new List<string>()
            {
                "San José"
            };
            var cantones = new List<string>()
            {
                "Curridabat"
            };
            var distritos = new List<string>()
            {
                "Curridabat",
                "Granadilla",
                "Tirrases"
            };

            List<Indicador> indicadores = new List<Indicador>()
            {
                new Indicador("Tipo lesion", "Ileso"),
                new Indicador("Genero", "Hombre"),
                new Indicador("Rol afectado", "Conductor")
            };

            Localizaciones localizaciones = new Localizaciones(provincias, cantones, distritos);
            QueryDinamica queryDinamica = new QueryDinamica(provincias, cantones, distritos, 2012, 2014, indicadores);

            new Handler_Mapas().realizarConsulta(queryDinamica);

            //DAO_Query dAO = new DAO_Query();
            //var dt = dAO.correrQueryDinamico(queryDinamica);
            //TipoLesion tipoLesionDecorador = new TipoLesion(queryDinamica, queryDinamica.indicadores);
            //Genero generoDecorador = new Genero(tipoLesionDecorador, tipoLesionDecorador.indicadores);
            //EdadQuincenal edadQuincenal = new EdadQuincenal(generoDecorador, generoDecorador.indicadores);
            //TipoAfectado tipoAfectado = new TipoAfectado(edadQuincenal, edadQuincenal.indicadores);

            //string query = tipoAfectado.construirConsulta();
            //query = query.Replace(" AND {4}", "");


            //string query = queryDinamica.construirConsulta();



            //string columna = localizaciones.obtenerColumnaSelect();
            //string query_str = localizaciones.ToQueryString();
        }
    }
}
