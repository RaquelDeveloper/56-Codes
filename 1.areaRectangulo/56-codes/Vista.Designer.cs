namespace _56_codes
{
    partial class Vista
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
            Base = new TextBox();
            Altura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Calcular = new Button();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // Base
            // 
            Base.Location = new Point(28, 68);
            Base.Name = "Base";
            Base.Size = new Size(197, 27);
            Base.TabIndex = 0;
            // 
            // Altura
            // 
            Altura.Location = new Point(28, 193);
            Altura.Name = "Altura";
            Altura.Size = new Size(197, 27);
            Altura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese la base del triángulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 154);
            label2.Name = "label2";
            label2.Size = new Size(198, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingrese la Altura del triágulo";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(28, 283);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(198, 29);
            Calcular.TabIndex = 4;
            Calcular.Text = "CALCULAR";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += button1_Click;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(28, 333);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(197, 27);
            Resultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 387);
            Controls.Add(Resultado);
            Controls.Add(Calcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Altura);
            Controls.Add(Base);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Base;
        private TextBox Altura;
        private Label label1;
        private Label label2;
        private Button Calcular;
        private TextBox Resultado;
    }
}
