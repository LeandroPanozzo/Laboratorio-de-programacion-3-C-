namespace Cine_con_base_de_datos_y_winforms
{
    partial class AñoLanzamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Aceptar = new Button();
            monthCalendar1 = new MonthCalendar();
            fechaLanzamiento = new Label();
            dateTimePicker1 = new DateTimePicker();
            SeleccionHora = new Label();
            SuspendLayout();
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(280, 303);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 0;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(221, 129);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // fechaLanzamiento
            // 
            fechaLanzamiento.AutoSize = true;
            fechaLanzamiento.Location = new Point(221, 105);
            fechaLanzamiento.Name = "fechaLanzamiento";
            fechaLanzamiento.Size = new Size(179, 15);
            fechaLanzamiento.TabIndex = 2;
            fechaLanzamiento.Text = "Seleccione fecha de lanzamiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(280, 68);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(68, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // SeleccionHora
            // 
            SeleccionHora.AutoSize = true;
            SeleccionHora.Location = new Point(266, 37);
            SeleccionHora.Name = "SeleccionHora";
            SeleccionHora.Size = new Size(102, 15);
            SeleccionHora.TabIndex = 4;
            SeleccionHora.Text = "Seleccione la hora";
            // 
            // AñoLanzamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 347);
            Controls.Add(SeleccionHora);
            Controls.Add(dateTimePicker1);
            Controls.Add(fechaLanzamiento);
            Controls.Add(monthCalendar1);
            Controls.Add(Aceptar);
            Name = "AñoLanzamiento";
            Text = "AñoLanzamiento";
            Load += AñoLanzamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private MonthCalendar monthCalendar1;
        private Label fechaLanzamiento;
        private DateTimePicker dateTimePicker1;
        private Label SeleccionHora;
    }
}