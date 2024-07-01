namespace Historias_Clinicas
{
    public partial class Historias_Clinicas : Form
    {
        internal Cliente clientes;
        AgregarYModificarClientes agreg; //inicializo el otro form para que ese dependa de este
        private string rutaArchivo; // Variable para almacenar la ruta del archivo
        internal List<Cliente> lis = new List<Cliente>();
        private bool abierto = false;
        //BindingSource simplifica la administraci�n de datos en aplicaciones de Windows Forms, proporcionando una interfaz
        //consistente para enlazar datos y gestionar actualizaciones entre la fuente de datos y los controles de la
        //interfaz de usuario. Su uso asegura que cualquier cambio en la lista de clientes (lis) se
        //refleje autom�ticamente en el DataGridView, optimizando la actualizaci�n de los datos mostrados.
        internal BindingSource bindingSource = new BindingSource();

        public bool Abierto { get => abierto; set => abierto = value; }

        public Historias_Clinicas()
        {

            InitializeComponent();
            //Facilita la sincronizaci�n entre la fuente de datos y los controles de la interfaz de usuario. Si los datos
            //cambian en la fuente, los controles enlazados se actualizan autom�ticamente y viceversa.
            //estableces la fuente de datos del BindingSource a tu lista de clientes (lis)
            bindingSource.DataSource = lis;
            //y luego establecer el bindingSource como la fuente de datos para el DataGridView Esto asegura que cualquier
            //cambio en la lista lis se refleje autom�ticamente en el DataGridView
            dataGridView1.DataSource = bindingSource;

            
        }

        //En el m�todo Clientes_Load, que se ejecuta cuando se carga el formulario,
        //puedes asignar la lista lis al DataSource del DataGridView

        public void Clientes_load(object sender, EventArgs e)
        {
        }
        private void Nuevo_Click(object sender, EventArgs e)
        {
            clientes = null; // Asegurarse de que clientes est� en null y no se sobreescriba a ningun cliente ya creado
            AgregarYModificarClientes c = new AgregarYModificarClientes();
            c.Owner = this; // Establece el formulario "Form1" como el propietario del otro form "Agregar y modificar clientes"
            c.ShowDialog(); //apartecera el formulario "Agregar y modificar clientes"
            //ResetBindings(false) se utiliza para actualizar y reflejar los cambios en la interfaz de usuario (UI) cuando
            //los datos subyacentes han cambiado. tiene un par�metro booleano que indica si se deben volver a aplicar todos los enlaces de datos:
            //ResetBindings(true): Reaplica todos los enlaces de datos es m�s costoso en t�rminos de rendimiento porque
            //realiza una reaplicaci�n completa de los enlaces de datos, lo que puede ser innecesario y lento si tienes
            //muchos controles enlazados o si se llama frecuentemente. �til cuando se cambian propiedades que afectan la
            //configuraci�n de enlace en s� misma, como cambiar el origen de datos del BindingSource o modificar la
            //estructura de la lista de datos.
            //ResetBindings(false): Actualiza la UI sin reaplicar todos los enlaces m�s eficiente porque simplemente
            //notifica a los controles enlazados que deben actualizar su presentaci�n de los datos actuales. Ideal para
            //cuando se agregan, modifican o eliminan elementos en la lista de datos, ya que simplemente actualiza la
            //visualizaci�n de los datos en los controles
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
                Abierto=true;
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
            if (dataGridView1.SelectedRows.Count > 0)//Si la cantidad de filas
                                                     //seleccionadas es mayor que cero,
                                                     //significa que el usuario ha
                                                     //seleccionado al menos una
            {
                // obtiene el objeto Clientes correspondiente a la fila seleccionada en el DataGridView
                clientes = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;
                // Crear una nueva instancia del formulario AgregarYModificarClientes:
                AgregarYModificarClientes agForm = new AgregarYModificarClientes();
                agForm.Owner = this;//se establece el form1 como propietario de AgregarYModificarClientes
                // Pasar los valores del cliente seleccionado al formulario AgregarYModificarClientes
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
                // Obtener el �ndice de la fila seleccionada
                //Esta l�nea obtiene el �ndice de la fila seleccionada accediendo al primer elemento de la colecci�n
                //SelectedRows y luego obteniendo el �ndice de esa fila.obtener el �ndice de esa fila utilizando la
                //propiedad Index. Este �ndice indica la posici�n de la fila dentro del control, donde la primera fila
                //tiene un �ndice de 0, la segunda fila tiene un �ndice de 1, y as�
                int indexSeleccionado = dataGridView1.SelectedRows[0].Index;


                //Una vez que se tiene el �ndice de la fila seleccionada, se utiliza este �ndice para acceder al cliente
                //correspondiente en la lista lis. Esto se hace utilizando la sintaxis de acceso a un elemento de una lista
                //(lis[indexSeleccionado]). El cliente seleccionado se asigna a una variable llamada clientes.
                Cliente clientes = lis[indexSeleccionado];

                // Obtener el Cliente seleccionado de la lista
                DialogResult result = MessageBox.Show("�Est� seguro de que desea eliminar este CLIENTE?", "Confirmar eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //l par�metro MessageBoxButtons.YesNo indica que se deben mostrar
                //botones de "S�" y "No". El par�metro MessageBoxIcon.Question indica
                //que se debe mostrar un �cono de pregunta en el cuadro de di�logo para
                //indicar que se trata de una pregunta al usuario.
                //result contendr� el valor del bot�n que el usuario seleccion� en el cuadro de di�logo.
                if (result == DialogResult.Yes)
                {
                    // Eliminar el Cliente seleccionado de la lista
                    lis.RemoveAt(indexSeleccionado);
                    // Resetear el BindingSource para reflejar los cambios en el DataGridView
                    bindingSource.ResetBindings(false);
                    GuardarArchivoBtn.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Error: El �ndice seleccionado no es v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        //guardar el archivo
        public void GuardarAchivo(string ruta)
        {
            try
            {
                //using para garantizar que el objeto StreamWriter se cierre correctamente despu�s de su uso
                using (StreamWriter sw = new StreamWriter(ruta, false))//utilizando la "ruta" proporcionada como par�metro.
                {
                    foreach (Cliente cl in lis)//itero sobre cara objeto cliente dentro de la lista
                    {
                        // itera sobre la lista lis de clientes y escribe una l�nea por cada cliente en el archivo, separando los valores por comas.
                        string linea = $"{cl.Id},{cl.nombrePaciente},{cl.Apellido},{cl.NumeroTelefono},{cl.Direccion},{cl.Correo},{cl.Genero},{cl.MotivoConsulta},{cl.FechaSeleccionadaCita},{cl.HoraCita},{cl.InformeText}";
                        //Para cada cliente, se crea una cadena linea que contiene los valores del cliente separados por comas.
                        //Cuando el usuario selecciona una ubicaci�n y un nombre de archivo usando SaveFileDialog y hace
                        //clic en "Guardar", el m�todo GuardarArchivo recibe la ruta completa del archivo seleccionado, incluyendo
                        //la extensi�n ".txt" especificada en el saveFileDialog.Filter del metodo de guardar boton
                        sw.WriteLine(linea); //Se escribe la cadena linea en el archivo utilizando el m�todo WriteLine del objeto StreamWriter, lo que agrega una nueva l�nea al archivo para cada cliente.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cargar archivo
        public void CargarArchivo(string ruta)
        {
            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string linea;
                    //Se utiliza un bucle while para leer cada l�nea del archivo. El bucle continuar� hasta que se alcance
                    //el final del archivo, momento en el que el m�todo ReadLine() devolver� null
                    while ((linea = sr.ReadLine()) != null)
                    {
                        // Para cada l�nea le�da, se utiliza el m�todo Split(',') para dividir la l�nea en partes
                        // utilizando la coma como delimitador. Esto crea un array de cadenas llamado partes (siempre 
                        //crea un array), donde cada elemento del array contiene un valor separado por coma de la l�nea original.
                        string[] partes = linea.Split(',');
                        // Una vez que se tienen las partes de la l�nea divididas, se utilizan para inicializar las
                        // propiedades de un nuevo objeto Cliente. Esto se hace asignando cada parte a la propiedad
                        // correspondiente del objeto Cliente, seg�n su posici�n en el array partes y lo agrego a la lista
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
                            InformeText= partes[10]

                        });
                    }
                }
                // Despu�s de cargar los datos del archivo, restablecer los enlaces del BindingSource
                bindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos desde el archivo: {ex.Message}", "Error Este archivo no es compatible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
