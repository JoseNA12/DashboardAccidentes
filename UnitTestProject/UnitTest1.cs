using System;
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
            //DAO_Carga y DAO_SQL tienen que ser publicas para poder correr esto
            //En general cualquier clase invocada desde aqui necesita ser publica
            
            DAO_Query dao = new DAO_Query();
            dao.correrQueryIndicador("TIPO_LESION");
            dao.correrQueryIndicador("ROL_AFECTADO");
            dao.correrQueryIndicador("GENERO");
            dao.correrQueryIndicador("EDAD_QUINCENAL");
            
        }
    }
}
