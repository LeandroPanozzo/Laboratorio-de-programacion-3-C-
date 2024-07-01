/*
 1. Desarrolle un programa que solicite al usuario la carga de un arreglo de 10
elementos. El programa tendrá un menú para dar las opciones de cargar
arreglo mostrar el arreglo, calcular el promedio, mostrar el máximo y
mostrar el mismo del arreglo de números.
 */
internal class Program
{
    private static void Main(string[] args)
    {
        int[] elemnt = new int[10];

        int opciones;

        Console.WriteLine("Elija una opcion");
        Console.WriteLine("1- cargar arreglo");
        Console.WriteLine("2- mostrar arreglo");
        Console.WriteLine("3- calcular promedio");
        Console.WriteLine("4- mostrar maximo");
        Console.WriteLine("5- mostrar minimo");
        Console.WriteLine("6- salir");

        opciones = int.Parse(Console.ReadLine());

        while (opciones != 6)
        {
            switch (opciones)
            {
                case 1:
                    Console.WriteLine("Ingrese los numeros");
                    for (int i = 0; i < 10; i++)
                    {
                        int valor = int.Parse(Console.ReadLine());
                        elemnt[i] = valor;
                    }
                    break;

                case 2:
                    Console.WriteLine("los elemntos del arreglo son");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(elemnt[i]);
                    }
                    break;

                case 3:
                    Console.WriteLine("el promedio sera: ");
                    int resultado = 0, promedio = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        resultado += elemnt[i];

                    }
                    promedio = resultado / elemnt.Length;
                    Console.WriteLine(promedio);
                    break;

                case 4:
                    Console.WriteLine("El numero maximo sera: ");
                    int val = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        val = elemnt.Max();
                    }
                    Console.WriteLine(val);
                    break;

                case 5:
                    Console.WriteLine("El numero minimo sera: ");
                    int v = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        v = elemnt.Min();
                    }
                    Console.WriteLine(v);
                    break;

                case 6:
                    Console.WriteLine("salio del sistema");
                    break;

                default:
                    Console.WriteLine("selecciono ub valor incorrecto");
                    break;
            }

            Console.WriteLine("desea salir? esciba 6 para si ycualquier otro numero para no");
            opciones = int.Parse(Console.ReadLine());
        }

        
    }
}