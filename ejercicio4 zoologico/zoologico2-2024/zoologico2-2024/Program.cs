using System;

namespace zoologico2_2024
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal a = new Animal("Leon","Felino","Carne");
            
            Cuidador c = new Cuidador(56565);
            //c.nombre = "Pablo";
            //c.legajo = ;

            Zoologico z = new Zoologico();
            z.nuevoAnimal(a);
            z.nuevoCuidador(c);

            z.nuevoAnimal(new ave("Agila","Ave","carne"));
            z.nuevoAnimal(new Plantacarnivora("asdff", "kkdf", "carne"));
            z.nuevoAnimal(new mamifero("Elefante", "Paquidermo", "pasto"));
            z.nuevoAnimal(new mamifero("Hiena", "Hiena", "carne"));
            z.nuevoAnimal(new pez("Tiburon", "Pez", "Carne"));
            z.poblacion();

            Administrador admin = new Administrador(z.lista_animales, z.lista_cuidadores);
            admin.Asignar();

            Console.WriteLine("****************************************");

            

            foreach(var cuidador in z.lista_cuidadores)
            {
                cuidador.alimentar(z.lista_animales);
            }

            Console.WriteLine("Hello World!");




        }
    }
}
