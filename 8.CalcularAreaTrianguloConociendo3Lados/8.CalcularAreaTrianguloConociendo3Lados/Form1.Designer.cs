namespace _8.CalcularAreaTrianguloConociendo3Lados
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
            Lado1 = new TextBox();
            Resultado = new TextBox();
            Calcular = new Button();
            label1 = new Label();
            label2 = new Label();
            Lado2 = new TextBox();
            label3 = new Label();
            Lado3 = new TextBox();
            SuspendLayout();
            // 
            // Lado1
            // 
            Lado1.Location = new Point(81, 120);
            Lado1.Name = "Lado1";
            Lado1.Size = new Size(125, 27);
            Lado1.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(448, 203);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(166, 27);
            Resultado.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(448, 119);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(166, 29);
            Calcular.TabIndex = 2;
            Calcular.Text = "CALCULAR ÁREA";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 82);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Lado uno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 193);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Lado dos";
            // 
            // Lado2
            // 
            Lado2.Location = new Point(81, 231);
            Lado2.Name = "Lado2";
            Lado2.Size = new Size(125, 27);
            Lado2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 304);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Lado tres";
            // 
            // Lado3
            // 
            Lado3.Location = new Point(81, 342);
            Lado3.Name = "Lado3";
            Lado3.Size = new Size(125, 27);
            Lado3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Lado3);
            Controls.Add(label2);
            Controls.Add(Lado2);
            Controls.Add(label1);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(Lado1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Lado1;
        private TextBox Resultado;
        private Button Calcular;
        private Label label1;
        private Label label2;
        private TextBox Lado2;
        private Label label3;
        private TextBox Lado3;
    }
}
