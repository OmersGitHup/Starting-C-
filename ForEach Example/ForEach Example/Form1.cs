namespace ForEach_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { -12,112,12, 23, 34, 45, 56, 67, 78, 89, 90, 99 };
            int sum = 0;
            foreach (int n in numbers)
            {
                if (n % 4 == 0)
                {

                    listBox1.Items.Add(n);
                    sum = sum+n;

                }
                label1.Text = listBox1.Items.Count.ToString();
                label2.Text=sum.ToString();
                




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
