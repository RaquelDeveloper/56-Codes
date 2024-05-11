namespace _28.SignosOpuestos
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
            Numero1 = new TextBox();
            Numero2 = new TextBox();
            Resultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Verificar = new Button();
            SuspendLayout();
            // 
            // Numero1
            // 
            Numero1.Location = new Point(193, 122);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(125, 27);
            Numero1.TabIndex = 0;
            // 
            // Numero2
            // 
            Numero2.Location = new Point(444, 122);
            Numero2.Name = "Numero2";
            Numero2.Size = new Size(125, 27);
            Numero2.TabIndex = 1;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(193, 301);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(376, 27);
            Resultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 90);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 3;
            label1.Text = "Primer número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 90);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 4;
            label2.Text = "Segundo número";
            // 
            // Verificar
            // 
            Verificar.Location = new Point(322, 203);
            Verificar.Name = "Verificar";
            Verificar.Size = new Size(125, 40);
            Verificar.TabIndex = 5;
            Verificar.Text = "Verificar";
            Verificar.UseVisualStyleBackColor = true;
            Verificar.Click += Verificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Verificar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(Numero2);
            Controls.Add(Numero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numero1;
        private TextBox Numero2;
        private TextBox Resultado;
        private Label label1;
        private Label label2;
        private Button Verificar;
    }
}
