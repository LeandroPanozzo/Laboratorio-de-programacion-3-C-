using System;
using System.Collections.Generic;
using System.Text;
using ZooConInterfaz;

namespace zoologico2_2024
{


    class Animal : IAnimal
    {
        
        public string nombre { get; set; }
        public string especie { get; set; }
        public string comida { get; set; }

        
        public Animal(string n, string e, string c)
        {
            nombre = n;
            especie = e;
            comida = c;
        }

        public void comer()
        {
            Console.WriteLine("{0}", this.comida);
        }
        virtual public void presentarse()
        {
            Console.WriteLine("{0}", this.nombre);

        }
    }

    

    

   

    


}
