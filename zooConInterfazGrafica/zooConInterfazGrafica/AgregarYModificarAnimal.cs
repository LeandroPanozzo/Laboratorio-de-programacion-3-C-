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
    public partial class AgregarYModificarAnimal : Form
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string alimento { get; set; }
        public AgregarYModificarAnimal()
        {
            InitializeComponent();
        }

        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            nombre = textBox_nombre.Text;
        }

        private void textBox_tipo_TextChanged(object sender, EventArgs e)
        {
            tipo = textBox_tipo.Text;
        }

        private void textBox_Comida_TextChanged(object sender, EventArgs e)
        {
            alimento = textBox_Comida.Text;
        }

        private void AgregarYModificarAnimal_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(tipo) || string.IsNullOrWhiteSpace(alimento))
            {
                MessageBox.Show("Por favor ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  Esta condición verifica si el formulario padre de AgregarYModificarAnimal
            //  es del tipo Animales. Si es así, significa que AgregarYModificarAnimal
            //  fue abierto desde el formulario Animales para modificar un animal
            //  existente o agregar uno nuevo.
            if (Owner.GetType() == typeof(Animales))
            {
                //La razón por la que se necesita esta referencia al formulario Animales
                //es porque el formulario AgregarYModificarAnimal necesita modificar
                //o agregar animales en el formulario Animales, ya que es el formulario
                //que contiene la lista de animales y el DataGridView para mostrarlos.
                // al obtener una referencia al formulario Animales a través de Owner,
                // el código en el formulario AgregarYModificarAnimal puede acceder a
                // la lista de animales (lis) y al DataGridView del formulario Animales,
                // y luego modificarlos o actualizarlos según sea necesario. 
                Animales formAnim = (Animales)Owner;

                if (formAnim.animalSeleccionado != null)
                {
                    //no es nulo, significa que se está modificando un animal existente.
                    //En este caso, se actualizan los datos del animal seleccionado con
                    //los valores ingresados por el usuario
                    formAnim.animalSeleccionado.nombre = nombre;
                    formAnim.animalSeleccionado.tipo = tipo;
                    formAnim.animalSeleccionado.comida = alimento;
                }
                else
                {
                    //Si formAnim.animalSeleccionado es nulo, significa que se está agregando un
                    //nuevo animal. En este caso, se crea una nueva instancia de ListaAnimales
                    //con los valores ingresados por el usuario y se agrega a la lista lis en
                    //el formulario Animales
                    ListaAnimales animales = new ListaAnimales(nombre, tipo, alimento);
                    formAnim.lis.Add(animales);
                }

                // Actualizar el DataGridView en el formulario Animales
                formAnim.ActualizarDataGridView();
            }
            
            // Limpiar los campos y cerrar el formulario
            LimpiarCampos();
            Close();
        }



        private void button1_cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Close();
        }

        public void LimpiarCampos()
        {
            nombre = "";
            tipo = "";
            alimento = "";
            textBox_Comida.Clear();
            textBox_nombre.Clear();
            textBox_tipo.Clear();
        }
    }
}
