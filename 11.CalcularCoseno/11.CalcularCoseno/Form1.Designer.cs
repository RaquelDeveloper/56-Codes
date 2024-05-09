namespace _11.CalcularCoseno
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
            x = new TextBox();
            Resultado = new TextBox();
            Calcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // x
            // 
            x.Location = new Point(262, 135);
            x.Name = "x";
            x.Size = new Size(177, 27);
            x.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(262, 279);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(177, 27);
            Resultado.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(262, 211);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(177, 40);
            Calcular.TabIndex = 2;
            Calcular.Text = "Calcular coseno";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 78);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresa el valor a calcular";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(x);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox x;
        private TextBox Resultado;
        private Button Calcular;
        private Label label1;
    }
}
