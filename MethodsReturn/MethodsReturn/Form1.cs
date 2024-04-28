namespace MethodsReturn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sum(int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = sum(4, 6).ToString();
        }
    }
}
