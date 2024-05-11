namespace _16.EnergiaTotalQueAlmacenaNuestroCuerpo
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
            Masa = new TextBox();
            Velocidad = new TextBox();
            Altura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Resultado = new TextBox();
            Calcular = new Button();
            SuspendLayout();
            // 
            // Masa
            // 
            Masa.Location = new Point(327, 70);
            Masa.Name = "Masa";
            Masa.Size = new Size(125, 27);
            Masa.TabIndex = 0;
            // 
            // Velocidad
            // 
            Velocidad.Location = new Point(327, 149);
            Velocidad.Name = "Velocidad";
            Velocidad.Size = new Size(125, 27);
            Velocidad.TabIndex = 1;
            // 
            // Altura
            // 
            Altura.Location = new Point(327, 222);
            Altura.Name = "Altura";
            Altura.Size = new Size(125, 27);
            Altura.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 35);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la masa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 117);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 4;
            label2.Text = "Ingrese la velocidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 190);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingrese la altura";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(329, 333);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(125, 27);
            Resultado.TabIndex = 6;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(330, 280);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(124, 29);
            Calcular.TabIndex = 7;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Altura);
            Controls.Add(Velocidad);
            Controls.Add(Masa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Masa;
        private TextBox Velocidad;
        private TextBox Altura;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Resultado;
        private Button Calcular;
    }
}
