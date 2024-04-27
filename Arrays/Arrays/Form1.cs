namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] kisiler = { "Joe", "Mary", "Alex", "Mike", "Colleen", "Omar", "Marcell" };
            label1.Text= kisiler[5];

            int[]numbers = { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            label1.Text = numbers[0].ToString();


        }
    }
}
