namespace _12.promedio
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
            tabla = new DataGridView();
            Asignatura = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            nombreNota = new TextBox();
            ValorNota = new TextBox();
            Agregar = new Button();
            label1 = new Label();
            label2 = new Label();
            Calcular = new Button();
            Limpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Asignatura, Nota });
            tabla.Location = new Point(25, 21);
            tabla.Name = "tabla";
            tabla.RowHeadersWidth = 51;
            tabla.Size = new Size(377, 247);
            tabla.TabIndex = 0;
            tabla.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Asignatura
            // 
            Asignatura.HeaderText = "asignatura";
            Asignatura.MinimumWidth = 6;
            Asignatura.Name = "Asignatura";
            Asignatura.Width = 125;
            // 
            // Nota
            // 
            Nota.HeaderText = "nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.Width = 125;
            // 
            // nombreNota
            // 
            nombreNota.Location = new Point(446, 72);
            nombreNota.Name = "nombreNota";
            nombreNota.Size = new Size(300, 27);
            nombreNota.TabIndex = 1;
            // 
            // ValorNota
            // 
            ValorNota.Location = new Point(446, 168);
            ValorNota.Name = "ValorNota";
            ValorNota.Size = new Size(300, 27);
            ValorNota.TabIndex = 2;
            // 
            // Agregar
            // 
            Agregar.Location = new Point(446, 239);
            Agregar.Name = "Agregar";
            Agregar.Size = new Size(300, 29);
            Agregar.TabIndex = 3;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = true;
            Agregar.Click += Agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(458, 43);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre de nota";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 131);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 5;
            label2.Text = "Nota alcanzada";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(25, 307);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(377, 29);
            Calcular.TabIndex = 6;
            Calcular.Text = "Calcular promedio";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(25, 360);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(377, 37);
            Limpiar.TabIndex = 7;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Calcular);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Agregar);
            Controls.Add(ValorNota);
            Controls.Add(nombreNota);
            Controls.Add(tabla);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabla;
        private DataGridViewTextBoxColumn Asignatura;
        private DataGridViewTextBoxColumn Nota;
        private TextBox nombreNota;
        private TextBox ValorNota;
        private Button Agregar;
        private Label label1;
        private Label label2;
        private Button Calcular;
        private Button Limpiar;
    }
}
