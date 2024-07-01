using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_cajero_automático
{
    internal class Usuario
    {
        
        public string usuario { get; set; }
        public string nombre { get; set; }
        public string tipoUsuario { get; set; }
        public int dinero { get; set; }
        public DateTime fechaApertura { get; set; }
        public int mesesConSaldoPositivo { get; set; }

        public Usuario(string a, string b, string d, int c, DateTime aper)
        {
            usuario= a;
            nombre= b;
            tipoUsuario= d;
            dinero= c;
            fechaApertura = aper;
        }

        public Usuario( int c)
        {
            
            dinero = c;
        }
    }
}
