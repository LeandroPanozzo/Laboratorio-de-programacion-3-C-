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
        
        DateTime inicia = new DateTime(2022, 04, 08);
        int dias = 0;
        int monto = 3000*4;
        int presupuesto = 0;
        for(int i=0; i < 10; i++)
        {
            dias = i + 1;
            presupuesto += monto;
            
            
        }
        Console.Write("el proyecto se terminara el dia:");
        DateTime final = new DateTime(2022, 04, 08 + dias);
        Console.Write(final.ToString("yyyy/mm/dd "));
        Console.WriteLine(final.DayOfWeek.ToString());
        Console.WriteLine($"el presupuesto sera de: {presupuesto} al finalizar el proyecto");

        Console.ReadKey();
    }
}