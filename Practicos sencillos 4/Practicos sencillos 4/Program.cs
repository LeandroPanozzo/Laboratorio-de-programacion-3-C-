/*
  4.Realice un programa que solicite el primer día de cada uno de los doce meses del año. Con esta
información podrá pedir al sistema que dada una determinada fecha el mismo le indique que día será.
El sistema también podrá responder al requerimiento que fechas caen los fines de semana de un determinado mes.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el año del que desea ver las fechas");
        int.TryParse(Console.ReadLine(), out int año);

        int mes = 1;
        
        
        for (int i = 0; i < 12; i++)
        {
            DateTime d = new DateTime(año, mes, 1);
            Console.Write(d.ToString("yyyy/ MMMM/ dd "));

            if (d.DayOfWeek == DayOfWeek.Sunday || d.DayOfWeek == DayOfWeek.Saturday) {
                Console.Write(d.DayOfWeek);
                Console.WriteLine(" Es fin de semana ");
            }
            else
            {
                Console.WriteLine(d.DayOfWeek);
            }
            
            mes++;
        }
    }
}