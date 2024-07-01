using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;
namespace Cine_con_base_de_datos_y_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //cuando el formulario principal se carga. Llama al m�todo actualizar() para cargar los datos de la base de datos en el
            //DataGridView
            actualizar();
        }
        public void actualizar()
        {
            dataGridView1.DataSource = null;
            string coneccion = "Data Source=DESKTOP-2NK65V4\\SQLEXPRESS;Initial Catalog=CineYadonEtConectado;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection c = new SqlConnection(coneccion))
            {
                c.Open();
                string query = "SELECT * FROM peliculas";
                /*
                 * SqlDataAdapter se utiliza para llenar un DataSet o un DataTable con los datos de una fuente de datos. Tambi�n se
                 * puede utilizar para actualizar la fuente de datos a partir de un DataSet o DataTable modificado. En el contexto de 
                 * la instrucci�n SqlDataAdapter(query, c), se est� creando una instancia del SqlDataAdapter utilizando una consulta 
                 * SQL y una conexi�n a la base de datos. 
                 * query: Es una cadena de texto que contiene una consulta SQL. En tu caso, es la consulta SELECT * FROM peliculas, que selecciona todos los registros de la tabla peliculas.
                   c: Es una instancia de SqlConnection que representa la conexi�n a la base de datos SQL Server. Esta conexi�n debe 
                   estar abierta antes de que el SqlDataAdapter pueda utilizarse para llenar un DataTable.
                en mi c�digo, se utiliza SqlDataAdapter para ejecutar una consulta SQL y llenar un DataTable con los resultados
                 */
                //Aqu� se crea una nueva instancia de SqlDataAdapter utilizando la consulta query y la conexi�n c.
                SqlDataAdapter adapter = new SqlDataAdapter(query, c);
                //Se crea un DataTable vac�o y se utiliza el m�todo Fill del SqlDataAdapter para llenar el DataTable con los datos
                //obtenidos de la consulta SQL
                DataTable d = new DataTable();
                adapter.Fill(d);
                // Asigna el DataTable al DataGridView
                dataGridView1.DataSource = d;

                //SqlDataAdapter act�a como un puente entre la base de datos y un DataSet o DataTable. Se utiliza principalmente para
                //rellenar estos objetos con datos y, opcionalmente, para sincronizar los cambios realizados en estos objetos con la
                //base de datos.
                //DataTable se utiliza para almacenar datos tabulares en memoria, similar a una tabla en una base de datos
            }
        }
        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            using (GrillaModificacionYagregacion g = new GrillaModificacionYagregacion())
            {
                g.abrir = true;
                if (g.ShowDialog() == DialogResult.OK)
                {
                    if (g.CamposCompletos())//verifico si se agregaron todos los campos
                    {
                        string coneccions = "Data Source=DESKTOP-2NK65V4\\SQLEXPRESS;Initial Catalog=CineYadonEtConectado;Integrated Security=True;TrustServerCertificate=True";
                        using (SqlConnection c = new SqlConnection(coneccions))
                        {
                            c.Open();
                            string query = "INSERT INTO peliculas (Titulo, Director, A�oEstrenoDEPelicula, Genero, FechaYHoraParaver, SalaEnLaQueEstaDisponible, precio, asientosComprados)" +
                                "VALUES (@Titulo, @Director, @A�oEstrenoDEPelicula, @Genero, @FechaYHoraParaver, @SalaEnLaQueEstaDisponible, @precio, @asientosComprados);";

                            //SqlCommand se utiliza para ejecutar comandos en una base de datos SQL Server. Esta clase permite realizar
                            //consultas, ejecutar procedimientos almacenados y realizar operaciones de inserci�n, actualizaci�n y
                            //eliminaci�n de datos.
                            //Para crear un SqlCommand, necesitas proporcionar una consulta SQL o el nombre de un procedimiento
                            //almacenado, junto con un objeto SqlConnection que representa la conexi�n a la base de datos.
                            using (SqlCommand comando = new SqlCommand(query, c))
                            {
                                /*
                                  para insertar un nuevo registro en una base de datos SQL Server. Se est�n utilizando par�metros para
                                evitar la inyecci�n de SQL y para manejar los datos correctamente.
                                ej: A�ade un par�metro llamado @Titulo al comando SQL. El valor de este par�metro es g.peli.Titulo, 
                                que corresponde al t�tulo de la pel�cula.
                                Estas l�neas preparan y ejecutan un comando SQL para insertar un nuevo registro en la tabla peliculas 
                                de la base de datos. Cada AddWithValue agrega un par�metro al comando con su correspondiente valor.
                                Los par�metros aseguran que los datos proporcionados por el usuario nunca se interpretan como c�digo 
                                SQL. En lugar de construir una cadena SQL con valores de usuario incrustados, se utilizan marcadores de
                                posici�n (@Titulo, @Director, etc.), y los valores se pasan de manera segura a trav�s de los par�metros.
                                 */
                                comando.Parameters.AddWithValue("@Titulo", g.peli.Titulo);
                                comando.Parameters.AddWithValue("@Director", g.peli.Director);
                                comando.Parameters.AddWithValue("@A�oEstrenoDEPelicula", g.peli.Fecha);
                                comando.Parameters.AddWithValue("@genero", g.peli.Genero);
                                comando.Parameters.AddWithValue("@FechaYHoraParaver", g.peli.FechaVer);
                                comando.Parameters.AddWithValue("@SalaEnLaQueEstaDisponible", g.peli.SalaDisponible);
                                comando.Parameters.AddWithValue("@precio", g.peli.Precio);
                                comando.Parameters.AddWithValue("@asientosComprados", g.peli.CantidadAsientosComprados);
                                //ExecuteNonQuery env�a el comando a la base de datos y ejecuta la instrucci�n SQL, en este caso, una inserci�n
                                comando.ExecuteNonQuery();
                            }
                        }
                        actualizar();
                    }
                   
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarBoton_Click(object sender, EventArgs e)
        {
            using (GrillaModificacionYagregacion g = new GrillaModificacionYagregacion())
            {
                g.abrir = true;
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    /*
                     SelectedRows es una propiedad que devuelve una colecci�n de las filas seleccionadas actualmente.
                    [0] accede a la primera fila seleccionada. Si hay m�s de una fila seleccionada, solo se usa la primera.
                    si pongo el �ndice [0] a [1], estar�as accediendo a la segunda fila seleccionada en lugar de la primera. Esto 
                    significa que si el usuario seleccion� m�s de una fila en el DataGridView, este c�digo estar�a trabajando con la 
                    segunda fila seleccionada en lugar de la primera.
                     */
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    /*
                     selectedRow.Cells["PeliculaID"] accede a la celda de la columna con el nombre "PeliculaID"
                    Value obtiene el valor de esa celda. ToString() convierte el valor a una cadena (string). 
                    int.Parse(...) convierte la cadena a un entero (int)
                    g.peli es una instancia de la clase Peliculas dentro del formulario de modificaci�n GrillaModificacionYagregacion.
                    Para cada propiedad de g.peli, se accede a la celda correspondiente en selectedRow usando Cells["NombreDeLaColumna"].
                     */
                    int id = int.Parse(selectedRow.Cells["PeliculaID"].Value.ToString());
                    //Ej:selectedRow.Cells["Titulo"].Value devolver� "Inception", que se asigna a g.peli.Titulo
                    g.peli.Titulo = selectedRow.Cells["Titulo"].Value.ToString();
                    g.peli.Director = selectedRow.Cells["Director"].Value.ToString();
                    g.peli.Fecha = DateTime.Parse(selectedRow.Cells["A�oEstrenoDEPelicula"].Value.ToString());
                    g.peli.Genero = selectedRow.Cells["Genero"].Value.ToString();
                    g.peli.FechaVer = DateTime.Parse(selectedRow.Cells["FechaYHoraParaver"].Value.ToString());
                    g.peli.SalaDisponible = selectedRow.Cells["SalaEnLaQueEstaDisponible"].Value.ToString();
                    g.peli.Precio = decimal.Parse(selectedRow.Cells["precio"].Value.ToString());
                    g.peli.CantidadAsientosComprados = int.Parse(selectedRow.Cells["asientosComprados"].Value.ToString());

                    if (g.ShowDialog() == DialogResult.OK)
                    {
                        if (g.CamposCompletos())
                        {
                            /*
                             Se establece una conexi�n con la base de datos.
                            Se construye una consulta SQL para actualizar los datos de la pel�cula.
                            Se utilizan par�metros (@PeliculaID, @Titulo, etc.) para evitar inyecciones SQL.
                            Se ejecuta la consulta de actualizaci�n (comando.ExecuteNonQuery()).
                             */

                            string coneccions = "Data Source=DESKTOP-2NK65V4\\SQLEXPRESS;Initial Catalog=CineYadonEtConectado;Integrated Security=True;TrustServerCertificate=True";
                            using (SqlConnection c = new SqlConnection(coneccions))
                            {
                                c.Open();
                                string Updatequery = "UPDATE peliculas SET " +
                                    "Titulo = @Titulo, " +
                                    "Director = @Director, " +
                                    "A�oEstrenoDEPelicula = @A�oEstrenoDEPelicula, " +
                                    "Genero = @Genero, " +
                                    "FechaYHoraParaver = @FechaYHoraParaver, " +
                                    "SalaEnLaQueEstaDisponible = @SalaEnLaQueEstaDisponible, " +
                                    "precio = @precio, " +
                                    "asientosComprados = @asientosComprados " +
                                    "WHERE PeliculaID = @PeliculaID";

                                using (SqlCommand comando = new SqlCommand(Updatequery, c))
                                {
                                    comando.Parameters.AddWithValue("@PeliculaID", id);
                                    comando.Parameters.AddWithValue("@Titulo", g.peli.Titulo);
                                    comando.Parameters.AddWithValue("@Director", g.peli.Director);
                                    comando.Parameters.AddWithValue("@A�oEstrenoDEPelicula", g.peli.Fecha);
                                    comando.Parameters.AddWithValue("@Genero", g.peli.Genero);
                                    comando.Parameters.AddWithValue("@FechaYHoraParaver", g.peli.FechaVer);
                                    comando.Parameters.AddWithValue("@SalaEnLaQueEstaDisponible", g.peli.SalaDisponible);
                                    comando.Parameters.AddWithValue("@precio", g.peli.Precio);
                                    comando.Parameters.AddWithValue("@asientosComprados", g.peli.CantidadAsientosComprados);
                                    comando.ExecuteNonQuery();
                                }
                            }
                            actualizar();
                        }
                    }
                }
            }
        }


        private void EliminarBoton_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                /*
                 Aqu� se obtiene la fila seleccionada (selectedRow) del DataGridView. Luego, se accede a la celda correspondiente al 
                ID de la pel�cula ("PeliculaID") en esa fila, se obtiene su valor y se convierte a un entero (int), que se almacena en 
                la variable id
                 */
                int id = int.Parse(selectedRow.Cells["PeliculaID"].Value.ToString());
                string coneccions = "Data Source=DESKTOP-2NK65V4\\SQLEXPRESS;Initial Catalog=CineYadonEtConectado;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(coneccions))
                {
                    connection.Open();
                    /*
                     Se establece una conexi�n con la base de datos utilizando la cadena de conexi�n proporcionada (coneccions). Luego,
                    se crea un comando SQL para ejecutar la eliminaci�n de la pel�cula utilizando la instrucci�n DELETE. Se utiliza un
                    par�metro (@PeliculaID) para evitar la inyecci�n de SQL y se le asigna el valor del ID de la pel�cula que se va a 
                    eliminar. Finalmente, se ejecuta el comando para eliminar la pel�cula de la base de datos.
                     */
                    string deleteQuery = "Delete from peliculas where  PeliculaID = @PeliculaID";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                    {
                        deleteCommand.Parameters.AddWithValue("@PeliculaID", id);
                        deleteCommand.ExecuteNonQuery();
                    }
                }
                actualizar();
            }

        }
    }
}
