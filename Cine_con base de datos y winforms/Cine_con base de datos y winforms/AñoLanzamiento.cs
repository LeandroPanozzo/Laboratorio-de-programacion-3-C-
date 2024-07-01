using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_con_base_de_datos_y_winforms
{
    public partial class AñoLanzamiento : Form
    {
        public DateTime fechaSeleccionadalanzamiento { get; set; }
        public DateTime horaLanzamiento { get; set; }
        public DateTime fechaYHoraSeleccionadaLanzamiento { get; set; }
        public AñoLanzamiento()
        {
            InitializeComponent();
        }

        private void AñoLanzamiento_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            fechaSeleccionadalanzamiento = monthCalendar1.SelectionRange.Start;
            horaLanzamiento = dateTimePicker1.Value;
            fechaYHoraSeleccionadaLanzamiento = new DateTime(
                fechaSeleccionadalanzamiento.Year,
                fechaSeleccionadalanzamiento.Month,
                fechaSeleccionadalanzamiento.Day,
                horaLanzamiento.Hour,
                horaLanzamiento.Minute,
                horaLanzamiento.Second);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
