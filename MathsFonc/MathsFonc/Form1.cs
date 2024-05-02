using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsFonc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Abs(x).ToString();
            label3.Text=Math.Ceiling(x).ToString();
            label4.Text=Math.Floor(x).ToString();
            label5.Text=Math.Pow(x, 3).ToString();
            label6.Text=Math.Sqrt(x).ToString();
            label7.Text=((Math.PI)*x).ToString();
        }
    }
}
