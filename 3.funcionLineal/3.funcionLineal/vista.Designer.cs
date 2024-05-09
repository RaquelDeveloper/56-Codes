namespace _3.funcionLineal
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
            label1 = new Label();
            Calcular = new Button();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // X
            // 
            X.Location = new Point(127, 134);
            X.Name = "X";
            X.Size = new Size(152, 27);
            X.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 77);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el valor de X";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(127, 213);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(152, 29);
            Calcular.TabIndex = 2;
            Calcular.Text = "CALCULAR";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(128, 295);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(151, 27);
            Resultado.TabIndex = 3;
            // 
            // vista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 450);
            Controls.Add(Resultado);
            Controls.Add(Calcular);
            Controls.Add(label1);
            Controls.Add(X);
            Name = "vista";
            Text = "Vista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox X;
        private Label label1;
        private Button Calcular;
        private TextBox Resultado;
    }
}
