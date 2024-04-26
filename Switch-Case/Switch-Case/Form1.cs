namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt16(textBox1.Text);
            switch (month)
            {
                case 1: textBox2.Text = "January"; break;
                case 2: textBox2.Text = "February"; break;
                case 3: textBox2.Text = "March"; break;
                case 4: textBox2.Text = "April"; break;
                case 5: textBox2.Text = "May"; break;
                case 6: textBox2.Text = "June"; break;
                case 7: textBox2.Text = "July"; break;
                case 8: textBox2.Text = "August"; break;
                case 9: textBox2.Text = "September"; break;
                case 10: textBox2.Text = "October"; break;
                case 11: textBox2.Text = "November"; break;
                case 12: textBox2.Text = "December"; break;

                default: textBox2.Text = "Wrong Month Type"; break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int season = Convert.ToInt16(textBox3.Text);
            switch (season)
            {
                case 1: textBox4.Text = "winter:December,January,February";break;
                case 2: textBox4.Text = "spring:March,April,May";break;
                case 3: textBox4.Text = "summer:June,July,August";break;
                case 4: textBox4.Text = "autumn:September,October,November";break;
                default:textBox4.Text = "Wrong Season Number 1-4";break;

            }
        }
    }
}
