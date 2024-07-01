namespace Cine_con_base_de_datos_y_winforms
{
    partial class FechaActual
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
            monthCalendar1 = new MonthCalendar();
            Aceptar = new Button();
            dateTimePicker1 = new DateTimePicker();
            SeleccionHora = new Label();
            SeleccionDia = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(283, 150);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(338, 324);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 1;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(338, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(80, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // SeleccionHora
            // 
            SeleccionHora.AutoSize = true;
            SeleccionHora.Location = new Point(324, 46);
            SeleccionHora.Name = "SeleccionHora";
            SeleccionHora.Size = new Size(102, 15);
            SeleccionHora.TabIndex = 3;
            SeleccionHora.Text = "Seleccione la hora";
            // 
            // SeleccionDia
            // 
            SeleccionDia.AutoSize = true;
            SeleccionDia.Location = new Point(332, 126);
            SeleccionDia.Name = "SeleccionDia";
            SeleccionDia.Size = new Size(94, 15);
            SeleccionDia.TabIndex = 4;
            SeleccionDia.Text = "Seleccione el dia";
            // 
            // FechaActual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SeleccionDia);
            Controls.Add(SeleccionHora);
            Controls.Add(dateTimePicker1);
            Controls.Add(Aceptar);
            Controls.Add(monthCalendar1);
            Name = "FechaActual";
            Text = "FechaActual";
            Load += FechaActual_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button Aceptar;
        private DateTimePicker dateTimePicker1;
        private Label SeleccionHora;
        private Label SeleccionDia;
    }
}