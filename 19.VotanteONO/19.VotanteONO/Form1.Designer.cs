namespace _19.VotanteONO
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
            Edad = new TextBox();
            Resultado = new TextBox();
            Verificar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Edad
            // 
            Edad.Location = new Point(269, 101);
            Edad.Name = "Edad";
            Edad.Size = new Size(125, 27);
            Edad.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(269, 215);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(125, 27);
            Resultado.TabIndex = 1;
            // 
            // Verificar
            // 
            Verificar.Location = new Point(269, 162);
            Verificar.Name = "Verificar";
            Verificar.Size = new Size(125, 29);
            Verificar.TabIndex = 2;
            Verificar.Text = "Verificar";
            Verificar.UseVisualStyleBackColor = true;
            Verificar.Click += Verificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 63);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese su edad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Verificar);
            Controls.Add(Resultado);
            Controls.Add(Edad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Edad;
        private TextBox Resultado;
        private Button Verificar;
        private Label label1;
    }
}
