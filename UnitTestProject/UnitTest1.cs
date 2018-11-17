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
                new Indicador("Tipo lesion", "Muerte"),
                new Indicador("Genero", "Mujer")
            };

            Localizaciones localizaciones = new Localizaciones(provincias, cantones, distritos);
            QueryDinamica queryDinamica = new QueryDinamica(provincias, cantones, distritos, 2012, 2014, indicadores);
            TipoLesion tipoLesionDecorador = new TipoLesion(queryDinamica, queryDinamica.indicadores);
            Genero generoDecorador = new Genero(tipoLesionDecorador, tipoLesionDecorador.indicadores);

            string query = generoDecorador.construirConsulta();


            //string query = queryDinamica.construirConsulta();



            //string columna = localizaciones.obtenerColumnaSelect();
            //string query_str = localizaciones.ToQueryString();
        }
    }
}
