using System;
using System.Collections.Generic;
using System.Text;

namespace zoologico2_2024
{


    class persona {
        public string nombre { get; set; }

        public persona()
        {
           this.nombre = "Pedro";
        }

        public persona(string n)
        {
            this.nombre = n;
        }
    }



    class Cuidador:persona
    {
        public int legajo { get; set; }
        private List<IAnimal> animalesAsignados //Esto significa que la lista puede contener cualquier objeto que
                                                //implemente la interfaz IAnimal, no solo objetos de la clase Animal,
                                                //sino también cualquier otra clase que implemente la interfaz IAnimal.
                                                //Esto brinda más flexibilidad en el diseño y permite una mayor variedad
                                                //de implementaciones de animales en el futuro sin tener que modificar
                                                //el código de la clase Cuidador.
        public Cuidador(int l)
            : base()
        {
            this.legajo = l;
            this.animalesAsignados= new List<IAnimal> ();// Inicializa la lista de animales asignados como una nueva lista vacía lo mismo que hago con legajo
        }

        public void asignarAnimal(IAnimal animal)
        {
            this.animalesAsignados.Add(animal);// Agrega el animal pasado como argumento a la lista de animales asignados al cuidador
        }
        
        public void alimentar(List<Animal> L)
        {
            Console.WriteLine("{0} es el cuidador, su legajo es:{1}",this.nombre,this.legajo);
            foreach (var item in L)
            {
                Console.WriteLine("El {0} come {1}",item.nombre,item.comida);
            }
        }
    }
    class Administrador : persona
    {
        
        private List<Cuidador> listCuidador;
        public void informe()
        {
            Console.WriteLine("generara un infome");
        }
        public Administrador( List<Cuidador> cuidadores)
        {
            
            listCuidador = cuidadores;
        }
        public void Asignar(List<IAnimal> listaAnimal)
        {
            int i = 0;
            foreach (var animal in listaAnimal)
            {
                listCuidador[i].asignarAnimal(animal);
                i=(i+1)%listCuidador.Count;// Asignar a cada cuidador de forma cíclica
            }
        }
    }
}
