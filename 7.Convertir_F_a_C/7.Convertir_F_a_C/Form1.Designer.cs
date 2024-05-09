namespace _7.Convertir_F_a_C
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
            F = new TextBox();
            label1 = new Label();
            Resultado = new TextBox();
            Calcular = new Button();
            SuspendLayout();
            // 
            // F
            // 
            F.Location = new Point(248, 117);
            F.Name = "F";
            F.Size = new Size(196, 27);
            F.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 68);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la temperatura en F°";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(248, 278);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(196, 27);
            Resultado.TabIndex = 2;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(248, 195);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(196, 29);
            Calcular.TabIndex = 3;
            Calcular.Text = "CONVERTIR A C°";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(label1);
            Controls.Add(F);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox F;
        private Label label1;
        private TextBox Resultado;
        private Button Calcular;
    }
}
