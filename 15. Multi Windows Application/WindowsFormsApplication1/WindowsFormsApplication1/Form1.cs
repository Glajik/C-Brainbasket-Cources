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
        Form Btn1 = new Form();
        Form4 Btn4 = new Form4();

        public Form1()
        {
            InitializeComponent();
            Btn1.BackgroundImage = Btn4.BackgroundImage;
            Btn1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btn1.Show();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Btn1.Hide();
            Btn4.Hide();
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Btn4.Show();
            timer1.Enabled = true;
        }
    }
}
