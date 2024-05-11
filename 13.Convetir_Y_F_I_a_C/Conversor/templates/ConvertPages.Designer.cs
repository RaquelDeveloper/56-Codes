namespace Conversor.templates
{
    partial class ConvertPages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Selection1 = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            Value = new TextBox();
            Result = new TextBox();
            Selection2 = new ComboBox();
            nombrerecibido = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Selection1
            // 
            Selection1.BackColor = SystemColors.Control;
            Selection1.FormattingEnabled = true;
            Selection1.Items.AddRange(new object[] { "Y", "F", "I", "C" });
            Selection1.Location = new Point(21, 141);
            Selection1.Name = "Selection1";
            Selection1.Size = new Size(151, 28);
            Selection1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(96, 30);
            label3.Name = "label3";
            label3.Size = new Size(396, 38);
            label3.TabIndex = 6;
            label3.Text = "Calculadora de Temperaturas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon_uesr;
            pictureBox1.Location = new Point(21, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Value
            // 
            Value.Location = new Point(21, 197);
            Value.Name = "Value";
            Value.Size = new Size(471, 27);
            Value.TabIndex = 7;
            Value.TextChanged += Value_TextChanged;
            // 
            // Result
            // 
            Result.BorderStyle = BorderStyle.FixedSingle;
            Result.Location = new Point(21, 371);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(471, 27);
            Result.TabIndex = 9;
            // 
            // Selection2
            // 
            Selection2.FormattingEnabled = true;
            Selection2.Items.AddRange(new object[] { "C", "I", "F", "Y" });
            Selection2.Location = new Point(21, 315);
            Selection2.Name = "Selection2";
            Selection2.Size = new Size(151, 28);
            Selection2.TabIndex = 8;
            // 
            // nombrerecibido
            // 
            nombrerecibido.AutoSize = true;
            nombrerecibido.ForeColor = SystemColors.Control;
            nombrerecibido.Location = new Point(113, 78);
            nombrerecibido.Name = "nombrerecibido";
            nombrerecibido.Size = new Size(50, 20);
            nombrerecibido.TabIndex = 10;
            nombrerecibido.Text = "label1";
            // 
            // ConvertPages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 514);
            Controls.Add(nombrerecibido);
            Controls.Add(Result);
            Controls.Add(Selection2);
            Controls.Add(Value);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(Selection1);
            Name = "ConvertPages";
            Text = "ConvertPages";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Selection1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox Value;
        private TextBox Result;
        private ComboBox Selection2;
        private Label nombrerecibido;
    }
}