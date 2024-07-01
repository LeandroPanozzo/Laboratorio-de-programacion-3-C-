using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_Alumnos
{
    internal class Universidad
    {
        string nom;
        string curso;
        string nameProfe;
        /*
         La lista list_clase contiene instancias de la clase Clase, y cada instancia de Clase tiene su propia
        lista de estudiantes. Entonces, podrías decir que cada elemento en list_clase representa una clase
        en particular, y dentro de cada clase, hay una lista de estudiantes inscritos en esa clase
        list_clase no contiene directamente la lista de estudiantes, pero cada elemento dentro de list_clase
        (es decir, cada objeto de la clase Clase) tiene su propia lista de estudiantes asociada a ella.
         */
        List<Clase> list_clase = new List<Clase>();


        Clase cl = new Clase();
        int proximoEstu=1;
        int codigoClass = 1;
        public void NuevaClase(string nom)
        {
            Clase cl = new Clase(nom, codigoClass);
            
            list_clase.Add(cl);
            codigoClass++;
        }

        public void CrearCuenta()
        {
            Console.WriteLine("ingrese el nombre del alumno");
            nom = Console.ReadLine();
            if(!string.IsNullOrEmpty(nom))
            {

                cl.agregarEst(nom, proximoEstu);
                Console.WriteLine($"Estudiante {nom} agregado, su id es : {proximoEstu}");
                proximoEstu++;
            }
            else
            {
                Console.WriteLine("ingreso una opcion incorrecta");
                return;
            }

            Console.WriteLine("ingrese que curso decide inscribirse:");

            foreach(Clase.clases item in Enum.GetValues(typeof(Clase.clases)))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Escriba la opcion");
            curso = Console.ReadLine().ToUpper();

            if (!Enum.IsDefined(typeof(Clase.clases), curso))
            {
                Console.WriteLine("Ha ingresado una opción incorrecta.");
                return;
            }
            //FirstOrDefault Este método se utiliza para buscar el primer elemento en una secuencia que cumpla con una condición específica 
            //c => c.nombre.ToUpper() == curso Esta expresión lambda se utiliza como un predicado para filtrar los elementos de la secuencia list_clase
            //c: es el parámetro de entrada que representa cada elemento de la secuencia list_clase durante la iteración.
            //c.nombre.ToUpper(): accede a la propiedad nombre de cada objeto Clase y convierte su valor a mayúsculas utilizando el método ToUpper()
            //== curso: compara el nombre de la clase (convertido a mayúsculas) con el valor de la variable curso, que es el nombre del curso ingresado por el usuari
            
            Clase claseSeleccionada = list_clase.FirstOrDefault(c => c.nombre.ToUpper() == curso);
            
            //Cuando hablamos de la instanciación de una clase a null, estamos hablando de que una variable de tipo de
            //referencia (es decir, una variable que almacena una referencia a un objeto en la memoria) no está
            //apuntando a ninguna instancia válida de esa clase, sino que está apuntando a la referencia nula (null).
            if (claseSeleccionada == null)
            {
                // Si no existe la clase, crear una nueva
                //Es importante verificar si un objeto es null antes de intentar acceder a sus
                //miembros, especialmente si no estás seguro de si ha sido inicializado correctamente.
                NuevaClase(curso);
                claseSeleccionada = list_clase.FirstOrDefault(c => c.nombre.ToUpper() == curso);
            }

            // Agregar el estudiante a la clase seleccionada
            claseSeleccionada.agregarEst(nom, proximoEstu);
            Console.WriteLine($"Se ha inscrito al alumno {nom} al curso {curso}. Su ID es: {proximoEstu}");

            proximoEstu++;
        }

        public void AgregarProfe()
        {
            Console.WriteLine("Ingrese el nombre del profesor que desea agregar:");
            string nombreProfesor = Console.ReadLine();

            if (string.IsNullOrEmpty(nombreProfesor))
            {
                Console.WriteLine("Ha ingresado una opción incorrecta.");
                return;
            }

            Console.WriteLine("Ingrese el curso al que desea inscribir al profesor:");

            foreach (Clase.clases item in Enum.GetValues(typeof(Clase.clases)))
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Escriba la opción:");
            string cursoIngresado = Console.ReadLine().ToUpper();

            if (!Enum.IsDefined(typeof(Clase.clases), cursoIngresado))
            {
                Console.WriteLine("Ha ingresado una opción incorrecta.");
                return;
            }

            // Buscar la clase correspondiente al curso ingresado
            //Si la secuencia está vacía o no se encuentra ningún elemento que cumpla con la condición,
            //FirstOrDefault devuelve el valor predeterminado para el tipo de elemento (null para tipos de referencia, 0 para números enteros, false para booleanos, etc.)
            //entonces si no existe la clase claseSeleccionada sera null
            Clase claseSeleccionada = list_clase.FirstOrDefault(c => c.nombre.ToUpper() == cursoIngresado);

            if (claseSeleccionada == null)
            {
                Console.WriteLine("El curso ingresado no existe. Por favor, cree el curso antes de agregar un profesor.");
                return;
            }

            // Agregar al profesor a la clase seleccionada
            claseSeleccionada.agregarProfesor(nombreProfesor);
            Console.WriteLine($"Profesor {nombreProfesor} agregado al curso {cursoIngresado}.");
        }


        public void MostrarTodo()
        {
            foreach (var clase in list_clase)
            {
                Console.WriteLine($"Clase: {clase.nombre}");

                Console.WriteLine("Estudiantes inscritos:");
                foreach (var estudiante in clase.estudiantes)
                {
                    Console.WriteLine($"Nombre: {estudiante.nombre}, ID: {estudiante.id}");
                }
                Console.WriteLine("Profesores de la materia:");
                foreach (var profesor in clase.list_profe)
                {
                    Console.WriteLine($"Nombre: {profesor.nombre}");
                }

                Console.WriteLine(); // Agrega un salto de línea entre cada clase
            }

        }

        public void mostarPorMateria()
        {
            Console.WriteLine("Ingrese el curso que desea ver:");

            foreach (Clase.clases item in Enum.GetValues(typeof(Clase.clases)))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Escriba la opción:");
            string cursoSeleccionado = Console.ReadLine().ToUpper();

            if (Enum.IsDefined(typeof(Clase.clases), cursoSeleccionado))
            {
                // Buscar la clase correspondiente al curso ingresado
                Clase claseSeleccionada = list_clase.FirstOrDefault(c => c.nombre.ToUpper() == cursoSeleccionado);

                if (claseSeleccionada != null)
                {
                    Console.WriteLine($"Clase: {claseSeleccionada.nombre}");

                    Console.WriteLine("Estudiantes inscritos:");
                    foreach (var estudiante in claseSeleccionada.estudiantes)
                    {
                        Console.WriteLine($"Nombre: {estudiante.nombre}, ID: {estudiante.id}");
                    }

                    Console.WriteLine("Profesores de la materia:");
                    foreach (var profesor in claseSeleccionada.list_profe)
                    {
                        Console.WriteLine($"Nombre: {profesor.nombre}");
                    }

                    Console.WriteLine(); // Agrega un salto de línea entre cada clase
                }
                else
                {
                    Console.WriteLine("No hay estudiantes inscritos en este curso.");
                }
            }
            else
            {
                Console.WriteLine("Ha ingresado una opción incorrecta.");
            }
        }

    }
}
