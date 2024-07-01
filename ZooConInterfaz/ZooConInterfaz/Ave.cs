using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico2_2024;

namespace ZooConInterfaz
{
    class Ave : Animal
    {
        public Ave(string n, string e, string c)
              : base(n, e, c)
        {

        }

        public override void presentarse()
        {
            this.Volar();
        }

        public void Volar()
        {
            Console.WriteLine("{0} vuela como un ave", this.nombre);
        }

    } 
}
