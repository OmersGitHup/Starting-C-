using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SavingTextDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                StreamReader sr=new StreamReader(openFileDialog1.FileName);
                string row=sr.ReadToEnd();
                while(row !=null)
                {
                    listBox1.Items.Add(row);
                    row=sr.ReadLine();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Filter = "Text Doocument|*.txt";
            saveFileDialog1.Title = "Saving Text Document";
            saveFileDialog1.ShowDialog();
            StreamWriter sw=new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Created");
        }
    }
}
