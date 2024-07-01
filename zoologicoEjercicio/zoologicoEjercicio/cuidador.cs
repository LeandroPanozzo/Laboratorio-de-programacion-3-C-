using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologicoEjercicio
{
    internal class cuidador
    {
        public string nombre { get; set; }

        public void alimentar(List<Animal> l)
        {
            foreach (Animal item in l)
            {
                Console.WriteLine("el {0} come {1}", item.nombre, item.comida);
            }
        }
    }
}
