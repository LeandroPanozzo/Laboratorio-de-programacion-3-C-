using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Historias_Clinicas
{
    public partial class Historias_Clinicas : Form
    {
        internal Cliente clientes;
        AgregarYModificarClientes agreg; //inicializo el otro form para que ese dependa de este
        private string rutaArchivo; // Variable para almacenar la ruta del archivo
        internal List<Cliente> lis = new List<Cliente>();
        private bool abierto = false;
        internal BindingSource bindingSource = new BindingSource();

        public bool Abierto { get => abierto; set => abierto = value; }

        public Historias_Clinicas()
        {
            InitializeComponent();
            bindingSource.DataSource = lis;
            dataGridView1.DataSource = bindingSource;

        }

        public void Clientes_load(object sender, EventArgs e)
        {
        }
        private void Nuevo_Click(object sender, EventArgs e)
        {
            clientes = null; // Asegurarse de que clientes esté en null y no se sobreescriba a ningun cliente ya creado
            AgregarYModificarClientes c = new AgregarYModificarClientes();
            c.Owner = this; // Establece el formulario "Form1" como el propietario del otro form "Agregar y modificar clientes"
            c.ShowDialog(); //apartecera el formulario "Agregar y modificar clientes"

            bindingSource.ResetBindings(false);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AbrirArchivoBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivoSeleccionado = openFileDialog1.FileName;
                Abierto = true;
                CargarArchivo(archivoSeleccionado);
                GuardarArchivoBtn.Enabled = true;
            }
        }

        private void GuardarArchivoBtn_Click(object sender, EventArgs e)
        {
            if (Abierto)
            {
                GuardarArchivoBtn.Enabled = true;
                if (string.IsNullOrEmpty(rutaArchivo))
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                        saveFileDialog.Title = "Guardar archivo";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            rutaArchivo = saveFileDialog.FileName;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(rutaArchivo))
                {
                    GuardarAchivo(rutaArchivo);
                }
            }
            else
            {
                GuardarArchivoBtn.Enabled = false;
            }

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientes = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;
                // Crear una nueva instancia del formulario AgregarYModificarClientes:
                AgregarYModificarClientes agForm = new AgregarYModificarClientes();
                agForm.Owner = this;//se establece el form1 como propietario de AgregarYModificarClientes
                agForm.nombrePaciente = clientes.nombrePaciente;
                agForm.Apellido = clientes.Apellido;
                agForm.Correo = clientes.Correo;
                agForm.NumeroTelefono = clientes.NumeroTelefono;
                agForm.Direccion = clientes.Direccion;
                agForm.Genero = clientes.Genero;
                agForm.MotivoConsulta = clientes.MotivoConsulta;
                agForm.FechaSeleccionadaCita = clientes.FechaSeleccionadaCita;
                agForm.HoraCita = clientes.HoraCita;
                agForm.Informetext = clientes.InformeText;
                // Mostrar el formulario AgregarYModificarClientes
                agForm.ShowDialog();
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
                int indexSeleccionado = dataGridView1.SelectedRows[0].Index;
                Cliente clientes = lis[indexSeleccionado];
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este CLIENTE?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lis.RemoveAt(indexSeleccionado);
                    bindingSource.ResetBindings(false);
                    GuardarArchivoBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error: El índice seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        public void GuardarAchivo(string ruta)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, false))//utilizando la "ruta" proporcionada como parámetro.
                {
                    foreach (Cliente cl in lis)//itero sobre cara objeto cliente dentro de la lista
                    {
                        string linea = $"{cl.Id},{cl.nombrePaciente},{cl.Apellido},{cl.NumeroTelefono},{cl.Direccion},{cl.Correo},{cl.Genero},{cl.MotivoConsulta},{cl.FechaSeleccionadaCita},{cl.HoraCita},{cl.InformeText}";
                        sw.WriteLine(linea); //Se escribe la cadena linea en el archivo utilizando el método WriteLine del objeto StreamWriter, lo que agrega una nueva línea al archivo para cada cliente.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarArchivo(string ruta)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        string[] partes = linea.Split(',');
                        lis.Add(new Cliente
                        {
                            Id = int.Parse(partes[0]), //uso int.Parse porque partes[0] es una cadena de texto (string) que
                                                       //representa el ID del cliente en formato de texto
                            nombrePaciente = partes[1],
                            Apellido = partes[2],
                            NumeroTelefono = partes[3],
                            Direccion = partes[4],
                            Correo = partes[5],
                            Genero = partes[6],
                            MotivoConsulta = partes[7],
                            FechaSeleccionadaCita = DateTime.Parse(partes[8]),
                            HoraCita = TimeSpan.Parse(partes[9]),
                            InformeText = partes[10]

                        });
                    }
                }
                bindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos desde el archivo: {ex.Message}", "Error Este archivo no es compatible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarPDFBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar archivo PDF";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog.FileName;
                    ExportarAPDF(ruta);
                }
            }
        }

        public void ExportarAPDF(string ruta)
        {
            try
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(ruta, FileMode.Create));
                doc.Open();

                foreach (Cliente cl in lis)
                {
                    doc.Add(new Paragraph($"ID: {cl.Id}"));
                    doc.Add(new Paragraph($"Nombre: {cl.nombrePaciente}"));
                    doc.Add(new Paragraph($"Apellido: {cl.Apellido}"));
                    doc.Add(new Paragraph($"Telefono: {cl.NumeroTelefono}"));
                    doc.Add(new Paragraph($"Direccion: {cl.Direccion}"));
                    doc.Add(new Paragraph($"Correo: {cl.Correo}"));
                    doc.Add(new Paragraph($"Genero: {cl.Genero}"));
                    doc.Add(new Paragraph($"Motivo Consulta: {cl.MotivoConsulta}"));
                    doc.Add(new Paragraph($"Fecha Cita: {cl.FechaSeleccionadaCita}"));
                    doc.Add(new Paragraph($"Hora Cita: {cl.HoraCita}"));
                    doc.Add(new Paragraph($"Informe: {cl.InformeText}"));
                    doc.Add(new Paragraph("----------------------------------------------------"));
                }

                doc.Close();
                MessageBox.Show("Exportación a PDF realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
