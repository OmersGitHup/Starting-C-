using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car cr= new Car();
            cr.color = "Green";
            cr.price = 100000;
            cr.statu = 'i';
            cr.engine = 1000;
            cr.speed = 150;

            label1.Text = cr.color;
            label2.Text = cr.speed.ToString();
            label3.Text = cr.engine.ToString();
            label4.Text = cr.price.ToString();
            label5.Text = cr.statu.ToString();

            pictureBox1.BackColor = Color.Aqua;
        }
    }
}
