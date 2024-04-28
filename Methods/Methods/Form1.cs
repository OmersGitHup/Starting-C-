namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void dye()
        {
            textBox1.BackColor = Color.Aqua;
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Black;
            textBox4.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dye();
        }

        void write()
        {
            textBox1.Text = "Mehmet Yulovak";
            textBox2.Text="5553332211";
            textBox3.Text = "Marangoz";
            textBox4.Text = "Combica";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            write();
        }
    }
}
