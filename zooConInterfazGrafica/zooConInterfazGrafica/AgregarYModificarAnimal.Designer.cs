namespace zooConInterfazGrafica
{
    partial class AgregarYModificarAnimal
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
            textBox_nombre = new TextBox();
            textBox_tipo = new TextBox();
            textBox_Comida = new TextBox();
            Nombre = new Label();
            Tipo = new Label();
            Comida = new Label();
            button_Ok = new Button();
            button_Cancelar = new Button();
            button1_cancelar = new Button();
            SuspendLayout();
            // 
            // textBox_nombre
            // 
            textBox_nombre.Location = new Point(256, 47);
            textBox_nombre.Name = "textBox_nombre";
            textBox_nombre.Size = new Size(269, 23);
            textBox_nombre.TabIndex = 0;
            textBox_nombre.TextChanged += textBox_nombre_TextChanged;
            // 
            // textBox_tipo
            // 
            textBox_tipo.Location = new Point(256, 117);
            textBox_tipo.Name = "textBox_tipo";
            textBox_tipo.Size = new Size(269, 23);
            textBox_tipo.TabIndex = 1;
            textBox_tipo.TextChanged += textBox_tipo_TextChanged;
            // 
            // textBox_Comida
            // 
            textBox_Comida.Location = new Point(256, 178);
            textBox_Comida.Name = "textBox_Comida";
            textBox_Comida.Size = new Size(269, 23);
            textBox_Comida.TabIndex = 2;
            textBox_Comida.TextChanged += textBox_Comida_TextChanged;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(101, 52);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // Tipo
            // 
            Tipo.AutoSize = true;
            Tipo.Location = new Point(100, 121);
            Tipo.Name = "Tipo";
            Tipo.Size = new Size(30, 15);
            Tipo.TabIndex = 4;
            Tipo.Text = "Tipo";
            // 
            // Comida
            // 
            Comida.AutoSize = true;
            Comida.Location = new Point(103, 184);
            Comida.Name = "Comida";
            Comida.Size = new Size(47, 15);
            Comida.TabIndex = 5;
            Comida.Text = "comida";
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(255, 261);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(75, 23);
            button_Ok.TabIndex = 6;
            button_Ok.Text = "Ok";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(0, 0);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(75, 23);
            button_Cancelar.TabIndex = 0;
            // 
            // button1_cancelar
            // 
            button1_cancelar.Location = new Point(471, 261);
            button1_cancelar.Name = "button1_cancelar";
            button1_cancelar.Size = new Size(75, 23);
            button1_cancelar.TabIndex = 7;
            button1_cancelar.Text = "Cancelar";
            button1_cancelar.UseVisualStyleBackColor = true;
            button1_cancelar.Click += button1_cancelar_Click;
            // 
            // AgregarYModificarAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1_cancelar);
            Controls.Add(button_Cancelar);
            Controls.Add(button_Ok);
            Controls.Add(Comida);
            Controls.Add(Tipo);
            Controls.Add(Nombre);
            Controls.Add(textBox_Comida);
            Controls.Add(textBox_tipo);
            Controls.Add(textBox_nombre);
            Name = "AgregarYModificarAnimal";
            Text = "AgregarYModificarAnimal";
            Load += AgregarYModificarAnimal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_nombre;
        private TextBox textBox_tipo;
        private TextBox textBox_Comida;
        private Label Nombre;
        private Label Tipo;
        private Label Comida;
        private Button button_Ok;
        private Button button_Cancelar;
        private Button button1_cancelar;
    }
}