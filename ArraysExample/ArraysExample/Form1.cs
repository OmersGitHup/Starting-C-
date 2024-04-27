namespace ArraysExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] numbers = {10,20,30,40,50,60,70,80,90};
            char[] characters = {'a','b','c','d','k' };
            label2.Text = numbers[3].ToString();
            label1.Text = characters[0].ToString();
        }
    }
}
