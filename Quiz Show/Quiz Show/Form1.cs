namespace Quiz_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questionNo = 0, truth = 0, wrong = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnD.Text;

            if (label4.Text == label5.Text)
            {
                truth++;
                lblTruth.Text = truth.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        




        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnA.Text;

            if (label4.Text == label5.Text)
            {
                truth++;
                lblTruth.Text = truth.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }


        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnB.Text;

            if (label4.Text == label5.Text)
            {
                truth++;
                lblTruth.Text = truth.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label5.Text = btnC.Text;

            if (label4.Text == label5.Text)
            {
                truth++;
                lblTruth.Text = truth.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            questionNo++;
            lblNumber.Text = questionNo.ToString();

            if (questionNo == 1)
            {

                richTextBox1.Text = "In what year was the Republic of Turkey declared ?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
                label5.Text = "";

            }

            if (questionNo == 2)
            {
                richTextBox1.Text = "Which is not in the Mediterranean region ?";
                btnA.Text = "Adana";
                btnB.Text = "Mersin";
                btnC.Text = "Antalya";
                btnD.Text = "Isparta";
                label4.Text = "Isparta";
            }
            if (questionNo == 3)
            {
                richTextBox1.Text = "When was Ataturk born ?";
                btnA.Text = "1881";
                btnB.Text = "1883";
                btnC.Text = "1882";
                btnD.Text = "1992";
                label4.Text = "1881";
                btnNext.Text = "Result";
            }
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible=false;

            if (questionNo == 4) {
                btnA.Enabled = false;
                btnB.Enabled=false;
                btnC.Enabled=false;
                btnD.Enabled=false;
                btnNext.Enabled=false;

                MessageBox.Show("True: " + truth + "\n" + "Wrong: " + wrong);
            }


        }
    }
}
