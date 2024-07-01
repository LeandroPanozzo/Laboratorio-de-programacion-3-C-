using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_cajero_automático
{
    internal class CuentaBancaria
    {
        public List<Usuario> list_user = new List<Usuario>();
        public List<Operacion> list_ope = new List<Operacion>();
        public int numCeunta { get; set; }
        public int saldoActual { get; set; }
        

        public CuentaBancaria()
        {
            
        }
        
        
       public void nuevoUsuario(Usuario usu)
        {
            list_user.Add(usu);
            
        }
        public void nuevooperacion(Operacion op)
        {
            list_ope.Add(op);
        }
    }
}
