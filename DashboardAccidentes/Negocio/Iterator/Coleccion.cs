using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Basado en el ejemplo de: https://www.geeksforgeeks.org/iterator-pattern/

namespace DashboardAccidentes.Negocio.Iterator
{
    interface Coleccion
    {
        Iterador crearIterador();
    }
}
