namespace easyWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 5) 
            {
                listBox1.Items.Add(i);
                listBox2.Items.Add("Merhaba Dünya");
                i++;
            }

            int j = 1;
            int sum=0;
            while (j <= 5) 
            {
                sum = sum + j;
                j++;
            }
            MessageBox.Show(sum.ToString());

        }
    }
}
