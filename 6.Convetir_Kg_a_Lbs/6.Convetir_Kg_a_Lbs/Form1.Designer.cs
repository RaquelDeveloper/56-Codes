﻿namespace _6.Convetir_Kg_a_Lbs
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
            Kg = new TextBox();
            Resultado = new TextBox();
            Calcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Kg
            // 
            Kg.Location = new Point(203, 114);
            Kg.Name = "Kg";
            Kg.Size = new Size(238, 27);
            Kg.TabIndex = 0;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(203, 264);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(238, 27);
            Resultado.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(203, 182);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(238, 36);
            Calcular.TabIndex = 2;
            Calcular.Text = "Convertir a Lbs";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 61);
            label1.Name = "label1";
            label1.Size = new Size(236, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la cantidad de Kilogramos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Calcular);
            Controls.Add(Resultado);
            Controls.Add(Kg);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Kg;
        private TextBox Resultado;
        private Button Calcular;
        private Label label1;
    }
}
