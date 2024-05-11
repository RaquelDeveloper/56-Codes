namespace _18.RegresarUnNumeroAlRevez
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
            Palabra = new TextBox();
            Resultado = new TextBox();
            Invertir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Palabra
            // 
            Palabra.Location = new Point(279, 91);
            Palabra.Name = "Palabra";
            Palabra.Size = new Size(125, 27);
            Palabra.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(279, 218);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(125, 27);
            Resultado.TabIndex = 1;
            // 
            // Invertir
            // 
            Invertir.Location = new Point(274, 167);
            Invertir.Name = "Invertir";
            Invertir.Size = new Size(130, 29);
            Invertir.TabIndex = 2;
            Invertir.Text = "Invertir";
            Invertir.UseVisualStyleBackColor = true;
            Invertir.Click += Invertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 48);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese un palabra";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Invertir);
            Controls.Add(Resultado);
            Controls.Add(Palabra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Palabra;
        private TextBox Resultado;
        private Button Invertir;
        private Label label1;
    }
}
