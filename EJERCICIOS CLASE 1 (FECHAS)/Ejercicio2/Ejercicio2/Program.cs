using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 3.Realice un programa que solicite cuál fue el primer día del mes, por ejemplo el primer día del mes de marzo de
2022 fue un martes. Luego con esta información el sistema debe poder calcular que día será, el correspondiente a
una fecha dada. Por lo cual el sistema podría preguntar, ingrese una fecha del mes de marzo y le diré que día cae.
 */
namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaAcutal= DateTime.Now;

            Console.WriteLine("ingrese un numero para indicar que mes desea seleccionar: (ejemplo: 1 para enero)");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese un numero para indicar que año desea seleccionar:");
            int año = int.Parse(Console.ReadLine());

            DateTime fecha = new DateTime(año, mes, 01);
            
            string diaNac= fecha.ToString("yyyy/mm/dd");

            Console.WriteLine($"La becha es: {diaNac}");
            Console.WriteLine((int)fecha.DayOfWeek);
            
            
            Console.WriteLine("{0:MMM d,yyy} es el {1}", fecha.Year, fecha.Month, fecha.DayOfWeek.ToString());

            Console.WriteLine(fecha.DayOfWeek.ToString());

            Console.ReadKey();
        }
    }
}
