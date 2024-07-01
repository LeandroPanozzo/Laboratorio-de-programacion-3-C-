namespace Cine_con_base_de_datos_y_winforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            AgregarBoton = new Button();
            ModificarBoton = new Button();
            EliminarBoton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 224);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AgregarBoton
            // 
            AgregarBoton.Location = new Point(121, 284);
            AgregarBoton.Name = "AgregarBoton";
            AgregarBoton.Size = new Size(75, 23);
            AgregarBoton.TabIndex = 1;
            AgregarBoton.Text = "Agregar";
            AgregarBoton.UseVisualStyleBackColor = true;
            AgregarBoton.Click += AgregarBoton_Click;
            // 
            // ModificarBoton
            // 
            ModificarBoton.Location = new Point(309, 284);
            ModificarBoton.Name = "ModificarBoton";
            ModificarBoton.Size = new Size(75, 23);
            ModificarBoton.TabIndex = 2;
            ModificarBoton.Text = "Modificar";
            ModificarBoton.UseVisualStyleBackColor = true;
            ModificarBoton.Click += ModificarBoton_Click;
            // 
            // EliminarBoton
            // 
            EliminarBoton.Location = new Point(507, 284);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(75, 23);
            EliminarBoton.TabIndex = 3;
            EliminarBoton.Text = "Eliminar";
            EliminarBoton.UseVisualStyleBackColor = true;
            EliminarBoton.Click += EliminarBoton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 333);
            Controls.Add(EliminarBoton);
            Controls.Add(ModificarBoton);
            Controls.Add(AgregarBoton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AgregarBoton;
        private Button ModificarBoton;
        private Button EliminarBoton;
    }
}
