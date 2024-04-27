namespace LoopsWithTimer
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            progressBar2 = new ProgressBar();
            label3 = new Label();
            progressBar3 = new ProgressBar();
            label4 = new Label();
            progressBar4 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 41);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(797, 23);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 1;
            label1.Text = "Egg and Flower Mixing...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 83);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Cake Whisking...";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(3, 101);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(797, 23);
            progressBar2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 135);
            label3.Name = "label3";
            label3.Size = new Size(213, 15);
            label3.TabIndex = 5;
            label3.Text = "Adding Baking Power while Whisking...";
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(3, 153);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(797, 23);
            progressBar3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 188);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 7;
            label4.Text = "Cake Cooking...";
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(3, 206);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(797, 23);
            progressBar4.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Tick += timer4_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(progressBar4);
            Controls.Add(label3);
            Controls.Add(progressBar3);
            Controls.Add(label2);
            Controls.Add(progressBar2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private ProgressBar progressBar2;
        private Label label3;
        private ProgressBar progressBar3;
        private Label label4;
        private ProgressBar progressBar4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
