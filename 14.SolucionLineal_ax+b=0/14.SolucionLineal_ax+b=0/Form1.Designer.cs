namespace _14.SolucionLineal_ax_b_0
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
            a = new TextBox();
            b = new TextBox();
            Resultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Calcular = new Button();
            SuspendLayout();
            // 
            // a
            // 
            a.Location = new Point(151, 123);
            a.Name = "a";
            a.Size = new Size(125, 27);
            a.TabIndex = 0;
            // 
            // b
            // 
            b.Location = new Point(424, 123);
            b.Name = "b";
            b.Size = new Size(125, 27);
            b.TabIndex = 1;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(280, 262);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(125, 27);
            Resultado.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 88);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el valor de a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 88);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 4;
            label2.Text = "Ingrese el valor de b";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(280, 203);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(125, 29);
            Calcular.TabIndex = 5;
            Calcular.Text = "CALCULAR X";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(b);
            Controls.Add(a);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox a;
        private TextBox b;
        private TextBox Resultado;
        private Label label1;
        private Label label2;
        private Button Calcular;
    }
}
