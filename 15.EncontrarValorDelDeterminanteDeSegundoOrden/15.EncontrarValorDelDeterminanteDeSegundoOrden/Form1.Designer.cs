namespace _15.EncontrarValorDelDeterminanteDeSegundoOrden
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
            Resultado = new TextBox();
            a_11 = new TextBox();
            a_21 = new TextBox();
            Calcular = new Button();
            a_22 = new TextBox();
            a_12 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Resultado
            // 
            Resultado.Location = new Point(220, 254);
            Resultado.Multiline = true;
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(320, 184);
            Resultado.TabIndex = 0;
            Resultado.TextAlign = HorizontalAlignment.Center;
            // 
            // a_11
            // 
            a_11.Location = new Point(337, 75);
            a_11.Name = "a_11";
            a_11.Size = new Size(31, 27);
            a_11.TabIndex = 1;
            // 
            // a_21
            // 
            a_21.Location = new Point(337, 124);
            a_21.Name = "a_21";
            a_21.Size = new Size(31, 27);
            a_21.TabIndex = 2;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(220, 202);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(320, 29);
            Calcular.TabIndex = 5;
            Calcular.Text = "Calcular determinante de segundo orden";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // a_22
            // 
            a_22.Location = new Point(392, 124);
            a_22.Name = "a_22";
            a_22.Size = new Size(31, 27);
            a_22.TabIndex = 7;
            // 
            // a_12
            // 
            a_12.Location = new Point(392, 75);
            a_12.Name = "a_12";
            a_12.Size = new Size(31, 27);
            a_12.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 36);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 8;
            label1.Text = "Ingrese los valores de la matriz 2x2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(a_22);
            Controls.Add(a_12);
            Controls.Add(Calcular);
            Controls.Add(a_21);
            Controls.Add(a_11);
            Controls.Add(Resultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Resultado;
        private TextBox a_11;
        private TextBox a_21;
        private Button Calcular;
        private TextBox a_22;
        private TextBox a_12;
        private Label label1;
    }
}
