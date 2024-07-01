using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooConInterfazGrafica
{
    internal class ListaAnimales
    {
        public string nombre { get; set; }
        public string tipo { get; set; }

        public string comida { get; set; }
        public ListaAnimales(string nom, string tip, string comi)
        {
            this.nombre = nom;
            this.tipo = tip;
            this.comida = comi;
        }
    }
}
