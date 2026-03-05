namespace WinFormsApp3
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
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("맑은 고딕 Semilight", 24F, FontStyle.Regular, GraphicsUnit.Point, 129);
            button1.Location = new Point(480, 339);
            button1.Name = "button1";
            button1.Size = new Size(243, 68);
            button1.TabIndex = 0;
            button1.Text = "배경색 바꾸기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(393, 58);
            label1.Name = "label1";
            label1.Size = new Size(125, 47);
            label1.TabIndex = 1;
            label1.Text = "배재용";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._29KBIDNQRV_1;
            pictureBox1.Location = new Point(67, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(399, 124);
            label2.Name = "label2";
            label2.Size = new Size(215, 30);
            label2.TabIndex = 3;
            label2.Text = "수원대 컴퓨터sw학과";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(399, 174);
            label3.Name = "label3";
            label3.Size = new Size(163, 30);
            label3.TabIndex = 4;
            label3.Text = "010-8802-6880";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(399, 238);
            label4.Name = "label4";
            label4.Size = new Size(209, 25);
            label4.TabIndex = 5;
            label4.Text = "bjy7012@suwon.ac.kr";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
