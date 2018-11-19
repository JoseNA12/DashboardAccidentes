using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Vista
{
    public static class TratarEnum
    {
        // Una vez recibidos los nombres de los enum's, tratar los strings para ser mostrador en pantalla
        public static List<string> DarFormatoEnumIndicador(List<string> pIndicadores)
        {
            List<string> indicadores = new List<string>();

            for (int i = 0; i < pIndicadores.Count; i++)
            {
                indicadores.Add(pIndicadores[i].Replace("_", " "));
            }
            return indicadores;
        }

        // Para cuando envio al controlador el indicador que seleccioné, enviarle el mismo nombre "original" del enum como tal
        public static string FormatearEnumIdicadores(string pIndicador)
        {
            return pIndicador.Replace(" ", "_");
        }
    }
}
