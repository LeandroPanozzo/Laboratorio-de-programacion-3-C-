using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologicoEjercicio
{
    internal class Animal
    {
        public string nombre { get; set; }
        public string especie { get; set; }

        public string comida { get; set; }

        public Animal(string a, string d, string c)
        {
            nombre = a;
            especie = d;
            comida = c;
        }
    }
}
