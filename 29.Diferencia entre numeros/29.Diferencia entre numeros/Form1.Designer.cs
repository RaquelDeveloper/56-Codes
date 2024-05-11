namespace _29.Diferencia_entre_numeros
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
            Numero1 = new TextBox();
            Numero2 = new TextBox();
            Resultado = new TextBox();
            Encontrar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Numero1
            // 
            Numero1.Location = new Point(204, 115);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(125, 27);
            Numero1.TabIndex = 0;
            // 
            // Numero2
            // 
            Numero2.Location = new Point(486, 115);
            Numero2.Name = "Numero2";
            Numero2.Size = new Size(125, 27);
            Numero2.TabIndex = 1;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(357, 267);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(125, 27);
            Resultado.TabIndex = 2;
            // 
            // Encontrar
            // 
            Encontrar.Location = new Point(357, 196);
            Encontrar.Name = "Encontrar";
            Encontrar.Size = new Size(125, 29);
            Encontrar.TabIndex = 3;
            Encontrar.Text = "Encontrar Diferencia";
            Encontrar.UseVisualStyleBackColor = true;
            Encontrar.Click += Encontrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 76);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 76);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Numero 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Encontrar);
            Controls.Add(Resultado);
            Controls.Add(Numero2);
            Controls.Add(Numero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numero1;
        private TextBox Numero2;
        private TextBox Resultado;
        private Button Encontrar;
        private Label label1;
        private Label label2;
    }
}
