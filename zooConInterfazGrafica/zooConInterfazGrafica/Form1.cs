namespace zooConInterfazGrafica
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostarLista_Click(object sender, EventArgs e)
        {
            Animales ani = new Animales();
            ani.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
