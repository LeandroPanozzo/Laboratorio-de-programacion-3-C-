using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooConInterfaz
{
    internal class Persona
    {
        public string nombre { get; set; }

        public Persona()
        {
            this.nombre = "Pedro";
        }

        public Persona(string n)
        {
            this.nombre = n;
        }
    }
}
