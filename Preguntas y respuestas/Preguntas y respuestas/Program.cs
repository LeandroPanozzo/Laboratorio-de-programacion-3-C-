/*
 Enunciado: Desarrolla una aplicación en C# para evaluar exámenes de selección múltiple. La aplicación debe permitir ingresar las 
preguntas y respuestas, así como las opciones de respuesta para cada pregunta. Una vez que se ingresan las preguntas y respuestas, 
la aplicación debe permitir al usuario responder el examen y mostrar los resultados al final de la evaluación.

Para resolver este ejemplo, primero debemos definir la estructura de datos necesaria para almacenar las preguntas, opciones de
respuesta y respuestas correctas. Podemos utilizar una matriz bidimensional o unidimensional para almacenar las opciones de respuesta 
para cada pregunta y una matriz unidimensional para almacenar las respuestas correctas.
 */

using System;
using System.Collections.Generic;

class Pregunta
{
    public string Enunciado { get; set; }
    public List<string> Opciones { get; set; }
    public int RespuestaCorrecta { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de preguntas
        List<Pregunta> examen = new List<Pregunta>();

        // Agregar preguntas y respuestas
        examen.Add(new Pregunta
        {
            Enunciado = "¿Cuál es la capital de Francia?",
            Opciones = new List<string> { "A. Madrid", "B. Berlín", "C. París", "D. Roma" },
            RespuestaCorrecta = 2 // La respuesta correcta es la C
        });

        examen.Add(new Pregunta
        {
            Enunciado = "¿Cuál es el símbolo químico del agua?",
            Opciones = new List<string> { "A. Ag", "B. H2O", "C. H2SO4", "D. CO2" },
            RespuestaCorrecta = 1 // La respuesta correcta es la B
        });

        // Mostrar las preguntas al usuario
        Console.WriteLine("Responde las siguientes preguntas:");

        int puntaje = 0;
        for (int i = 0; i < examen.Count; i++)
        {
            Console.WriteLine($"Pregunta {i + 1}: {examen[i].Enunciado}");
            for (int j = 0; j < examen[i].Opciones.Count; j++)
            {
                Console.WriteLine(examen[i].Opciones[j]);
            }

            Console.Write("Escribe la letra de tu respuesta: ");
            string respuestaUsuario = Console.ReadLine().ToUpper();

            int respuestaIndex = respuestaUsuario[0] - 'A'; // Convertir la letra a índice (A=0, B=1, C=2, etc.)
            if (respuestaIndex == examen[i].RespuestaCorrecta)
            {
                Console.WriteLine("¡Respuesta correcta!\n");
                puntaje++;
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta.\n");
            }
        }

        // Mostrar resultados
        Console.WriteLine($"Tu puntaje final es: {puntaje} de {examen.Count}");

        Console.ReadLine();
    }
}
