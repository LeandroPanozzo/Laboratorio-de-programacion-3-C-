namespace zooConInterfazGrafica
{
    partial class Animales
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
            dataGridView1 = new DataGridView();
            Nuevo = new Button();
            Modificar = new Button();
            Borrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(626, 165);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nuevo
            // 
            Nuevo.Location = new Point(44, 210);
            Nuevo.Name = "Nuevo";
            Nuevo.Size = new Size(99, 34);
            Nuevo.TabIndex = 1;
            Nuevo.Text = "Nuevo";
            Nuevo.UseVisualStyleBackColor = true;
            Nuevo.Click += Nuevo_Click;
            // 
            // Modificar
            // 
            Modificar.Location = new Point(298, 210);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(88, 34);
            Modificar.TabIndex = 2;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(532, 210);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(84, 34);
            Borrar.TabIndex = 3;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Animales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 372);
            Controls.Add(Borrar);
            Controls.Add(Modificar);
            Controls.Add(Nuevo);
            Controls.Add(dataGridView1);
            Name = "Animales";
            Text = "Animales";
            Load += Animales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Nuevo;
        private Button Modificar;
        private Button Borrar;
    }
}