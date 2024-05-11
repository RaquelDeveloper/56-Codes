namespace _23.LeerCalificacionDeAlumno
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
            Nota = new TextBox();
            Resultado = new TextBox();
            VerificarNota = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Nota
            // 
            Nota.Location = new Point(299, 111);
            Nota.Name = "Nota";
            Nota.Size = new Size(171, 27);
            Nota.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(300, 232);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(170, 27);
            Resultado.TabIndex = 1;
            // 
            // VerificarNota
            // 
            VerificarNota.Location = new Point(300, 173);
            VerificarNota.Name = "VerificarNota";
            VerificarNota.Size = new Size(170, 29);
            VerificarNota.TabIndex = 2;
            VerificarNota.Text = "Verificar nota";
            VerificarNota.UseVisualStyleBackColor = true;
            VerificarNota.Click += VerificarNota_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 71);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese una nota escolar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(VerificarNota);
            Controls.Add(Resultado);
            Controls.Add(Nota);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nota;
        private TextBox Resultado;
        private Button VerificarNota;
        private Label label1;
    }
}
