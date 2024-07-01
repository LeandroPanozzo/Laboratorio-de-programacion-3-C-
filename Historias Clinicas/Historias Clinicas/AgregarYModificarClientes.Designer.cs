namespace Historias_Clinicas
{
    partial class AgregarYModificarClientes
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
            Apellido_paciente = new Label();
            Num_telefono = new Label();
            DireccionCliente = new Label();
            CorreoCliente = new Label();
            textBoxApellido = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxCorreo = new TextBox();
            Nom_paciente = new Label();
            Aceptar = new Button();
            Cancelar = new Button();
            textBoxNombre = new TextBox();
            label1 = new Label();
            GeneroBox1 = new TextBox();
            label2 = new Label();
            ConsultaBox2 = new TextBox();
            Cirta = new Label();
            dateTimePickerFecha = new DateTimePicker();
            dateTimePickerHora = new DateTimePicker();
            label3 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            GenerarInformeBtn = new Button();
            SuspendLayout();
            // 
            // Apellido_paciente
            // 
            Apellido_paciente.AutoSize = true;
            Apellido_paciente.Location = new Point(12, 80);
            Apellido_paciente.Name = "Apellido_paciente";
            Apellido_paciente.Size = new Size(118, 15);
            Apellido_paciente.TabIndex = 1;
            Apellido_paciente.Text = "Apellido del paciente";
            // 
            // Num_telefono
            // 
            Num_telefono.AutoSize = true;
            Num_telefono.Location = new Point(12, 138);
            Num_telefono.Name = "Num_telefono";
            Num_telefono.Size = new Size(181, 15);
            Num_telefono.TabIndex = 3;
            Num_telefono.Text = "Numero de telefono del paciente";
            // 
            // DireccionCliente
            // 
            DireccionCliente.AutoSize = true;
            DireccionCliente.Location = new Point(12, 167);
            DireccionCliente.Name = "DireccionCliente";
            DireccionCliente.Size = new Size(124, 15);
            DireccionCliente.TabIndex = 4;
            DireccionCliente.Text = "Direccion del paciente";
            // 
            // CorreoCliente
            // 
            CorreoCliente.AutoSize = true;
            CorreoCliente.Location = new Point(12, 196);
            CorreoCliente.Name = "CorreoCliente";
            CorreoCliente.Size = new Size(110, 15);
            CorreoCliente.TabIndex = 5;
            CorreoCliente.Text = "Correo del paciente";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxApellido.Location = new Point(207, 72);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(558, 23);
            textBoxApellido.TabIndex = 7;
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTelefono.Location = new Point(207, 130);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(558, 23);
            textBoxTelefono.TabIndex = 9;
            textBoxTelefono.TextChanged += textBoxTelefono_TextChanged;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDireccion.Location = new Point(207, 159);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(558, 23);
            textBoxDireccion.TabIndex = 10;
            textBoxDireccion.TextChanged += textBoxDireccion_TextChanged;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCorreo.Location = new Point(207, 188);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(558, 23);
            textBoxCorreo.TabIndex = 11;
            textBoxCorreo.TextChanged += textBoxCorreo_TextChanged;
            // 
            // Nom_paciente
            // 
            Nom_paciente.AutoSize = true;
            Nom_paciente.Location = new Point(12, 51);
            Nom_paciente.Name = "Nom_paciente";
            Nom_paciente.Size = new Size(118, 15);
            Nom_paciente.TabIndex = 12;
            Nom_paciente.Text = "Nombre del paciente";
            Nom_paciente.Click += Nom_paciente_Click;
            // 
            // Aceptar
            // 
            Aceptar.Anchor = AnchorStyles.Bottom;
            Aceptar.Location = new Point(206, 309);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 13;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Anchor = AnchorStyles.Bottom;
            Cancelar.Location = new Point(345, 309);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 14;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNombre.Location = new Point(207, 43);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(558, 23);
            textBoxNombre.TabIndex = 15;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 16;
            label1.Text = "Genero";
            // 
            // GeneroBox1
            // 
            GeneroBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GeneroBox1.Location = new Point(207, 101);
            GeneroBox1.Name = "GeneroBox1";
            GeneroBox1.Size = new Size(558, 23);
            GeneroBox1.TabIndex = 17;
            GeneroBox1.TextChanged += GeneroBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 226);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 18;
            label2.Text = "Motivo de consulta";
            // 
            // ConsultaBox2
            // 
            ConsultaBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConsultaBox2.Location = new Point(207, 218);
            ConsultaBox2.Name = "ConsultaBox2";
            ConsultaBox2.Size = new Size(558, 23);
            ConsultaBox2.TabIndex = 19;
            ConsultaBox2.TextChanged += ConsultaBox2_TextChanged;
            // 
            // Cirta
            // 
            Cirta.AutoSize = true;
            Cirta.Location = new Point(205, 251);
            Cirta.Name = "Cirta";
            Cirta.Size = new Size(76, 15);
            Cirta.TabIndex = 20;
            Cirta.Text = "Fecha de cita";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerFecha.Location = new Point(205, 280);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(86, 23);
            dateTimePickerFecha.TabIndex = 21;
            dateTimePickerFecha.ValueChanged += dateTimePickerFecha_ValueChanged;
            // 
            // dateTimePickerHora
            // 
            dateTimePickerHora.Format = DateTimePickerFormat.Time;
            dateTimePickerHora.Location = new Point(345, 280);
            dateTimePickerHora.Name = "dateTimePickerHora";
            dateTimePickerHora.ShowUpDown = true;
            dateTimePickerHora.Size = new Size(82, 23);
            dateTimePickerHora.TabIndex = 22;
            dateTimePickerHora.Value = new DateTime(2024, 6, 1, 8, 59, 0, 0);
            dateTimePickerHora.ValueChanged += dateTimePickerHora_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 251);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 23;
            label3.Text = "Hora de la cita";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // GenerarInformeBtn
            // 
            GenerarInformeBtn.Anchor = AnchorStyles.Bottom;
            GenerarInformeBtn.Location = new Point(634, 309);
            GenerarInformeBtn.Name = "GenerarInformeBtn";
            GenerarInformeBtn.Size = new Size(131, 23);
            GenerarInformeBtn.TabIndex = 24;
            GenerarInformeBtn.Text = "Generar Informe";
            GenerarInformeBtn.UseVisualStyleBackColor = true;
            GenerarInformeBtn.Click += GenerarInformeBtn_Click;
            // 
            // AgregarYModificarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 341);
            Controls.Add(GenerarInformeBtn);
            Controls.Add(label3);
            Controls.Add(dateTimePickerHora);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(Cirta);
            Controls.Add(ConsultaBox2);
            Controls.Add(label2);
            Controls.Add(GeneroBox1);
            Controls.Add(label1);
            Controls.Add(textBoxNombre);
            Controls.Add(Cancelar);
            Controls.Add(Aceptar);
            Controls.Add(Nom_paciente);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxApellido);
            Controls.Add(CorreoCliente);
            Controls.Add(DireccionCliente);
            Controls.Add(Num_telefono);
            Controls.Add(Apellido_paciente);
            Name = "AgregarYModificarClientes";
            Text = "AgregarYModificarClientes";
            Load += AgregarYModificarClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Apellido_paciente;
        private Label Num_telefono;
        private Label DireccionCliente;
        private Label CorreoCliente;
        private TextBox textBoxApellido;
        private TextBox textBoxTelefono;
        private TextBox textBoxDireccion;
        private TextBox textBoxCorreo;
        private Label Nom_paciente;
        private Button Aceptar;
        private Button Cancelar;
        private TextBox textBoxNombre;
        private Label label1;
        private TextBox GeneroBox1;
        private Label label2;
        private TextBox ConsultaBox2;
        private Label Cirta;
        private DateTimePicker dateTimePickerFecha;
        private DateTimePicker dateTimePickerHora;
        private Label label3;
        private SaveFileDialog saveFileDialog1;
        private Button GenerarInformeBtn;
    }
}