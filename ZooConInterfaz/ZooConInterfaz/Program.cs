using System;
using ZooConInterfaz;
/*
 Enunciado del problema:

Un zoológico desea desarrollar un sistema para gestionar sus animales y cuidadores. El sistema debe permitir la 
creación y gestión de diferentes tipos de animales, incluyendo mamíferos, aves, peces y una planta carnívora. 
Cada animal debe tener un nombre, una especie y un tipo de comida asociado. Los mamíferos deben ser capaces de 
amamantar, las aves deben poder volar y los peces deben poder nadar. Además, se requiere la capacidad de crear 
una planta carnívora que se alimente de otros seres vivos.

Los cuidadores serán responsables de alimentar a los animales. Cada cuidador debe tener un nombre y ser capaz de 
alimentar a los animales bajo su cuidado con la comida adecuada. Esto incluye tanto a los animales convencionales 
como a la planta carnívora.

El zoológico debe tener la capacidad de administrar tanto a los animales como a los cuidadores. Esto implica la 
capacidad de agregar, eliminar y actualizar la información de los animales y cuidadores. Además, el zoológico debe 
ser capaz de mostrar la lista de animales y cuidadores disponibles.

El sistema debe ser implementado en C# y ejecutarse por consola. Los alumnos deberán utilizar herencia, polimorfismo, 
interfaces y métodos virtuales para garantizar la flexibilidad y extensibilidad del sistema. Además, se debe 
implementar la inyección de dependencias para permitir que los cuidadores alimenten a cualquier tipo de animal, 
incluida la planta carnívora.
 */
namespace zoologico2_2024
{
    class Program
    {
        static void Main(string[] args)
        {

            PruebaAdministrador pr = new PruebaAdministrador();
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("1. Nueva Asignacion");
                Console.WriteLine("2. Generar Informe");
                Console.WriteLine("3. Alimentar animales");
                Console.WriteLine("4.  presentarse");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese su opción: ");
                // Leer la opción del usuario
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        pr.NuevaAsignacionCuidador();
                        break;
                    case "2":
                        pr.GenerarInforme();
                        break;
                    case "3":
                        pr.AlimentarAnimales();
                        break;
                    case "4":
                        Console.Write("Ingrese el tipo de animal (Ave, Mamifero, Pez o Planta carnivora): ");
                        string tipoAnimal = Console.ReadLine().ToLower();

                        // Recorrer todas las secciones del zoológico
                        foreach (var seccion in pr.listZoo)
                        {
                            // Recorrer todos los cuidadores de la sección
                            foreach (var cuidador in seccion.lista_cuidadores)
                            {
                                // Recorrer todos los animales asignados al cuidador
                                foreach (var animal in cuidador.animalesAsignados)
                                {
                                    // Verificar si el tipo de animal coincide con la búsqueda
                                    if (animal.GetType().Name.ToLower() == tipoAnimal)
                                    {
                                        // Presentar al animal
                                        animal.presentarse();

                                        // Realizar acciones específicas según el tipo de animal
                                        if (animal is Pez pez)
                                        {
                                            pez.Nadar();
                                        }
                                        else if (animal is Mamifero mamifero)
                                        {
                                            mamifero.Amamantar();
                                        }
                                        else if (animal is Ave ave)
                                        {
                                            ave.Volar();
                                        }
                                        else if (animal is Plantacarnivora planta)
                                        {
                                            planta.comer();
                                        }
                                    }
                                }
                            }
                        }
                        break;

                        break;
                    case "5":
                        Console.WriteLine("Salio");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Ingreso un valor incorrecto, intentelo otra vez");
                        break;
                }


            }


        }
    }
}
