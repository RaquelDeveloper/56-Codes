namespace _16.SistemadeEcuacionLineal_MetodoDeCramer
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
            label5 = new Label();
            calcular = new Button();
            d = new TextBox();
            label2 = new Label();
            E = new TextBox();
            label4 = new Label();
            f = new TextBox();
            c = new TextBox();
            label3 = new Label();
            b = new TextBox();
            label1 = new Label();
            a = new TextBox();
            SuspendLayout();
            // 
            // Resultado
            // 
            Resultado.Location = new Point(110, 247);
            Resultado.Multiline = true;
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(522, 45);
            Resultado.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 49);
            label5.Name = "label5";
            label5.Size = new Size(318, 20);
            label5.TabIndex = 11;
            label5.Text = "Sistema de ecuación por el método de Cramer";
            // 
            // calcular
            // 
            calcular.Location = new Point(110, 172);
            calcular.Name = "calcular";
            calcular.Size = new Size(94, 29);
            calcular.TabIndex = 12;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += calcular_Click;
            // 
            // d
            // 
            d.Location = new Point(296, 169);
            d.Name = "d";
            d.Size = new Size(40, 27);
            d.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 172);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 8;
            label2.Text = "x  +";
            // 
            // E
            // 
            E.Location = new Point(382, 169);
            E.Name = "E";
            E.Size = new Size(40, 27);
            E.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 172);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 10;
            label4.Text = "y  =";
            // 
            // f
            // 
            f.Location = new Point(468, 169);
            f.Name = "f";
            f.Size = new Size(40, 27);
            f.TabIndex = 6;
            // 
            // c
            // 
            c.Location = new Point(468, 103);
            c.Name = "c";
            c.Size = new Size(40, 27);
            c.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 103);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 9;
            label3.Text = "y  =";
            // 
            // b
            // 
            b.Location = new Point(382, 103);
            b.Name = "b";
            b.Size = new Size(40, 27);
            b.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 103);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 7;
            label1.Text = "x  +";
            // 
            // a
            // 
            a.Location = new Point(296, 100);
            a.Name = "a";
            a.Size = new Size(40, 27);
            a.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcular);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(f);
            Controls.Add(E);
            Controls.Add(d);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(Resultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Resultado;
        private Label label5;
        private Button calcular;
        private TextBox d;
        private Label label2;
        private TextBox E;
        private Label label4;
        private TextBox f;
        private TextBox c;
        private Label label3;
        private TextBox b;
        private Label label1;
        private TextBox a;
    }
}
