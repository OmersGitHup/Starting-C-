using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingCaptcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rn= new Random();
            string[] symbol = { "a", "b", "c", "d", "e", "f", "g", "j" };
            string[] symbol2 = { "+", "-", "#", "/", "(" };
            

            Random r=new Random();
            int n1,n2,n3;
            n1 = r.Next(0, symbol.Length);
            n2 = r.Next(0, symbol2.Length);
            n3 = r.Next(0, 10);

            label1.Text = symbol[n1].ToString()+symbol2[n2].ToString()+n3.ToString();
        }
    }
}
