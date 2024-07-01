using System;
using System.Collections.Generic;
using System.Text;

namespace zoologico2_2024
{
    interface IAnimal
    { void comer();
        void presentarse();
    }


    class Animal: IAnimal
    {
        public string nombre { get; set; }
        public string especie { get; set; }
        public string comida { get; set; }

        public Animal(string n,string e,string c)
        {
            nombre = n;
            especie = e;
            comida = c;
        }

        public void comer()
        {
            Console.WriteLine("{0}",this.comida);
        }
        virtual public void presentarse()
        {
            Console.WriteLine("{0}",this.nombre);

        }
    }

    class mamifero:Animal
    {
        public mamifero(string n,string e,string c)
            :base(n,e,c)
        {

        }
        public void Amamantar()
        {
            Console.WriteLine("{0} puede amamantar",this.nombre);
        }

        public override void presentarse()
        {
            this.Amamantar();
        }
    }

    class ave : Animal
    {
        public ave(string n, string e, string c)
              : base(n, e, c)
        {

        }

        public override void presentarse()
        {
            this.Volar();
        }

        public void Volar()
        {
            Console.WriteLine("{0} vuela como un ave",this.nombre);
        }

    }

    class pez :Animal
    {
        public pez(string n, string e, string c)
            : base(n, e, c)
        {

        }

        public override void presentarse()
        {
            this.Nadar();
        }
        public void Nadar()
        {
            Console.WriteLine("{0} nada como un pez",this.nombre);
        }
    }

    class Plantacarnivora : Animal
    {
        public Plantacarnivora(string n, string e, string c)
            : base(n, e, c)
        {

        }

        public override void presentarse()
        {
            base.presentarse();
        }

        public void comer()
        {
            Console.WriteLine("{0} nada como una planta carnivora", this.nombre);
        }
    }



}
