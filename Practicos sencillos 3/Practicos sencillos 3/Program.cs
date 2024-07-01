/*
  3.Realice un programa que solicite cuál fue el primer día del mes, por ejemplo el primer día del mes de marzo de
2022 fue un martes. Luego con esta información el sistema debe poder calcular que día será, el correspondiente a una 
fecha dada. Por lo cual el sistema podría preguntar, ingrese una fecha del mes de marzo y le diré que día cae.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ingrese el año que desea ver");
        int.TryParse(Console.ReadLine(), out int año);
        Console.WriteLine("ingrese el mes que desea ver");
        int.TryParse(Console.ReadLine(), out int mes);

        DateTime d = new DateTime(año, mes, 01);
        string fecha = d.ToString("yyyy/MM/dd");

        Console.Write($"la fecha sera {fecha} ");
        Console.Write("y el dia: " + d.DayOfWeek);
    }
}