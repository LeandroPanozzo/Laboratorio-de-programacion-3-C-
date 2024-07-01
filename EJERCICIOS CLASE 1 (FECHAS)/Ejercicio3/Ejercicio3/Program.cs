using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  4.Realice un programa que solicite el primer día de cada uno de los doce meses del año. 
Con esta información podrá pedir al sistema que dada una determinada fecha el mismo le indique que día será.
El sistema también podrá responder al requerimiento que fechas caen los fines de semana de un determinado mes
 */
namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el año que desea ver");

            int año=int.Parse(Console.ReadLine());

            
            
            for(int i = 0; i < 12; i++)
            {
                int mes = i + 1;
                DateTime fecha =new DateTime (año, mes, 1);
                Console.Write(fecha.ToString("yyyy/M/d") );
                Console.WriteLine(fecha.DayOfWeek.ToString());
            }

            Console.ReadKey();
        }
    }
}
