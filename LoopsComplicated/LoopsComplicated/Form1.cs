namespace LoopsComplicated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i%3 == 0) 
                {
                    listBox1.Items.Add(i);
                }

            }

            for (int i = 1;i < 100;i++) 
            {
                if (i%5 == 0 && i%7==0) 
                {
                    listBox2.Items.Add(i);
                }
            }

            int number =Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < number; i++) 
            {
                listBox3.Items.Add(i);
            }

            for(int i = 1;i <= number; i++)
            {
                if(number%i == 0)
                {
                    listBox4.Items.Add(i);
                }
            }
            int f = 1;
            for (int i = 1; i <= number; i++)
            {
                f *= i;

            }
            listBox5.Items.Add(f);
        }
    }
}
