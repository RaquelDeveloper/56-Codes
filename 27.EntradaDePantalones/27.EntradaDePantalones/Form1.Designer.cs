namespace _27.EntradaDePantalones
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
            Resultado = new TextBox();
            CalcularCosto = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Numero
            // 
            Numero.Location = new Point(325, 82);
            Numero.Name = "Numero";
            Numero.Size = new Size(125, 27);
            Numero.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(325, 232);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(125, 27);
            Resultado.TabIndex = 1;
            // 
            // CalcularCosto
            // 
            CalcularCosto.Location = new Point(325, 168);
            CalcularCosto.Name = "CalcularCosto";
            CalcularCosto.Size = new Size(125, 29);
            CalcularCosto.TabIndex = 2;
            CalcularCosto.Text = "Calcular";
            CalcularCosto.UseVisualStyleBackColor = true;
            CalcularCosto.Click += CalcularCosto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 40);
            label1.Name = "label1";
            label1.Size = new Size(233, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la cantidad de pantalones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CalcularCosto);
            Controls.Add(Resultado);
            Controls.Add(Numero);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numero;
        private TextBox Resultado;
        private Button CalcularCosto;
        private Label label1;
    }
}
