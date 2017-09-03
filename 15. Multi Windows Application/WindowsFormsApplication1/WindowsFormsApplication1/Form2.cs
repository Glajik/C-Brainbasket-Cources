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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            // Show random image
            Random rnd = new Random();
            int count = imageList1.Images.Count;
            int rndimg = rnd.Next(0, count - 1);
            pictureBox1.Image = imageList1.Images[rndimg];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
