namespace Conversor
{
    partial class WelcomePages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePages));
            label1 = new Label();
            ComenzarBtn = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            colorDialog1 = new ColorDialog();
            label4 = new Label();
            nombreTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 60);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ComenzarBtn
            // 
            ComenzarBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ComenzarBtn.BackColor = Color.MidnightBlue;
            ComenzarBtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ComenzarBtn.ForeColor = SystemColors.Control;
            ComenzarBtn.Location = new Point(19, 502);
            ComenzarBtn.Margin = new Padding(10);
            ComenzarBtn.Name = "ComenzarBtn";
            ComenzarBtn.Size = new Size(433, 54);
            ComenzarBtn.TabIndex = 1;
            ComenzarBtn.Text = "Comenzar";
            ComenzarBtn.UseVisualStyleBackColor = false;
            ComenzarBtn.Click += ComenzarBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(32, 162);
            label2.Name = "label2";
            label2.Size = new Size(353, 150);
            label2.TabIndex = 2;
            label2.Text = "Este software es capaz de hacer calculos de\r\nunidades de temperaturas:\r\n\r\n * C°-F° \r\n\r\n * F°-C";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon_uesr;
            pictureBox1.Location = new Point(32, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(107, 43);
            label3.Name = "label3";
            label3.Size = new Size(294, 54);
            label3.TabIndex = 4;
            label3.Text = "¡BIENVENIDO!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(32, 350);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 5;
            label4.Text = "Ingrese su nombre";
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(32, 382);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(379, 27);
            nombreTxt.TabIndex = 6;
            // 
            // WelcomePages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 561);
            Controls.Add(nombreTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(ComenzarBtn);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "WelcomePages";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ComenzarBtn;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private ColorDialog colorDialog1;
        private Label label4;
        private TextBox nombreTxt;
    }
}
