using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico2_2024;

namespace ZooConInterfaz
{
    class Pez : Animal
    {
        public Pez(string n, string e, string c)
            : base(n, e, c)
        {

        }

        public override void presentarse()
        {
            this.Nadar();
        }
        public void Nadar()
        {
            Console.WriteLine("{0} nada como un pez", this.nombre);
        }
    }
}
