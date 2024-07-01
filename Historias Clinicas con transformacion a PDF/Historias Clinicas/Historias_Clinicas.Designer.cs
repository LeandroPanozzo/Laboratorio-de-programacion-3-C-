namespace Historias_Clinicas
{
    partial class Historias_Clinicas
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
            Nuevo = new Button();
            Modificar = new Button();
            Borrar = new Button();
            AbrirArchivoBtn = new Button();
            GuardarArchivoBtn = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            ExportarPDFBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 178);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nuevo
            // 
            Nuevo.Anchor = AnchorStyles.Bottom;
            Nuevo.Location = new Point(133, 247);
            Nuevo.Name = "Nuevo";
            Nuevo.Size = new Size(75, 23);
            Nuevo.TabIndex = 1;
            Nuevo.Text = "Nuevo";
            Nuevo.UseVisualStyleBackColor = true;
            Nuevo.Click += Nuevo_Click;
            // 
            // Modificar
            // 
            Modificar.Anchor = AnchorStyles.Bottom;
            Modificar.Location = new Point(253, 247);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(75, 23);
            Modificar.TabIndex = 2;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // Borrar
            // 
            Borrar.Anchor = AnchorStyles.Bottom;
            Borrar.Location = new Point(498, 247);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(75, 23);
            Borrar.TabIndex = 3;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // AbrirArchivoBtn
            // 
            AbrirArchivoBtn.Anchor = AnchorStyles.Bottom;
            AbrirArchivoBtn.Location = new Point(12, 247);
            AbrirArchivoBtn.Name = "AbrirArchivoBtn";
            AbrirArchivoBtn.Size = new Size(75, 23);
            AbrirArchivoBtn.TabIndex = 4;
            AbrirArchivoBtn.Text = "Abrir archivo";
            AbrirArchivoBtn.UseVisualStyleBackColor = true;
            AbrirArchivoBtn.Click += AbrirArchivoBtn_Click;
            // 
            // GuardarArchivoBtn
            // 
            GuardarArchivoBtn.Anchor = AnchorStyles.Bottom;
            GuardarArchivoBtn.Enabled = false;
            GuardarArchivoBtn.Location = new Point(374, 247);
            GuardarArchivoBtn.Name = "GuardarArchivoBtn";
            GuardarArchivoBtn.Size = new Size(75, 23);
            GuardarArchivoBtn.TabIndex = 5;
            GuardarArchivoBtn.Text = "Guardar archivo";
            GuardarArchivoBtn.UseVisualStyleBackColor = true;
            GuardarArchivoBtn.Click += GuardarArchivoBtn_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // ExportarPDFBtn
            // 
            ExportarPDFBtn.Anchor = AnchorStyles.Bottom;
            ExportarPDFBtn.Location = new Point(674, 247);
            ExportarPDFBtn.Name = "ExportarPDFBtn";
            ExportarPDFBtn.Size = new Size(103, 23);
            ExportarPDFBtn.TabIndex = 6;
            ExportarPDFBtn.Text = "Expotar a PDF";
            ExportarPDFBtn.UseVisualStyleBackColor = true;
            ExportarPDFBtn.Click += ExportarPDFBtn_Click;
            // 
            // Historias_Clinicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 329);
            Controls.Add(ExportarPDFBtn);
            Controls.Add(GuardarArchivoBtn);
            Controls.Add(AbrirArchivoBtn);
            Controls.Add(Borrar);
            Controls.Add(Modificar);
            Controls.Add(Nuevo);
            Controls.Add(dataGridView1);
            Name = "Historias_Clinicas";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Nuevo;
        private Button Modificar;
        private Button Borrar;
        private Button AbrirArchivoBtn;
        private Button GuardarArchivoBtn;
        private FolderBrowserDialog folderBrowserDialog1;
        private OpenFileDialog openFileDialog1;
        private Button ExportarPDFBtn;
    }
}
