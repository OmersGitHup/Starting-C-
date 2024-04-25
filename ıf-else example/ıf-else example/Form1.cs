namespace ıf_else_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int passnote = Convert.ToInt16(textBox6.Text);
            int sinav1, sinav2, proje;
            string ad, no;
            string x;

            ad=textBox4.Text;
            no=textBox5.Text;

            sinav1 = Convert.ToInt16(textBox1.Text);
            sinav2 = Convert.ToInt16(textBox2.Text);
            proje  = Convert.ToInt16(textBox3.Text);

            int avg=(sinav1+ sinav2+proje)/3;
            
            if (avg>=passnote)
            {
                x = "geçti";
                if 

            }
            else
            {
                x = "kaldı";
            }

            
            listBox1.Items.Add(ad + " " + no + " " + x);



        }
    }
}
