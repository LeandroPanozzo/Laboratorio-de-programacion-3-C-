using System;
using System.Collections.Generic;
using System.Text;

namespace zoologico2_2024
{
    class Zoologico
    {
        public List<IAnimal> lista_animales = new List<IAnimal>();
        public List<Cuidador> lista_cuidadores = new List<Cuidador>();

        public void nuevoCuidador(Cuidador cuidador) 
        {
            lista_cuidadores.Add(cuidador);
        }

        public void nuevoAnimal(Animal animal) {

            lista_animales.Add(animal);
        }


        public void poblacion() {

            foreach (var item in lista_animales)
            {
                item.presentarse();
            }
        }

    }
}
