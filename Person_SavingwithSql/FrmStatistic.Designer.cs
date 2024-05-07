namespace Person_SavingwithSql
{
    partial class FrmStatistic
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotalPer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMarried = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblSingle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblTotalSalary = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblAvgSalary = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Person";
            // 
            // LblTotalPer
            // 
            this.LblTotalPer.AutoSize = true;
            this.LblTotalPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalPer.Location = new System.Drawing.Point(184, 54);
            this.LblTotalPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalPer.Name = "LblTotalPer";
            this.LblTotalPer.Size = new System.Drawing.Size(17, 18);
            this.LblTotalPer.TabIndex = 1;
            this.LblTotalPer.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Married Person";
            // 
            // LblMarried
            // 
            this.LblMarried.AutoSize = true;
            this.LblMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMarried.Location = new System.Drawing.Point(184, 101);
            this.LblMarried.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMarried.Name = "LblMarried";
            this.LblMarried.Size = new System.Drawing.Size(17, 18);
            this.LblMarried.TabIndex = 2;
            this.LblMarried.Text = "0";
            this.LblMarried.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Single Person ";
            // 
            // LblSingle
            // 
            this.LblSingle.AutoSize = true;
            this.LblSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSingle.Location = new System.Drawing.Point(184, 144);
            this.LblSingle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSingle.Name = "LblSingle";
            this.LblSingle.Size = new System.Drawing.Size(17, 18);
            this.LblSingle.TabIndex = 4;
            this.LblSingle.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "City";
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCity.Location = new System.Drawing.Point(184, 193);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(17, 18);
            this.LblCity.TabIndex = 7;
            this.LblCity.Text = "0";
            // 
            // LblTotalSalary
            // 
            this.LblTotalSalary.AutoSize = true;
            this.LblTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalSalary.Location = new System.Drawing.Point(184, 234);
            this.LblTotalSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalSalary.Name = "LblTotalSalary";
            this.LblTotalSalary.Size = new System.Drawing.Size(17, 18);
            this.LblTotalSalary.TabIndex = 9;
            this.LblTotalSalary.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Total Salary";
            // 
            // LblAvgSalary
            // 
            this.LblAvgSalary.AutoSize = true;
            this.LblAvgSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAvgSalary.Location = new System.Drawing.Point(184, 277);
            this.LblAvgSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAvgSalary.Name = "LblAvgSalary";
            this.LblAvgSalary.Size = new System.Drawing.Size(17, 18);
            this.LblAvgSalary.TabIndex = 11;
            this.LblAvgSalary.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 277);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Avg Salary";
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 352);
            this.Controls.Add(this.LblAvgSalary);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.LblTotalSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblSingle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblMarried);
            this.Controls.Add(this.LblTotalPer);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStatistic";
            this.Text = "FrmStatistic";
            this.Load += new System.EventHandler(this.FrmStatistic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotalPer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMarried;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblSingle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblTotalSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblAvgSalary;
        private System.Windows.Forms.Label label12;
    }
}