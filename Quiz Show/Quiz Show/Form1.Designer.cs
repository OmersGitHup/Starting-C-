namespace Quiz_Show
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
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNumber = new Label();
            lblTruth = new Label();
            lblWrong = new Label();
            btnNext = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(90, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(287, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(90, 137);
            btnA.Name = "btnA";
            btnA.Size = new Size(75, 23);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(212, 137);
            btnB.Name = "btnB";
            btnB.Size = new Size(75, 23);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(90, 166);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 23);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(212, 166);
            btnD.Name = "btnD";
            btnD.Size = new Size(75, 23);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Soru No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Doğru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 93);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Yanlış";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(483, 35);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(13, 15);
            lblNumber.TabIndex = 8;
            lblNumber.Text = "0";
            lblNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTruth
            // 
            lblTruth.AutoSize = true;
            lblTruth.Location = new Point(483, 61);
            lblTruth.Name = "lblTruth";
            lblTruth.Size = new Size(13, 15);
            lblTruth.TabIndex = 9;
            lblTruth.Text = "0";
            // 
            // lblWrong
            // 
            lblWrong.AutoSize = true;
            lblWrong.Location = new Point(483, 93);
            lblWrong.Name = "lblWrong";
            lblWrong.Size = new Size(13, 15);
            lblWrong.TabIndex = 10;
            lblWrong.Text = "0";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(415, 111);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 11;
            btnNext.Text = "Sonraki";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.greenlightgif;
            pictureBox1.Location = new Point(396, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.redlightgif;
            pictureBox2.Location = new Point(455, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 254);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 254);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(826, 291);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(lblWrong);
            Controls.Add(lblTruth);
            Controls.Add(lblNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNumber;
        private Label lblTruth;
        private Label lblWrong;
        private Button btnNext;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
