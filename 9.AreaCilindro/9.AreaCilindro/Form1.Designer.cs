namespace _9.AreaCilindro
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
            Radio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Altura = new TextBox();
            Calcular = new Button();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // Radio
            // 
            Radio.Location = new Point(98, 122);
            Radio.Name = "Radio";
            Radio.Size = new Size(125, 27);
            Radio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 82);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 212);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 3;
            label2.Text = "Ingrese la altura";
            // 
            // Altura
            // 
            Altura.Location = new Point(98, 252);
            Altura.Name = "Altura";
            Altura.Size = new Size(125, 27);
            Altura.TabIndex = 2;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(274, 178);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(153, 29);
            Calcular.TabIndex = 4;
            Calcular.Text = "CALCULAR EL AREA";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(476, 180);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(140, 27);
            Resultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultado);
            Controls.Add(Calcular);
            Controls.Add(label2);
            Controls.Add(Altura);
            Controls.Add(label1);
            Controls.Add(Radio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Radio;
        private Label label1;
        private Label label2;
        private TextBox Altura;
        private Button Calcular;
        private TextBox Resultado;
    }
}
