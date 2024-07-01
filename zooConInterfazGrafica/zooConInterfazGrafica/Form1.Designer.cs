namespace zooConInterfazGrafica
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
            MostarLista = new Button();
            Salir = new Button();
            SuspendLayout();
            // 
            // MostarLista
            // 
            MostarLista.Location = new Point(228, 152);
            MostarLista.Name = "MostarLista";
            MostarLista.Size = new Size(126, 23);
            MostarLista.TabIndex = 0;
            MostarLista.Text = "Mostrar Lista";
            MostarLista.UseVisualStyleBackColor = true;
            MostarLista.Click += MostarLista_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(482, 260);
            Salir.Name = "Salir";
            Salir.Size = new Size(75, 23);
            Salir.TabIndex = 1;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 373);
            Controls.Add(Salir);
            Controls.Add(MostarLista);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button MostarLista;
        private Button Salir;
    }
}
