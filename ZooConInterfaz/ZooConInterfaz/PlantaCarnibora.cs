using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico2_2024;

namespace ZooConInterfaz
{
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
