namespace AdditiontoYourPoint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            int y = 0;
            int sum = 0;

            a = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);

            

            for (int x = a; x <= y; x++)
            {
                listBox1.Items.Add(x);
            }
            for (int x = a; x <= y; x++)
            {
                sum = sum + x;

            }
            listBox2.Items.Add(sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
