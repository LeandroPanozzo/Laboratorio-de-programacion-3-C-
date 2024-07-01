using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zooConInterfazGrafica
{
    public partial class Animales : Form
    {
        internal ListaAnimales animalSeleccionado;
        AgregarYModificarAnimal agreg;
        ListaAnimales a = new ListaAnimales("tortuga", "anfibio", "pasto");
        ListaAnimales b = new ListaAnimales("Rocio", "Mono", "Coca");
        internal List<ListaAnimales> lis = new List<ListaAnimales>();
        public Animales()
        {
            lis.Add(a);
            lis.Add(b);
            InitializeComponent();
        }

        //En el método Animales_Load, que se ejecuta cuando se carga el formulario,
        //puedes asignar la lista lis al DataSource del DataGridView. Aquí hay un

        public void Animales_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lis;//asigno los valores de la lista al datagrind
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            AgregarYModificarAnimal a = new AgregarYModificarAnimal();
            a.Owner = this; // Establece el formulario "Animales" como el propietario de "AgregarYModificarAnimal"
            a.ShowDialog();

            //la agregacion del animal estara en el boton aceptar del formulario AgregarYModificar
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // verificar si hay una fila seleccionada en el DataGridView. Si hay una
        // fila seleccionada, crear una nueva instancia de AgregarYModificarAnimal
        // si aún no existe, y mostrarla.
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //Si la cantidad de filas
                                                      //seleccionadas es mayor que cero,
                                                      //significa que el usuario ha
                                                      //seleccionado al menos una
            {
                // obtiene el objeto ListaAnimales correspondiente a la fila seleccionada en el DataGridView
                animalSeleccionado = (ListaAnimales)dataGridView1.SelectedRows[0].DataBoundItem;

                // Crear una nueva instancia del formulario AgregarYModificarAnimal
                AgregarYModificarAnimal aForm = new AgregarYModificarAnimal();
                aForm.Owner = this; //se establece el formulario Animales como propietario de este formulario

                // Pasar los valores del animal seleccionado al formulario AgregarYModificarAnimal
                aForm.nombre = animalSeleccionado.nombre;
                aForm.tipo = animalSeleccionado.tipo;
                aForm.alimento = animalSeleccionado.comida;

                // Mostrar el formulario AgregarYModificarAnimal como un cuadro de diálogo modal
                aForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Obtener el animal seleccionado de la lista
                ListaAnimales animalSeleccionado = lis[selectedIndex];

                // Mostrar un mensaje de confirmación antes de eliminar
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este animal?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //l parámetro MessageBoxButtons.YesNo indica que se deben mostrar
                //botones de "Sí" y "No". El parámetro MessageBoxIcon.Question indica
                //que se debe mostrar un ícono de pregunta en el cuadro de diálogo para
                //indicar que se trata de una pregunta al usuario.
                //result contendrá el valor del botón que el usuario seleccionó en el cuadro de diálogo.
                if (result == DialogResult.Yes)
                {
                    // Eliminar el animal seleccionado de la lista
                    lis.RemoveAt(selectedIndex);

                    // Actualizar el DataGridView para reflejar los cambios
                    ActualizarDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un animal para borrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ActualizarDataGridView()
        {
            dataGridView1.DataSource = null; // Limpiar el DataSource
            dataGridView1.DataSource = lis; //Esto significa que los datos contenidos
                                            //en la lista lis se mostrarán en el
                                            //DataGridView. Cuando asignas una lista
                                            //como origen de datos del DataGridView
        }
    }
}
