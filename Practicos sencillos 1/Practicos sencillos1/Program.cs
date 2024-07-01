/*
 Realice un programa en c# que muestre los numeros del cero al 10 utilizando las siguientes estructuras while, do- while,for
 */
internal class Program
{
    private static void Main(string[] args)
    {
        //con while
        Console.WriteLine("while");
        int cont = 0;
        while (cont <= 10) {
            Console.WriteLine(cont);
            cont++;
        }

        //con do while
        Console.WriteLine("Do while");
        cont = 0;
        do
        {
            Console.WriteLine(cont);
            cont++;
        }while (cont <= 10);

        //con for
        Console.WriteLine("for");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}