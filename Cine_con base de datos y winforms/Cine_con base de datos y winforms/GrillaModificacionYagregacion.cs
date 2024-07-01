using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_con_base_de_datos_y_winforms
{
    public partial class GrillaModificacionYagregacion : Form
    {
        public Peliculas peli { get; set; }
        public bool abrir { get; set; }
        public GrillaModificacionYagregacion()
        {
            InitializeComponent();
            // Inicializar `peli` si es `null`
            /*
             Si la propiedad peli es null, significa que no se ha inicializado con ninguna instancia de la clase Peliculas. En este 
            caso, si se intenta acceder a miembros o propiedades de peli, como sucede en otros lugares del código, se produciría una
            excepción de referencia nula (NullReferenceException).
             */
            if (peli == null)
            {
                peli = new Peliculas("", "", 0, 0, "", "", DateTime.Now, DateTime.Now);
            }
        }

        private void GrillaModificacionYagregacion_Load(object sender, EventArgs e) //Se activa cuando la ventana de diálogo se carga
        {
            /*
             Si abrir es false, significa que la ventana se está utilizando para agregar una nueva película. En este caso, se asignan 
            los valores predeterminados de peli a los controles de la ventana.
            Al asignar los valores predeterminados de peli a los controles de la ventana, se prellenan los campos de entrada de datos 
            con valores iniciales que pueden ser modificados por el usuario según sea necesario. Esto puede ser útil para ofrecer 
            sugerencias sobre el formato de entrada de datos, así como para ahorrar tiempo al usuario al no tener que ingresar valores
            desde cero.
             */
            if (!abrir)
            {
                TituloPeliBox1.Text = peli.Titulo;
                DirectorBox2.Text = peli.Director;
                SalaDisponibleBox5.Text = peli.SalaDisponible;
                GeneroBox4.Text = peli.Genero;
                AñoDeLanzamiento.Text = peli.Fecha.ToString("yyyy-MM-dd");
                PrecioBox3.Text= peli.Precio.ToString();
                CantidadAsientosBox6.Text = peli.CantidadAsientosComprados.ToString();
                
            }

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            /*
             Se activa cuando se hace clic en el botón "Aceptar".
            Verifica si todos los campos necesarios están completos.
            Si es así, actualiza el objeto peli con los valores de los controles de la ventana, establece el resultado del diálogo como
            DialogResult.OK y cierra la ventana
             */

            if (CamposCompletos())
            {
                peli.Titulo = TituloPeliBox1.Text;
                peli.Director = DirectorBox2.Text;
                peli.SalaDisponible = SalaDisponibleBox5.Text;
                peli.Precio = int.Parse(PrecioBox3.Text);
                peli.Genero = GeneroBox4.Text;
                peli.CantidadAsientosComprados = int.Parse(CantidadAsientosBox6.Text);
                //this.DialogResult = DialogResult.OK; establece el resultado del diálogo actual como "OK", lo que indica que el
                //usuario ha completado la interacción con la ventana de diálogo de manera exitosa 
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        /*
         Se activan cuando se hace clic en los botones correspondientes.
        Abren ventanas adicionales (AñoLanzamiento y FechaActual) para seleccionar fechas específicas relacionadas con la película 
        (fecha de estreno y fecha de cartelera). Los valores seleccionados se asignan al objeto peli
         */
        private void PonerFechaEnLaQueSeEsteno_Click(object sender, EventArgs e)
        {
            AñoLanzamiento aL = new AñoLanzamiento();
            if (aL.ShowDialog() == DialogResult.OK)
            {
                peli.FechaVer = aL.fechaSeleccionadalanzamiento;
            }
        }

        private void PonerFechaCartelera_Click(object sender, EventArgs e)
        {

            FechaActual fA = new FechaActual();
            if (fA.ShowDialog() == DialogResult.OK)
            {
                peli.Fecha = fA.fechaYHoraSeleccionada;
            }

        }

        public bool CamposCompletos()
        {
            //Verifica si todos los campos obligatorios están completos.
            if (string.IsNullOrWhiteSpace(TituloPeliBox1.Text) ||
                string.IsNullOrWhiteSpace(DirectorBox2.Text) ||
                string.IsNullOrWhiteSpace(SalaDisponibleBox5.Text) ||
                string.IsNullOrWhiteSpace(GeneroBox4.Text) ||
                string.IsNullOrWhiteSpace(PrecioBox3.Text) ||
                string.IsNullOrWhiteSpace(CantidadAsientosBox6.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
