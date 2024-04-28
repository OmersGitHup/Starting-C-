namespace ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] kisiler = { "ali", "ahmet", "mehmet", "mesut", "pýnar", "berna" };
            foreach (string k in kisiler)
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
           
            int[] exams = { 100,60,80,90,60 };
            foreach(int i in exams)
            {
                listBox2.Items.Add(i);
                sum=sum+i;
                

            }
            label1.Text= sum.ToString();
            int avg = sum / exams.Length;
            label2.Text = avg.ToString();
        }
    }
}
