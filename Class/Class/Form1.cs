namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car cr = new Car();
            cr.color = "Blue";
            cr.speed = 200;
            cr.engine = 1245.56;
            cr.price = 500000;
            cr.statu = 's';

            label1.Text = cr.color;
            label2.Text=cr.speed.ToString();
            label3.Text=cr.engine.ToString();
            label4.Text=cr.price.ToString();
            label5.Text=cr.statu.ToString();


        }
    }
}
