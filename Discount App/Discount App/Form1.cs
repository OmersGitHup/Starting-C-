namespace Discount_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int piece, price;
            int first,second,third;
            int firstD, secondD, thirdD;
            int x;
            piece = Convert.ToInt16(textBox1.Text);
            price = Convert.ToInt16(textBox2.Text);

            first = Convert.ToInt16(textBox6.Text);
            second = Convert.ToInt16(textBox7.Text);
            third = Convert.ToInt16(textBox8.Text);

            firstD = Convert.ToInt16(textBox5.Text);
            secondD = Convert.ToInt16(textBox4.Text);
            thirdD = Convert.ToInt16(textBox3.Text);




            if (piece < second && piece>=first)
            {
                x = piece * price * (100 - firstD) / 100;
                listBox1.Items.Add("Dicounted Amopunt =" + x.ToString());
            }
            else if (piece<third && piece>=second)
            {
                x = piece * price*(100 - secondD) / 100;
                listBox1.Items.Add("Dicounted Amopunt =" + x.ToString());
            }
            else if (piece>=third)
            {
                x =piece * price*(100 - thirdD) / 100;
                listBox1.Items.Add("Dicounted Amopunt =" + x.ToString());
            }
            else
            {
                listBox1.Items.Add("Eroor ");
            }

            


        }
    }
}
