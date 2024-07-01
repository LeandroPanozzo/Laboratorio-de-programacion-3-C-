using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_Alumnos
{
    internal class Clase
    {
        public enum clases { TERMODINAMICA, FISICA, ALGEBRA , ESTADISTICA}
        public string nombre { get; set; }
        
        public int codigo { get; set; }
        public List<Estudiante> estudiantes { get; set; } = new List<Estudiante>();
        public List<profesor> list_profe { get; set; } = new List<profesor>();
        public Clase()
        {
            
        }
        
        public Clase(string nom, int codig)
        {
            nombre = nom;
            codigo = codig;
            
        }

        public void agregarEst(string est, int id)
        {
            Estudiante estu = new Estudiante(est,id);
            estudiantes.Add(estu);
            
        }

        public void agregarProfesor(string prof)
        {
            profesor profe = new profesor(prof);
            list_profe.Add(profe);

        }
    }
}
