namespace Ingresar_y_buscar_archivos
{
    partial class Abrir_Archivo
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
            Abrir = new Button();
            Escribir = new Button();
            Salir = new Button();
            openFileDialog1 = new OpenFileDialog();
            Mostrar = new Button();
            especificarElArchivoSeleccionado = new Label();
            NuevoTxt = new Button();
            SuspendLayout();
            // 
            // Abrir
            // 
            Abrir.Location = new Point(250, 205);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(75, 23);
            Abrir.TabIndex = 0;
            Abrir.Text = "Abrir";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // Escribir
            // 
            Escribir.Location = new Point(453, 205);
            Escribir.Name = "Escribir";
            Escribir.Size = new Size(75, 23);
            Escribir.TabIndex = 1;
            Escribir.Text = "Escribir";
            Escribir.UseVisualStyleBackColor = true;
            Escribir.Click += Escribir_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(550, 205);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 2;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Mostrar
            // 
            Mostrar.Location = new Point(359, 205);
            Mostrar.Name = "Mostrar";
            Mostrar.Size = new Size(75, 23);
            Mostrar.TabIndex = 3;
            Mostrar.Text = "Mostrar archivo";
            Mostrar.UseVisualStyleBackColor = true;
            Mostrar.Click += Mostrar_Click;
            // 
            // especificarElArchivoSeleccionado
            // 
            especificarElArchivoSeleccionado.AutoSize = true;
            especificarElArchivoSeleccionado.Location = new Point(250, 89);
            especificarElArchivoSeleccionado.Name = "especificarElArchivoSeleccionado";
            especificarElArchivoSeleccionado.RightToLeft = RightToLeft.Yes;
            especificarElArchivoSeleccionado.Size = new Size(222, 15);
            especificarElArchivoSeleccionado.TabIndex = 4;
            especificarElArchivoSeleccionado.Text = "Aqui se mostrara el archivo seleccionado";
            especificarElArchivoSeleccionado.TextAlign = ContentAlignment.MiddleCenter;
            especificarElArchivoSeleccionado.Click += especificarElArchivoSeleccionado_Click;
            // 
            // NuevoTxt
            // 
            NuevoTxt.Location = new Point(136, 205);
            NuevoTxt.Name = "NuevoTxt";
            NuevoTxt.Size = new Size(75, 23);
            NuevoTxt.TabIndex = 5;
            NuevoTxt.Text = "Nuevo";
            NuevoTxt.UseVisualStyleBackColor = true;
            NuevoTxt.Click += NuevoTxt_Click;
            // 
            // Abrir_Archivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NuevoTxt);
            Controls.Add(especificarElArchivoSeleccionado);
            Controls.Add(Mostrar);
            Controls.Add(Salir);
            Controls.Add(Escribir);
            Controls.Add(Abrir);
            Name = "Abrir_Archivo";
            Text = "Abrir_Archivo";
            Load += Abrir_Archivo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Abrir;
        private Button Escribir;
        private Button Salir;
        private OpenFileDialog openFileDialog1;
        private Button Mostrar;
        private Label especificarElArchivoSeleccionado;
        private Button NuevoTxt;
    }
}