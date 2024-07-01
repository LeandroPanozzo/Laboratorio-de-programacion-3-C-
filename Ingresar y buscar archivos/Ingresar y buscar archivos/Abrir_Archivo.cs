using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingresar_y_buscar_archivos
{
    public partial class Abrir_Archivo : Form
    {
        //creo una intsnacia de cuadro de diálogo estándar de Windows que permite al usuario seleccionar uno o más archivos para abrir
        OpenFileDialog ofd = new OpenFileDialog(); 
        public Abrir_Archivo()
        {
            InitializeComponent();
        }

        public void Abrir_Click(object sender, EventArgs e)
        {
            //deberia mostar el archive .txt
            //establece el título del cuadro de diálogo de apertura de archivos. En este caso, el título se establece en
            //"Seleccionar archivo", lo que se mostrará en la barra de título del cuadro de diálogo cuando se abra
            ofd.Title = "Seleccionar archivo";
            //filtro de archivos para el cuadro de diálogo. Este filtro determina qué tipos de archivos se
            //mostrarán cuando abra el cuadro de diálogo. En este caso, todos los archivos (*.*),
            //así como solo archivos de texto (*.txt)
            ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            //El primer filtro es "Archivos de texto (.txt)" y el segundo es "Todos los archivos (.)". Al establecer
            //FilterIndex en 1, se indica que el primer filtro, es decir, "Archivos de texto (.txt)", será el filtro
            //seleccionado cuando el cuadro de diálogo se abra por primera vez pot lo que solo apareceran los .txt
            ofd.FilterIndex = 1;
            //Aquí se permite o no que el usuario seleccione múltiples archivos en el cuadro de diálogo. Al establecerlo
            //en false, NO se permite la selección de múltiples archivos
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string leer = ofd.FileName;
                //Este método se utiliza para obtener el nombre de archivo y extensión de una ruta de archivo especificada
                //Muestra solo el nombre del archivo o si deseas mostrar la ruta completa, esta se mostrara en label
                especificarElArchivoSeleccionado.Text = System.IO.Path.GetFileName(ofd.FileName); 
            }

        }

        private void Escribir_Click(object sender, EventArgs e)
        {
            // Obtener el contenido del archivo seleccionado
            //File.ReadAllText() Este método se utiliza para leer todo el contenido de un archivo de texto en una sola
            //operación y devolverlo como una cadena. File.ReadAllText() toma esta ruta como argumento y lee el contenido del archivo asociado.
            string contenido = File.ReadAllText(ofd.FileName);

            // Pasar la ruta del archivo seleccionado al formulario Escribir_Archivo
            Escribir_Archivo esc = new Escribir_Archivo(ofd.FileName, contenido);
            esc.Owner = this;
            esc.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un archivo
            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                try
                {
                    // Abrir el archivo con el Bloc de Notas. Process.Start() es un método estático se utiliza para
                    // iniciar un nuevo proceso. En este caso, se especifica "notepad.exe", que es el ejecutable del Bloc de
                    //notas El segundo argumento es la ruta completa del archivo que se abrirá en el Bloc de notas. Esto se
                    //obtiene de ofd.FileName, que es la ruta del archivo seleccionado
                    Process.Start("notepad.exe", ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún archivo.");
            }
        }

        private void especificarElArchivoSeleccionado_Click(object sender, EventArgs e)
        {
            //cuando apretemos el boton abrir mostrara como se llama el archivo seleccionado
        }

        private void Abrir_Archivo_Load(object sender, EventArgs e)
        {

        }

        private void NuevoTxt_Click(object sender, EventArgs e)
        {
            //proporciona un cuadro de diálogo estándar para que el usuario especifique la ubicación y el nombre de un
            //archivo para guardar
            SaveFileDialog sfd = new SaveFileDialog();

            // Configurar el diálogo para que muestre solo archivos de texto (*.txt)
            sfd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.Title = "Guardar archivo como...";

            // Mostrar el diálogo y verificar si el usuario hizo clic en "Guardar" (hace ambas cosas en el if)
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = sfd.FileName;

                // Crear un nuevo archivo vacío
                try
                {
                    //Esta línea crea un nuevo objeto de tipo FileStream llamado fs que representa el archivo que se va a
                    //crear. La función System.IO.File.Create() devuelve un objeto FileStream que permite crear un nuevo
                    //archivo en la ruta especificada (rutaArchivo). Si el archivo ya existe, este método lo sobrescribe
                    using (System.IO.FileStream fs = System.IO.File.Create(rutaArchivo))
                    {
                        // Cerrar el archivo después de crearlo
                        fs.Close();
                    }

                    // Abrir el formulario de escritura y pasar la ruta del nuevo archivo
                    Escribir_Archivo esc = new Escribir_Archivo(rutaArchivo);
                    esc.Owner = this;
                    esc.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el archivo: " + ex.Message);
                }
            }
        }

    }
}
