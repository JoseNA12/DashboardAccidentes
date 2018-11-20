using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardAccidentes.Negocio.Iterator
{
    public interface Iterador
    {
        bool tieneSiguiente();
        object siguiente();
        int longitud();
    }
}
