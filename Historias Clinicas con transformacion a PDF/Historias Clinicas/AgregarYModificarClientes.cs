using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Historias_Clinicas
{
    public partial class AgregarYModificarClientes : Form
    {
        public string nombrePaciente { get; set; }
        public string Apellido { get; set; }

        public string NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string MotivoConsulta { get; set; }
        public string Informetext { get; set; }
        public DateTime FechaSeleccionadaCita { get; set; }
        public TimeSpan HoraCita { get; set; }


        public AgregarYModificarClientes()
        {
            InitializeComponent();

        }

        private void Nom_paciente_Click(object sender, EventArgs e)
        {

        }

        private void AgregarYModificarClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            nombrePaciente = textBoxNombre.Text;
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            Apellido = textBoxApellido.Text;
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            NumeroTelefono = textBoxTelefono.Text;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            Direccion = textBoxTelefono.Text;
        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {
            Correo = textBoxCorreo.Text;
        }
        private void ConsultaBox2_TextChanged(object sender, EventArgs e)
        {
            MotivoConsulta = ConsultaBox2.Text;
        }
        private void GeneroBox1_TextChanged(object sender, EventArgs e)
        {
            Genero = GeneroBox1.Text;
        }
        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            FechaSeleccionadaCita = dateTimePickerFecha.Value.Date;
        }
        private void dateTimePickerHora_ValueChanged(object sender, EventArgs e)
        {
            HoraCita = dateTimePickerHora.Value.TimeOfDay;
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombrePaciente) || string.IsNullOrWhiteSpace(Apellido) || string.IsNullOrWhiteSpace(NumeroTelefono)
                || string.IsNullOrWhiteSpace(Direccion) || string.IsNullOrWhiteSpace(Correo) || string.IsNullOrWhiteSpace(Genero)
                || string.IsNullOrWhiteSpace(MotivoConsulta) || FechaSeleccionadaCita == default(DateTime) || HoraCita == default(TimeSpan))
            {
                MessageBox.Show("Por favor ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Owner.GetType() == typeof(Historias_Clinicas))
            { 
                Historias_Clinicas formulario = (Historias_Clinicas)Owner;

                if (formulario.clientes != null)
                {
                    formulario.clientes.nombrePaciente = nombrePaciente;
                    formulario.clientes.Direccion = Direccion;
                    formulario.clientes.Apellido = Apellido;
                    formulario.clientes.NumeroTelefono = NumeroTelefono;
                    formulario.clientes.Correo = Correo;
                    formulario.clientes.Genero = Genero;
                    formulario.clientes.MotivoConsulta = MotivoConsulta;
                    formulario.clientes.FechaSeleccionadaCita = FechaSeleccionadaCita;
                    formulario.clientes.HoraCita = HoraCita;
                    formulario.clientes.InformeText = Informetext;
                    formulario.bindingSource.ResetBindings(false); // Actualizar el BindingSource
                    formulario.Abierto = true;
                }
                else
                {
 
                    Cliente cli = new Cliente(nombrePaciente, Apellido, NumeroTelefono, Direccion, Correo, Genero, MotivoConsulta,
                        FechaSeleccionadaCita, HoraCita, Informetext);
                    formulario.lis.Add(cli);
                    formulario.bindingSource.ResetBindings(false); // Actualizar el BindingSource
                    formulario.Abierto = true;
                }

                //guardar datos del archivo
                using (saveFileDialog1)
                {
                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.Title = "Guardar archivo";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string ruta = saveFileDialog1.FileName;
                        formulario.GuardarAchivo(ruta);

                    }
                }

            }
            // Limpiar los campos y cerrar el formulario
            LimpiarCampos();
            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Close();
        }
        public void LimpiarCampos()
        {
            nombrePaciente = "";
            Direccion = "";
            Correo = "";
            NumeroTelefono = "";
            Genero = "";
            MotivoConsulta = "";
            Apellido = "";
            textBoxApellido.Clear();
            textBoxCorreo.Clear();
            textBoxDireccion.Clear();
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            GeneroBox1.Clear();
            ConsultaBox2.Clear();
            dateTimePickerFecha.Value = DateTime.Now;
            dateTimePickerHora.Value = DateTime.Now;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void GenerarInformeBtn_Click(object sender, EventArgs e)
        {
            InformeCliente inf = new InformeCliente(Informetext);
            inf.Owner = this;
            if (inf.ShowDialog() == DialogResult.OK)
            {
                Informetext = inf.InformeText;
            }
        }
    }
}
