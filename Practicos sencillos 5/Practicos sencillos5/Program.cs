/*
  5.Se agrega el nuevo requerimiento al sistema de fechas. Se espera que pueda arrojar el monto de un presupuesto
para desarrollo considerando la siguiente información. La hora de desarrollo será de $3000, el programador trabajará
4 horas por día en el proyecto. Él estimo terminar con la incidencia 10 días habiles, comenzando el 8 de abril de
2022.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        int precioXdia = 0;
        int dia = 8;
        int horas = 4;
        int desarrollo = 3000;
        DateTime d = new DateTime(2022, 4, dia);
        for (int i = 0; i < 10; i++)
        {
            
            precioXdia += desarrollo * horas;
            horas += 4;
            
            d=d.AddDays(1);
        }

        Console.WriteLine($"el costo del proyecto sera de: ${precioXdia}");
        Console.WriteLine("se lo terminara para el dia: ");
        Console.Write(d.ToString("yyyy / MM / dddd "));
        
    }
}