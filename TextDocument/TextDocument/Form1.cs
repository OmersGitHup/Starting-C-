﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string documentname, documentway;
        StreamWriter sw;

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                documentway=folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = documentway;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            documentname = textBox2.Text;
            sw = File.CreateText(documentway + "\\" + documentname + ".txt");
            sw.Close();
            MessageBox.Show("Dosya Oluşturuldu ! ");
        }

    }
}
