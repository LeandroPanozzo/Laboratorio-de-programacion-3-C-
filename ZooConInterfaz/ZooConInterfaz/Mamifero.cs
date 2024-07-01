using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico2_2024;

namespace ZooConInterfaz
{
    class Mamifero : Animal
    {
        public Mamifero(string n, string e, string c)
            : base(n, e, c)
        {

        }
        public void Amamantar()
        {
            Console.WriteLine("{0} puede amamantar", this.nombre);
        }

        public override void presentarse()
        {
            this.Amamantar();
        }
    }
}
