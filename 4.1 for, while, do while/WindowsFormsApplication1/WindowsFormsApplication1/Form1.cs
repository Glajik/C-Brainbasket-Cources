using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 0;
            double x = 0;
            x = Convert.ToDouble(textBox1.Text);

            for (int k=1; k<=5; k++)
                s += Math.Pow(x, k + 1) / (Math.Pow(2, k) + k);
            textBox2.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double s = 0;
            double x = 0;
            int k = 1;
            x = Convert.ToDouble(textBox1.Text);

            while (k <= 5)
            {
                s += Math.Pow(x, k + 1) / (Math.Pow(2, k) + k);
                k++;
            }
            textBox3.Text = Convert.ToString(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s = 0;
            double x = 0;
            int k = 1;
            x = Convert.ToDouble(textBox1.Text);

            do
            {
                s += Math.Pow(x, k + 1) / (Math.Pow(2, k) + k);
                k++;
            } while (k <= 5);
            textBox4.Text = Convert.ToString(s);
        }
    }
}
