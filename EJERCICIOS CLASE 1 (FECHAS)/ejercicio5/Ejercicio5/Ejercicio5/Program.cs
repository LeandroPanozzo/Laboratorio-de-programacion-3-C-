/*
 3.Realice un programa que solicite cuál fue el primer día del mes, por ejemplo el primer día del mes de marzo de
2022 fue un martes. Luego con esta información el sistema debe poder calcular que día será, el correspondiente a
una fecha dada. Por lo cual el sistema podría preguntar, ingrese una fecha del mes de marzo y le diré que día cae.
ADEMAS SI UNO DE LOS DIAS ES FIN DE SEMANA (SABADO O DOMINGO) LO SALTEE SE RECOMIENDA USAR 2024 COMO AÑO PARA HACERLO 
JUNIO Y SEPTIEMBRE Y DICIEMBRE CAERAN EN FIN DE SEMANA SU PRIMER DIA
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ingrese una año");

        int año = int.Parse(Console.ReadLine());

        

        

        for (int i = 0; i < 12; i++)
        {
            int mes = i + 1;
            DateTime fecha = new DateTime(año, mes, 01);
            int tomar = (int)fecha.DayOfWeek;
            Console.WriteLine(fecha.ToString("yyyy/MM/dd"));
            if(tomar == 6)
            {
                Console.WriteLine("Es fin de semana (sabado)");
            }
            else
            {
                if(tomar == 0) {
                    Console.WriteLine("Es fin de semana (domingo)");
                }
            }

        }

        //ahora si quiero que lo saltee
        Console.WriteLine();
        Console.WriteLine("SIN DIAS QUE SON FIN DE SEMANA");
        
        int cont = 0;
        for (int i = 0; i < 12; i++)
        {
            int mee = i + 1;
            DateTime fecha = new DateTime(año, mee, 01);
            int tomar = (int)fecha.DayOfWeek;
            
            if(tomar!= 6&& tomar!=0)
            {
                Console.Write(fecha.ToString("yyyy/MM/dd "));
                Console.Write(fecha.DayOfWeek.ToString());
                Console.WriteLine();
            }
            
            
            
            


        }


    }


}

/*
 Friday	5	
Indica viernes.

Monday	1	
Indica lunes.

Saturday	6	
Indica sábado.

Sunday	0	
Indica domingo.

Thursday	4	
Indica jueves.

Tuesday	2	
Indica martes.

Wednesday	3	
Indica miércoles.
 */