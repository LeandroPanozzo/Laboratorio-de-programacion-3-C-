using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_con_base_de_datos_y_winforms
{
    public class Peliculas
    {
        public string Titulo { get; set; }
        public string Director { get; set; }
        public int CantidadAsientosComprados { get; set; }
        public decimal Precio { get; set; }
        public string Genero { get; set; }
        public string SalaDisponible { get; set; }
        
        public DateTime FechaVer { get; set; }
        public DateTime Fecha { get; set; }

        public Peliculas(string titulo, string director, int CantidadAsientosComprados, int precio, string genero, string salaDisponible, DateTime fecha, DateTime fechaVer)
        {
            this.Titulo = titulo;
            this.Director = director;
            this.CantidadAsientosComprados = CantidadAsientosComprados;
            this.Precio = precio;
            this.Genero = genero;
            this.SalaDisponible = salaDisponible;
            this.Fecha = fecha;
            this.FechaVer = fechaVer;
            
        }
    }
}
