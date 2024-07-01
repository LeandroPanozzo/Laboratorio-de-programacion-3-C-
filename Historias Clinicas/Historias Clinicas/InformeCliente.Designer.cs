namespace Historias_Clinicas
{
    partial class InformeCliente
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
            textBox1 = new TextBox();
            AceptarBtn = new Button();
            CancelarBtn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(776, 225);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // AceptarBtn
            // 
            AceptarBtn.Anchor = AnchorStyles.Bottom;
            AceptarBtn.Location = new Point(223, 260);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(75, 23);
            AceptarBtn.TabIndex = 1;
            AceptarBtn.Text = "Aceptar";
            AceptarBtn.UseVisualStyleBackColor = true;
            AceptarBtn.Click += AceptarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Anchor = AnchorStyles.Bottom;
            CancelarBtn.Location = new Point(471, 260);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(75, 23);
            CancelarBtn.TabIndex = 2;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // InformeCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 298);
            Controls.Add(CancelarBtn);
            Controls.Add(AceptarBtn);
            Controls.Add(textBox1);
            Name = "InformeCliente";
            Text = "InformeCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button AceptarBtn;
        private Button CancelarBtn;
    }
}