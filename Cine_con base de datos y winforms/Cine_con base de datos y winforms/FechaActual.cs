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

    public partial class FechaActual : Form
    {
        public DateTime fechaDeCartelera { get; set; }
        public DateTime horaDeCartelera { get; set; }
        public DateTime fechaYHoraSeleccionada { get; set; }
        public FechaActual()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            fechaDeCartelera = monthCalendar1.SelectionRange.Start; //asigna el valor del calendario que seleccionamos
            horaDeCartelera = dateTimePicker1.Value; //asigna el valor de la hora que seleccionamos
            fechaYHoraSeleccionada = new DateTime(
                fechaDeCartelera.Year,
                fechaDeCartelera.Month,
                fechaDeCartelera.Day,
                horaDeCartelera.Hour,
                horaDeCartelera.Minute,
                horaDeCartelera.Second);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FechaActual_Load(object sender, EventArgs e)
        {

        }
    }
}
