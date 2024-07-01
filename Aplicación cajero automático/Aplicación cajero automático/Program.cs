/*
 Desarrolle una aplicación en C#, para un cajero automático. La aplicación permitirá crear cuentas para jubilados
y personas en actividad. Los usuarios del cajero podrán depositar en su cuenta y realizar extracciones de la misma.
Si el usuario es una persona en actividad laboral podrá retirar hasta, 20000 pesos en concepto de adelanto de sueldo.
Si el usuario es una persona jubilada podrá retirar en concepto de adelanto solo 10000. Cada operación de ingreso o
extracción deberá registrar la fecha, el cajero y el monto de la operación. Los cajeros se identifican por su
dirección y número de cajeros. Si durante dos meses de operación un usuario tubo un saldo positivo superior a
20000 pesos, se le ofrecerá un crédito pre acordado de, 80000 pesos. Con lo cual, su nuevo límite de extracción
en negativo será de, 80000 pesos.
 */
using Aplicación_cajero_automático;

internal class Program
{
    private static void Main(string[] args)
    {
        // Crear una instancia de Cajero
        Cajero cajero = new Cajero();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Bienvenido al Cajero Automático");
            Console.WriteLine("1. Crear cuenta");
            Console.WriteLine("2. Realizar depósito");
            Console.WriteLine("3. Realizar extracción");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese su opción: ");

            // Leer la opción del usuario
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    cajero.CrearCuenta();
                    break;
                case "2":
                    cajero.Deposito();
                    break;
                case "3":
                    cajero.extraccion();
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("Gracias por utilizar nuestro servicio. ¡Adiós!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }

            Console.WriteLine();
        }
    }

}
