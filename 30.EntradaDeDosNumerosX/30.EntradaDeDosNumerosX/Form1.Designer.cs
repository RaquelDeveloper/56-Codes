namespace _30.EntradaDeDosNumerosX
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
            numero1 = new TextBox();
            numero2 = new TextBox();
            Calcular = new Button();
            Resultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // numero1
            // 
            numero1.Location = new Point(188, 102);
            numero1.Name = "numero1";
            numero1.Size = new Size(125, 27);
            numero1.TabIndex = 0;
            // 
            // numero2
            // 
            numero2.Location = new Point(441, 102);
            numero2.Name = "numero2";
            numero2.Size = new Size(125, 27);
            numero2.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(319, 201);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(124, 29);
            Calcular.TabIndex = 2;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(283, 315);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(199, 27);
            Resultado.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 58);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 4;
            label1.Text = "Ingrese un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 58);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingrese otro numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(Calcular);
            Controls.Add(numero2);
            Controls.Add(numero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numero1;
        private TextBox numero2;
        private Button Calcular;
        private TextBox Resultado;
        private Label label1;
        private Label label2;
    }
}
