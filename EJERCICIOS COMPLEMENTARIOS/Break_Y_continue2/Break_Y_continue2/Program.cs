/*
 2. Realice un programa que retorne la suma de diez números aleatorios
cuales quiera excepto que este número generado sea múltiplo de cinco en
cuyo caso lo ignorará y continuara con las próximas iteraciones.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        Random random = new Random();

        for(int i = 0; i < 10; i++)
        {
            int randomnum;
            do
            {
                randomnum = random.Next(20);
            }while(randomnum%5==0); //creara un nuevo numero si es multiplo de 5

            sum += randomnum;

            Console.WriteLine(sum);
        }
    }
}