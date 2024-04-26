namespace Loops1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 11; i++)
            {
                listBox1.Items.Add(i);
            }

            for (int i = 0; i < 11; i += 2)
            {
                
            }
        }
    }
}
