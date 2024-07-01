using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historias_Clinicas
{
    internal class Cliente
    {
        private static int contadorId = 1; // Inicializa el contador en 1
        public int Id { get;  set; } // Esta propiedad almacenará el Id único de cada instancia
        public string nombrePaciente { get; set; }
        public string Apellido { get; set; }
        public string NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string MotivoConsulta { get; set; }
        public DateTime FechaSeleccionadaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string InformeText { get; set; }
        public Cliente()
        {
            Id = contadorId++; //seria lo mismo que ponerlo en el constructor de abajo pero le coloco aca para darle utilidad a este
        }

        public Cliente(string nom, string apellido, string numTelefono, string direccion, string correo, string genero, string motivoConsulta, 
            DateTime fechaSeleccionadaCita, TimeSpan horaCita) : this() //llamo al otro constructor que esta arriba para que pase sus valores a este
        {
            //no necesito volver a colocar Id = contadorId++ gracias a :this()
            nombrePaciente = nom;
            Apellido = apellido;
            NumeroTelefono = numTelefono;
            Direccion=direccion;
            Correo = correo;
            Genero = genero;
            MotivoConsulta = motivoConsulta;
            FechaSeleccionadaCita = fechaSeleccionadaCita;
            HoraCita = horaCita;
        }

        public Cliente(string nom, string apellido, string numTelefono, string direccion, string correo, string genero, string motivoConsulta,
            DateTime fechaSeleccionadaCita, TimeSpan horaCita, string informeText) : this() //llamo al otro constructor que esta arriba para que pase sus valores a este
        {
            //no necesito volver a colocar Id = contadorId++ gracias a :this()
            nombrePaciente = nom;
            Apellido = apellido;
            NumeroTelefono = numTelefono;
            Direccion = direccion;
            Correo = correo;
            Genero = genero;
            MotivoConsulta = motivoConsulta;
            FechaSeleccionadaCita = fechaSeleccionadaCita;
            HoraCita = horaCita;
            InformeText= informeText;
        }
    }
}
