namespace Ingresar_y_buscar_archivos
{
    partial class Escribir_Archivo
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
            Descripcion = new Label();
            textBox1 = new TextBox();
            Guardar = new Button();
            Cancelar = new Button();
            SuspendLayout();
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(308, 9);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(142, 15);
            Descripcion.TabIndex = 0;
            Descripcion.Text = "Escriba el texto que desee";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 299);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Guardar
            // 
            Guardar.Location = new Point(253, 333);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(75, 23);
            Guardar.TabIndex = 2;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = true;
            Guardar.Click += Guardar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(413, 333);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 3;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Escribir_Archivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            Controls.Add(Cancelar);
            Controls.Add(Guardar);
            Controls.Add(textBox1);
            Controls.Add(Descripcion);
            Name = "Escribir_Archivo";
            Text = "Escribir_Archivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Descripcion;
        private TextBox textBox1;
        private Button Guardar;
        private Button Cancelar;
    }
}