using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoologicoEjercicio
{
    internal class Zoo
    {
        public List<Animal> list_animal = new List<Animal>();
        public List<cuidador> list_cuidador = new List<cuidador>();

        public void nuevoCuidador(cuidador cuid)
        {
            list_cuidador.Add(cuid);
        }

        public void nuevoAnumal(Animal ani)
        {
            list_animal.Add(ani);
        }

        public void poblacion()
        {
            foreach (Animal item in list_animal)
            {
                Console.WriteLine(item.nombre);
            }
        }
    }
}
