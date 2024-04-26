namespace UsingTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            counter++;
            label1.Text=counter.ToString();

            if (counter == 2)
            {
                this.BackColor = Color.Red;
            }

            if (counter == 4)
            {
                this.BackColor = Color.Blue;
                counter = 0;
            }

        }
    }
}
