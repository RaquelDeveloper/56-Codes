namespace _4.raizCuadrada
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
            valor = new TextBox();
            Resultado = new TextBox();
            label1 = new Label();
            Calcular = new Button();
            SuspendLayout();
            // 
            // valor
            // 
            valor.Location = new Point(60, 143);
            valor.Name = "valor";
            valor.Size = new Size(223, 27);
            valor.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(60, 307);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(223, 27);
            Resultado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 90);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el valor a calcular su raíz";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(60, 234);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(223, 29);
            Calcular.TabIndex = 3;
            Calcular.Text = "CALCULAR";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Vista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 450);
            Controls.Add(Calcular);
            Controls.Add(label1);
            Controls.Add(Resultado);
            Controls.Add(valor);
            Name = "Vista";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valor;
        private TextBox Resultado;
        private Label label1;
        private Button Calcular;
    }
}
