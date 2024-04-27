namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 75;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 91) { 
                progressBar1.Value += 10;
                button1.Enabled = true;
            }
            else if (progressBar1.Value > 91)
            {
                button1.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 9)
            {
                progressBar1.Value -= 10;
                button2.Enabled = true;
            }
            else { button2.Enabled = false;
            }
                
        }
    }
}
