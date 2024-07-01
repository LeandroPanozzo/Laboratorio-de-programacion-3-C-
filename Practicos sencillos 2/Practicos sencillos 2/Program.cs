/*
 2.Realice un programa que solicite al usuario el ingreso de un número y que le muestre los diez primeros valores de la tabla de multiplicar de ese número.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un valor");
        int.TryParse(Console.ReadLine(), out int val);

        Console.WriteLine($"Los 10 primeros valores de {val} son:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{val} * {i} = {val*i}");
        }
    }
}