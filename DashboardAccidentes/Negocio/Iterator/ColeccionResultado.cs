using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio.Iterator
{
    public class ColeccionResultado : Coleccion
    {
        private static readonly int tope = 90000;
        private int numeroResultados = 0;
        private ResultadoDinamica[] resultados;

        public ColeccionResultado()
        {
            resultados = new ResultadoDinamica[tope];
        }

        public void addResultado(string accidentes, string latitud, string longitud)
        {
            ResultadoDinamica miResultado = new ResultadoDinamica();

            if (numeroResultados >= tope)
            {
                Array.Resize(ref resultados, 1); // Incremento en 1 el tamaño
            }

            miResultado.setAccidentes(accidentes);
            miResultado.setLatitud(latitud);
            miResultado.setLongitud(longitud);

            resultados[numeroResultados] = miResultado;
            numeroResultados += 1;

            // en caso de ser necesario agregar más
        }

        public Iterador crearIterador()
        {
            return new IteradorResultado(resultados);
        }
    }
}
