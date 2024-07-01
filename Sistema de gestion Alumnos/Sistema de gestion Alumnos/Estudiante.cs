using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_Alumnos
{
    internal class Estudiante
    {
        public string nombre { get; set; }
        public int id { get; set; }

        public Estudiante()
        {
            
        }
        public Estudiante(string nom, int idd)
        {
            nombre= nom;
            id= idd;
        }
    }
}
