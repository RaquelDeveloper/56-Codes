namespace _56_codes._2.perimetroCirculo
{
    partial class Vista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Radio = new TextBox();
            Resultado = new TextBox();
            Calcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Radio
            // 
            Radio.Location = new Point(50, 126);
            Radio.Name = "Radio";
            Radio.Size = new Size(125, 27);
            Radio.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(50, 321);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(125, 27);
            Resultado.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(50, 250);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(125, 29);
            Calcular.TabIndex = 2;
            Calcular.Text = "CALCULAR";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 75);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el radio ";
            // 
            // Vista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 450);
            Controls.Add(label1);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(Radio);
            Name = "Vista";
            Text = "Vista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Radio;
        private TextBox Resultado;
        private Button Calcular;
        private Label label1;
    }
}