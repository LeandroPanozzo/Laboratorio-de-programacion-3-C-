using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_cajero_automático
{
    internal class Cajero
    {
        private string nomUser;
        private string nom;
        private string opcion;
        private int dinero;

        public int numDireccion { get; set; }
        public int numCajero { get; set; }
        public int Dinero { get => this.dinero; set => this.dinero = value; }
        public string NomUser { get => nomUser; set => nomUser = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Opcion { get => opcion; set => opcion = value; }

        public Cajero()
        {
            
        }
        CuentaBancaria cb = new CuentaBancaria();
        CuentaBancaria o = new CuentaBancaria();
        public void CrearCuenta()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine("Ingrese un nombre de usuario");
            NomUser = Console.ReadLine();
            Console.WriteLine("Ingrese un nombre");
            Nom = Console.ReadLine();
            Console.WriteLine("Ingrese j si es jubilado o a si es una persona en actividad");
            Opcion = Console.ReadLine().ToLower();
            cb.nuevoUsuario(new Usuario(NomUser, Nom, Opcion,0,d));
            
            Console.WriteLine($"Cuenta creada: nombre de usuario {NomUser} y nombre {Nom}");
            
        }

        //en lugar de poner aca el lis<usuario> aca lo pongo en el foreach con cb.list_user
        public void Deposito()
        {
            Console.WriteLine("Seleccione un cajero:");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            int.TryParse(Console.ReadLine(), out int opcion);

            switch (opcion)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Ingrese el nombre de usuario:");
                    string nomUser = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre:");
                    string nom = Console.ReadLine();

                    foreach (Usuario item in cb.list_user)
                    {
                        if (item.usuario == nomUser && item.nombre == nom)
                        {
                            Console.WriteLine("Acceso al sistema.");
                            Console.WriteLine("Ingrese el monto que desea depositar:");
                            if (!int.TryParse(Console.ReadLine(), out int dinero)) //si pongo una veriable que no sea un numero
                            {
                                Console.WriteLine("Monto inválido.");
                                return;
                            }

                            // Realizar el depósito
                            item.dinero += dinero;
                            DateTime d = DateTime.Now;
                            o.nuevooperacion(new Operacion(d, opcion, dinero, "Depósito"));
                            Console.WriteLine($"Depósito exitoso: fecha {d.ToString()}, cajero {opcion}, su saldo ahora es de {item.dinero}");

                            // Verificar si el usuario ha mantenido un saldo positivo superior a 20000 pesos durante dos meses consecutivos
                            if (item.dinero > 20000)
                            {
                                item.mesesConSaldoPositivo++;

                                if (item.mesesConSaldoPositivo >= 2)
                                {
                                    // Establecer el nuevo límite de extracción en negativo en 80000 pesos
                                    item.tipoUsuario = "j";
                                    Console.WriteLine("¡Felicidades! Se le ha otorgado un crédito pre acordado de $80,000.");
                                }
                            }
                            else
                            {
                                // Reiniciar el contador de meses con saldo positivo si el saldo es inferior a 20000
                                item.mesesConSaldoPositivo = 0;
                            }

                            return;
                        }
                    }
                    Console.WriteLine("Usuario no encontrado.");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta, inténtelo de nuevo.");
                    break;
            }
        }


        public void extraccion( ) {

            Console.WriteLine("seleccione un cajero");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            int.TryParse(Console.ReadLine(), out int opcion);
            switch (opcion)
            {
                case 1:
                    
                    Console.WriteLine("Ingrese el nombre de usuario");
                    NomUser = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre");
                    Nom = Console.ReadLine();

                    foreach (Usuario item in cb.list_user)
                    {
                        if (item.usuario == NomUser && item.nombre == Nom)
                        {
                            Console.WriteLine("Ingrese cuanto desea extraer");
                            if (!int.TryParse(Console.ReadLine(), out int dinero))
                            {
                                Console.WriteLine("Monto inválido.");
                                return;
                            }

                            // Verificar límite de extracción
                            if ((item.tipoUsuario == "j" && dinero > 80000) || (item.tipoUsuario == "a" && dinero > 20000))
                            {
                                Console.WriteLine("No puede retirar montos mayores al límite de extracción.");
                                return;
                            }

                            // Realizar la extracción
                            item.dinero -= dinero;
                            DateTime d = DateTime.Now;
                            o.nuevooperacion(new Operacion(d, opcion, dinero, "Extracción"));
                            Console.WriteLine($"Extracción exitosa: fecha {d.ToString()}, cajero {opcion}, su saldo ahora es de {item.dinero}");
                            return;


                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese el nombre de usuario");
                    NomUser = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre");
                    Nom = Console.ReadLine();

                    foreach (Usuario item in cb.list_user)
                    {
                        if (item.usuario == NomUser && item.nombre == Nom)
                        {
                            Console.WriteLine("Ingrese cuanto desea extraer");
                            if (!int.TryParse(Console.ReadLine(), out int dinero))
                            {
                                Console.WriteLine("Monto inválido.");
                                return;
                            }

                            // Verificar límite de extracción
                            if ((item.tipoUsuario == "j" && dinero > 80000) || (item.tipoUsuario == "a" && dinero > 20000))
                            {
                                Console.WriteLine("No puede retirar montos mayores al límite de extracción.");
                                return;
                            }

                            // Realizar la extracción
                            item.dinero -= dinero;
                            DateTime d = DateTime.Now;
                            o.nuevooperacion(new Operacion(d, opcion, dinero, "Extracción"));
                            Console.WriteLine($"Extracción exitosa: fecha {d.ToString()}, cajero {opcion}, su saldo ahora es de {item.dinero}");
                            return;


                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Ingrese el nombre de usuario");
                    NomUser = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre");
                    Nom = Console.ReadLine();

                    foreach (Usuario item in cb.list_user)
                    {
                        if (item.usuario == NomUser && item.nombre == Nom)
                        {
                            Console.WriteLine("Ingrese cuanto desea extraer");
                            if (!int.TryParse(Console.ReadLine(), out int dinero))
                            {
                                Console.WriteLine("Monto inválido.");
                                return;
                            }

                            // Verificar límite de extracción
                            if ((item.tipoUsuario == "j" && dinero > 80000) || (item.tipoUsuario == "a" && dinero > 20000))
                            {
                                Console.WriteLine("No puede retirar montos mayores al límite de extracción.");
                                return;
                            }

                            // Realizar la extracción
                            item.dinero -= dinero;
                            DateTime d = DateTime.Now;
                            o.nuevooperacion(new Operacion(d, opcion, dinero, "Extracción"));
                            Console.WriteLine($"Extracción exitosa: fecha {d.ToString()}, cajero {opcion}, su saldo ahora es de {item.dinero}");
                            return;

                            
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Ingreso una opcion incorrecta, intentelo otra vez");
                    break;
            }

            
        }
    }
}
