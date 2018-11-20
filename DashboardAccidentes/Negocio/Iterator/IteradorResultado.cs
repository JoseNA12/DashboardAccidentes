using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio.Iterator
{
    class IteradorResultado : Iterador
    {
        private ResultadoDinamica[] resultados;
        private int posicion = 0;

        public IteradorResultado(ResultadoDinamica[] resultados)
        {
            this.resultados = resultados;
        }

        public bool tieneSiguiente()
        {
            if (posicion >= resultados.Length || resultados[posicion] == null) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object siguiente()
        {
            ResultadoDinamica resultado = resultados[posicion];
            posicion += 1;
            return resultado;
        }

        public int longitud()
        {
            return resultados.Length;
        }
    }
}
