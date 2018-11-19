using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio
{
    public class Indicador
    {
        public string indicador { get; private set; }
        public string valor { get; private set; }

        public Indicador(string indicador, string valor)
        {
            this.indicador = indicador;
            this.valor = valor;
        }
    }
}
