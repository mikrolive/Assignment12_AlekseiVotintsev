﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int number = Convert.ToInt32(textBox2.Text);
            int shift = Convert.ToInt32(textBox3.Text);
            decimal hourlypayrate = Convert.ToDecimal(textBox4.Text);

            ProductionWorker worker = new ProductionWorker(name, number, shift, hourlypayrate);
            textBox5.Text = worker.ToString();
        }
    }
}
