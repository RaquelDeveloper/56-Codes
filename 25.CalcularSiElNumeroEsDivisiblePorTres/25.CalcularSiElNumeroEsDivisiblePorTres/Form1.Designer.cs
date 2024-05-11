namespace _25.CalcularSiElNumeroEsDivisiblePorTres
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
            numero = new TextBox();
            Resultado = new TextBox();
            Verificar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // numero
            // 
            numero.Location = new Point(297, 97);
            numero.Name = "numero";
            numero.Size = new Size(144, 27);
            numero.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(297, 226);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(144, 27);
            Resultado.TabIndex = 1;
            // 
            // Verificar
            // 
            Verificar.Location = new Point(297, 170);
            Verificar.Name = "Verificar";
            Verificar.Size = new Size(144, 29);
            Verificar.TabIndex = 2;
            Verificar.Text = "Verificar Numero";
            Verificar.UseVisualStyleBackColor = true;
            Verificar.Click += Verificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 57);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese un numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Verificar);
            Controls.Add(Resultado);
            Controls.Add(numero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero;
        private TextBox Resultado;
        private Button Verificar;
        private Label label1;
    }
}
