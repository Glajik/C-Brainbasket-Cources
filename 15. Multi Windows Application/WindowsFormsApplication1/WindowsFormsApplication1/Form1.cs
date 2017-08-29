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
        Form CardForm = new Form();
        Form4 Btn4 = new Form4();

        public Form1()
        {
            InitializeComponent();
            /*System.Drawing.Image Cards; // = new System.Drawing.Bitmap();
            Cards = System.Drawing.Bitmap.FromFile("img/Untitled-2.jpg");
            
            CardForm.BackgroundImage = Cards;*/
            CardForm.Width = 228;
            CardForm.Height = 228;
            CardForm.BackgroundImage = imageList1.Images[0];
            CardForm.BackgroundImageLayout = ImageLayout.Stretch;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CardForm.Show();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CardForm.Hide();
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
