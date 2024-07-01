using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Historias_Clinicas
{
    public partial class InformeCliente : Form
    {
        // Crear una propiedad para almacenar el informe actual
        public string InformeText { get; private set; }
        public InformeCliente()
        {
            InitializeComponent();
        }
        public InformeCliente(string informeText)
        {
            InitializeComponent();
            // Asignar el texto del informe al TextBox
            textBox1.Text = informeText;
            // Asignar el texto del informe a la propiedad InformeText
            InformeText = informeText;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            // Al hacer clic en Aceptar, asignar el texto del TextBox a la propiedad InformeText
            InformeText = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
