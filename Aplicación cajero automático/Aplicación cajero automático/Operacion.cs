using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_cajero_automático
{
    internal class Operacion
    {
        public DateTime fecha { get; set; }
        public int numCajero { get; set; }
        public int monto { get; set; }
        public string tipoOperacion { get; set; }

        public Operacion(DateTime a, int b, int c, string d)
        {
            fecha = a;
            numCajero = b;
            monto = c;
            tipoOperacion = d;
        }
    }
}
