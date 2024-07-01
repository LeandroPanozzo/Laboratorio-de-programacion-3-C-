using System;
using System.Collections.Generic;
using System.Text;
using ZooConInterfaz;

namespace zoologico2_2024
{
    class Zoologico
    {
        public string AdminCuid { get; set; }
        public List<Animal> lista_animales = new List<Animal>();
        public List<Cuidador> lista_cuidadores = new List<Cuidador>();

        public Zoologico()
        {
                
        }

        public Zoologico(string adminCui)
        {
            AdminCuid = adminCui;
        }
        public void agregarCuidador(int leg, string nom)
        {
            Cuidador cui = new Cuidador(leg, nom);
            lista_cuidadores.Add(cui);
        }

        public void agregarAnimal(string nom, string especie, string comida)
        {
            Animal ani= new Animal(nom,especie,comida);
            lista_animales.Add(ani);
        }
        public void agregarAnimal(Animal ani)
        {
            
            lista_animales.Add(ani);
        }

        public void poblacion()
        {

            foreach (var item in lista_animales)
            {
                item.presentarse();
            }
        }

    }
}
