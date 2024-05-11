namespace _21.VerificaSiEsNegativo
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
            Calcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Numero
            // 
            Numero.Location = new Point(264, 101);
            Numero.Name = "Numero";
            Numero.Size = new Size(242, 27);
            Numero.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(264, 212);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(242, 27);
            Resultado.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(264, 157);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(242, 29);
            Calcular.TabIndex = 2;
            Calcular.Text = "Calcular si es positivo o negativo";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 61);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese un número";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Calcular);
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
        private Button Calcular;
        private Label label1;
    }
}
