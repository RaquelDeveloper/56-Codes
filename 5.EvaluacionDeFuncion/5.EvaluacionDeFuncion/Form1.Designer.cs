namespace _5.EvaluacionDeFuncion
{
    partial class vista
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
            X = new TextBox();
            Resultado = new TextBox();
            Calcular = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // X
            // 
            X.Location = new Point(91, 132);
            X.Name = "X";
            X.Size = new Size(248, 27);
            X.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(91, 294);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(248, 27);
            Resultado.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(91, 212);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(248, 36);
            Calcular.TabIndex = 2;
            Calcular.Text = "CALCULAR";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 86);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el valor de X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 20);
            label2.Name = "label2";
            label2.Size = new Size(234, 20);
            label2.TabIndex = 4;
            label2.Text = "Ecuación:  Y=5x^4+2x^3+3x^2+7";
            // 
            // vista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(X);
            Name = "vista";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox X;
        private TextBox Resultado;
        private Button Calcular;
        private Label label1;
        private Label label2;
    }
}
