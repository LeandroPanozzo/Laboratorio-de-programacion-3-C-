using Sistema_de_gestion_Alumnos;

internal class Program
{
    private static void Main(string[] args)
    {
        Universidad u = new Universidad();

        bool continuar=true;

        Console.WriteLine("bienvenido al sistema de gestion de alumnos");
        while (continuar)
        {
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1- crear usuario a alumno");
            Console.WriteLine("2- agregar profesor a materia");
            Console.WriteLine("3- mostar materias con profesor y alumnos inscriptos");
            Console.WriteLine("4- buscar materia");
            Console.WriteLine("5- salir");
            int.TryParse(Console.ReadLine(), out int opcion);

            switch(opcion)
            {
                case 1:
                    u.CrearCuenta();
                    break;

                case 2:
                    u.AgregarProfe();
                    break;

                case 3:
                    u.MostrarTodo();
                    break;

                case 4:
                    u.mostarPorMateria();
                    break;
                case 5:
                    Console.WriteLine("Salio");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("ingreso una opcion incorrecta intentelo otra vez");
                    break;
            }
        }
    }
}