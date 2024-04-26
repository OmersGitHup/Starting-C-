namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x=Convert.ToInt16(textBox1.Text);
            y=Convert.ToInt16(textBox3.Text);
            string symbol=textBox2.Text;

            switch (symbol)
            {
                case "+":textBox4.Text = (x + y).ToString(); break;
                case "-":textBox4.Text = (x - y).ToString();break;
                case "*":textBox4.Text= (x * y).ToString();break;
                case "/":textBox4.Text= (x / y).ToString();break;
                default:textBox4.Text= "Wrong Symbol or Error";break;




            }



        }
    }
}
