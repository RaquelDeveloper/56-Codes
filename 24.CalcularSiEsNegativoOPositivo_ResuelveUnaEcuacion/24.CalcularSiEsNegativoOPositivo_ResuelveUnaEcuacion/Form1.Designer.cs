namespace _24.CalcularSiEsNegativoOPositivo_ResuelveUnaEcuacion
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
            Numero = new TextBox();
            A = new TextBox();
            Resultado = new TextBox();
            label1 = new Label();
            Estado = new Label();
            CalcularNumero = new Button();
            CalcularEcuacion = new Button();
            Ecuacion = new Label();
            SuspendLayout();
            // 
            // Numero
            // 
            Numero.Location = new Point(300, 82);
            Numero.Name = "Numero";
            Numero.Size = new Size(125, 27);
            Numero.TabIndex = 0;
            // 
            // A
            // 
            A.Location = new Point(300, 222);
            A.Name = "A";
            A.Size = new Size(137, 27);
            A.TabIndex = 1;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(300, 338);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(137, 27);
            Resultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 44);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresa un número";
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Location = new Point(672, 23);
            Estado.Name = "Estado";
            Estado.Size = new Size(54, 20);
            Estado.TabIndex = 4;
            Estado.Text = "Estado";
            // 
            // CalcularNumero
            // 
            CalcularNumero.Location = new Point(300, 141);
            CalcularNumero.Name = "CalcularNumero";
            CalcularNumero.Size = new Size(137, 29);
            CalcularNumero.TabIndex = 5;
            CalcularNumero.Text = "Calcular Número";
            CalcularNumero.UseVisualStyleBackColor = true;
            CalcularNumero.Click += CalcularNumero_Click;
            // 
            // CalcularEcuacion
            // 
            CalcularEcuacion.Location = new Point(300, 281);
            CalcularEcuacion.Name = "CalcularEcuacion";
            CalcularEcuacion.Size = new Size(137, 29);
            CalcularEcuacion.TabIndex = 6;
            CalcularEcuacion.Text = "Calcular ecuación";
            CalcularEcuacion.UseVisualStyleBackColor = true;
            CalcularEcuacion.Click += CalcularEcuacion_Click;
            // 
            // Ecuacion
            // 
            Ecuacion.AutoSize = true;
            Ecuacion.Location = new Point(465, 281);
            Ecuacion.Name = "Ecuacion";
            Ecuacion.Size = new Size(68, 20);
            Ecuacion.TabIndex = 7;
            Ecuacion.Text = "Ecuación";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ecuacion);
            Controls.Add(CalcularEcuacion);
            Controls.Add(CalcularNumero);
            Controls.Add(Estado);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(A);
            Controls.Add(Numero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numero;
        private TextBox A;
        private TextBox Resultado;
        private Label label1;
        private Label Estado;
        private Button CalcularNumero;
        private Button CalcularEcuacion;
        private Label Ecuacion;
    }
}
