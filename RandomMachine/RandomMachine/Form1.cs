using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["RandomN"].Points.AddXY(1, 0);
            chart1.Series["RandomN"].Points.AddXY(2, 0);
            chart1.Series["RandomN"].Points.AddXY(3, 0);

            Random rm = new Random();
            int n1,n2,n3;
            n1= rm.Next(1,16);
            n2= rm.Next(1,12);
            n3= rm.Next(4,56);
            label1.Text = n1.ToString();
            label2.Text = n2.ToString();
            label3.Text = n3.ToString();
            chart1.Series["RandomN"].Points.AddXY(1, n1);
            chart1.Series["RandomN"].Points.AddXY(2, n2);
            chart1.Series["RandomN"].Points.AddXY(3, n3);
            n1=0; n2=0; n3=0;



        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
