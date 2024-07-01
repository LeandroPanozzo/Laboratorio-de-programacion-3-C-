/*
 1. Realice una aplicación que solicite el ingreso de los parámetros m y b de la
siguiente función lineal f(x) = mx + b. Utilice métodos para fraccionar el
comportamiento del programa. Devuelva los primeros 10 valores de f(x).
Determine si la función ingresada es creciente o decreciente
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ingrese el valor de m");
        int m=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el valor de b");
        int b = int.Parse(Console.ReadLine());

        funcion(m, b);
    }

    public static void funcion(int m, int b) //debe ser static  para poder llamarlo desde otro método static como Main es porque los métodos static pertenecen a la clase en sí misma, en lugar de pertenecer a una instancia específica de la clase.
    { //En tu caso, si quitas la palabra clave static del método funcion, no podrás llamarlo directamente desde Main, porque Main también es static y estático puede acceder solo a miembros estáticos de la clase.
        int func = 0;
        for(int i = 0; i < 10; i++)
        {
            func=(m*i)+b;
            Console.WriteLine(func);
            
        }
        if ((m * 1 + b) < (m * 10 + b))
        {
            Console.WriteLine("la funcion es creciente");
        }
        else
        {
            if ((m * 1 + b) > (m * 10 + b))
            {
                Console.WriteLine("la funcion es decreciente");
            }
            else
            {
                Console.WriteLine("la funcion es constante");
            }
        }
    }
}