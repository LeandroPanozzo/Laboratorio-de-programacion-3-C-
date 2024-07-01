using System;
using System.Collections.Generic;
using System.Text;
using ZooConInterfaz;

namespace zoologico2_2024
{


    class Cuidador: Persona
    {
        public int legajo { get; set; }
        public List<Animal> animalesAsignados; //Esto significa que la lista puede contener cualquier objeto que
                                                //implemente la interfaz IAnimal, no solo objetos de la clase Animal,
                                                //sino también cualquier otra clase que implemente la interfaz IAnimal.
                                                //Esto brinda más flexibilidad en el diseño y permite una mayor variedad
                                                //de implementaciones de animales en el futuro sin tener que modificar
                                                //el código de la clase Cuidador.
        public Cuidador(int l, string n) //para que tome como parametro el nombre en la clase zoologico
            : base(n)
        {
            this.legajo = l;
            this.animalesAsignados = new List<Animal>();// Inicializa la lista de animales asignados como una nueva lista vacía lo mismo que hago con legajo
        }

        public void asignarAnimal(Animal animal)
        {
            this.animalesAsignados.Add(animal);// Agrega el animal pasado como argumento a la lista de animales asignados al cuidador
        }

        public void alimentar(List<Animal> L)
        {
            Console.WriteLine("{0} es el cuidador, su legajo es:{1}", this.nombre, this.legajo);
            foreach (var item in L)
            {
                Console.WriteLine("El {0} come {1}", item.nombre, item.comida);
            }
        }
    }
    
}
