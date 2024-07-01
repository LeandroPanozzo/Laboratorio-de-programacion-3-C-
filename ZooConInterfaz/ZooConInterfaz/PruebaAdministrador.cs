using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zoologico2_2024;

namespace ZooConInterfaz
{
    internal class PruebaAdministrador
    {
        public string animalNom { get; set; }
        public string animalespecie { get; set; }
        public string animalcomida { get; set; }
        public string seleccion { get; set; }
        public List<Zoologico> listZoo;
        Zoologico z = new Zoologico();
        public string nomCuid { get; set; }

        public PruebaAdministrador()
        {
            listZoo=new List<Zoologico>();
        }
        public void nuevaAdministracion(string nomCuid)
        {
            Zoologico zoologico = new Zoologico(nomCuid);
            listZoo.Add(zoologico);
        }
        public void NuevaAsignacionCuidador()
        {
            Console.WriteLine("Ingrese el nombre del Cuidador");
            nomCuid = Console.ReadLine();

            Console.WriteLine("Ingrese el legajo del cuidador");
            int legajo;
            if (!int.TryParse(Console.ReadLine(), out legajo))
            {
                Console.WriteLine("Ingreso un legajo inválido");
                return;
            }

            if (string.IsNullOrEmpty(nomCuid))
            {
                Console.WriteLine("Ingreso una opción incorrecta");
                return;
            }

            z.agregarCuidador(legajo, nomCuid);

            Console.WriteLine("Ingrese el nombre de la sección que se encargará el Cuidador");
            seleccion = Console.ReadLine().ToLower();

            if (string.IsNullOrEmpty(seleccion))
            {
                Console.WriteLine("Ingreso una opción incorrecta");
                return;
            }

            Zoologico selectt = listZoo.FirstOrDefault(c => c.AdminCuid.ToLower() == seleccion.ToLower());

            if (selectt == null)
            {
                //si no existe el zoológico se lo crea
                nuevaAdministracion(seleccion);
                selectt = listZoo.FirstOrDefault(c => c.AdminCuid.ToLower() == seleccion.ToLower());
            }

            selectt.agregarCuidador(legajo, nomCuid);
            Console.WriteLine($"Se ha agregado al cuidador {nomCuid} Su ID es: {legajo}");

            
            //AGREGAR ANIMALES EN LA LISTA DEL CUIDADOR
            Console.WriteLine("Ingrese el numero del tipo de animal a agregar:");
            Console.WriteLine("1. Pez");
            Console.WriteLine("2. Mamífero");
            Console.WriteLine("3. Ave");
            Console.WriteLine("4. Planta carnivora");
            Console.Write("Opción: ");
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción inválida.");
                return;
            }

            Console.WriteLine("Ingrese el nombre del animal:");
            animalNom = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la especie:");
            animalespecie = Console.ReadLine();
            Console.WriteLine("Ingrese la comida del animal:");
            animalcomida = Console.ReadLine();

            Animal nuevoAnimal;
            switch (opcion)
            {
                case 1:
                    nuevoAnimal = new Pez(animalNom, animalespecie, animalcomida);
                    break;
                case 2:
                    nuevoAnimal = new Mamifero(animalNom, animalespecie, animalcomida);
                    break;
                case 3:
                    nuevoAnimal = new Ave(animalNom, animalespecie, animalcomida);
                    break;
                case 4:
                    nuevoAnimal = new Plantacarnivora(animalNom, animalespecie, animalcomida);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            z.agregarAnimal(nuevoAnimal);

            Console.WriteLine("Ingrese el lugar donde desea ubicar al animal");
            foreach (var item in listZoo)
            {
                Console.WriteLine($"Sección: {item.AdminCuid}");
                Console.WriteLine("Cuidadores en la sección:");
                foreach (var item2 in item.lista_cuidadores)
                {
                    Console.WriteLine($"Nombre: {item2.nombre} Legajo: {item2.legajo}");
                }
            }

            string eleccion = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(eleccion))
            {
                Console.WriteLine("Ha ingresado una opción incorrecta.");
                return;
            }

            //buscar la sección buscada conforme a la elección ingresada
            Zoologico selecct = listZoo.FirstOrDefault(c => c.AdminCuid.ToLower() == eleccion.ToLower());

            if (selecct != null)
            {
                foreach (Cuidador c in selecct.lista_cuidadores)
                {
                    c.asignarAnimal(nuevoAnimal);
                    Console.WriteLine($"El animal {animalNom} ha sido asignado al cuidador {c.nombre} con legajo {c.legajo}.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("La sección ingresada no existe.");
            }
        }

        public void GenerarInforme()
        {

            foreach (var item in listZoo)
            {
                Console.WriteLine($"Secciones: {item.AdminCuid}");

                Console.WriteLine("Cuidadores en la seccion: ");
                foreach (var item2 in item.lista_cuidadores)
                {
                    Console.WriteLine($"cuidador: {item2.nombre}");
                    Console.WriteLine("Animales a su cargo:");
                    foreach (var animal in item2.animalesAsignados)
                    {
                        Console.WriteLine($"- Animal: {animal.nombre}, especie: {animal.especie}, alimento: {animal.comida}");
                    }
                    Console.WriteLine();

                }
                
                Console.WriteLine();
            }
        }
        public void AlimentarAnimales()
        {
            foreach (var item in listZoo)
            {

                Console.WriteLine($"Secciones: {item.AdminCuid}");

                foreach (var cuidador in item.lista_cuidadores)
                {
                    Console.WriteLine($"Alimentando animales a cargo de {cuidador.nombre} legajo: {cuidador.legajo}");
                    cuidador.alimentar(cuidador.animalesAsignados);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

    }
}
