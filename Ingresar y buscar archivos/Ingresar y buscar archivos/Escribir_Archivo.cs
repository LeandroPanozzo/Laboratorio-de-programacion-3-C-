using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingresar_y_buscar_archivos
{
    public partial class Escribir_Archivo : Form
    {
        public string RutaArchivo { get => rutaArchivo; set => rutaArchivo = value; }
        public Escribir_Archivo()
        {
            InitializeComponent();
            
        }
        public Escribir_Archivo(string rutaArchivo)
        {
            InitializeComponent();
            //Aquí se asigna el valor del parámetro rutaArchivo a la propiedad RutaArchivo de la clase. Esta propiedad se
            //utiliza para almacenar la ruta del archivo en el formulario.
            RutaArchivo = rutaArchivo;

        }

        //este constructor se utilizara para abrir un archivo ya creado y en el que escribimos para que empiece en donde
        //quedo el ultimo texto escrito en el block de notas
        public Escribir_Archivo(string rutaArchivo, string contenido)
        {
            InitializeComponent();
            RutaArchivo = rutaArchivo;
            textBox1.Text = contenido; // Mostrar el contenido del archivo en el textBox

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string rutaArchivo; // Variable para almacenar la ruta del archivo

        

        

        private void Guardar_Click(object sender, EventArgs e)
        {
            //Esta línea obtiene el texto actual del textBox1, que es donde el usuario puede escribir o editar el contenido
            //del archivo
            string contenido = textBox1.Text;
            //sta línea utiliza el método estático WriteAllText() de la clase File en el espacio de nombres System.IO para
            //escribir el contenido del textBox1 en un archivo en la ruta especificada por RutaArchivo. Este método crea un
            //nuevo archivo si el archivo especificado no existe o sobrescribe el archivo si ya existe. Se escribe el
            //contenido completo del textBox1 en el archivo.
            System.IO.File.WriteAllText(RutaArchivo, contenido);
            // debo guardar en la misma ruta de archivo que abri en abrir archivo
            MessageBox.Show("Contenido guardado exitosamente.");

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
