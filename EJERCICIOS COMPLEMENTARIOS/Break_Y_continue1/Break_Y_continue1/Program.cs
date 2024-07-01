/*
 1. Realice un programa que retorne diez números aleatorios cuales quiera
excepto que este número generado sea múltiplo de cinco en cuyo caso
deberá cortar la ejecución del programa de inmediato
 */
internal class Program
{
    private static void Main(string[] args)
    {
        for(int i=0; i<10; i++)
        {
            Random random = new Random();
            int alea=random.Next(20);
            if(alea%5==0)
            {
                Console.WriteLine("ejecucion cortada");
                break;

            }
            else
            {
                Console.WriteLine(alea);
            }
        } 
    }
}