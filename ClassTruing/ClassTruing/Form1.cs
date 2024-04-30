namespace ClassTruing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 pd=new Class1();
            pd.name = textBox1.Text;
            pd.cd=maskedTextBox2.Text;
            pd.ed = maskedTextBox2.Text;
            pd.price = Convert.ToInt32(textBox4.Text);
            
         
            listBox1.Items.Add("Product: "+pd.name+" Production Date: "+pd.cd+" Expiry Date: "+pd.ed+" Price: "+pd.price );
        }
    }
}
