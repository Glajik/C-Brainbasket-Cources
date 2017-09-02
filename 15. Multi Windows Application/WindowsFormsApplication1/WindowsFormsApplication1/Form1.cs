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

        // Array for image index of randomised cards;
        int[] img_id = new int[24];

        // value for game logic
        int firstCard = -1, secondCard = -1;
        Button firstButton, secondButton;
        int monet;

        public Form1()
        {
            InitializeComponent();
            
            /*System.Drawing.Image Cards; // = new System.Drawing.Bitmap();
            Cards = System.Drawing.Bitmap.FromFile("img/Untitled-2.jpg");
            
            CardForm.BackgroundImage = Cards;*/

            CardForm.Width = 228;
            CardForm.Height = 228+25;
            CardForm.StartPosition = FormStartPosition.CenterScreen;
            CardForm.BackgroundImageLayout = ImageLayout.Stretch;

            // Init img_id array
            for (int i = 0; i < 11; i++)
            {
                img_id[i] = i;
                img_id[i+12] = i;
            }

            // Random cards, 200 times.
            Random rnd = new Random();
            int i1, i2, swap;
            for (int i = 0; i < 200; i++) {
                i1 = rnd.Next(0,23);
                i2 = rnd.Next(0,23);
                swap = img_id[i1];
                img_id[i1] = img_id[i2];
                img_id[i2] = swap;
            }

            // Who is first Player
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            int coin = rnd.Next(1);
            if (coin == 0) groupBox1.Enabled = true;
            else groupBox2.Enabled = true;
            
            
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            CardForm.Hide();
            timer1.Enabled = false;
            if (firstCard != -1 && secondCard != -1)
            {
                if (firstCard == secondCard)
                {
                    firstButton.Hide();
                    secondButton.Hide();
                }
                
                firstCard = secondCard = -1;
                button1.Image = null;
                button2.Image = null;
                button3.Image = null;
                button4.Image = null;
                button5.Image = null;
                button6.Image = null;
                button7.Image = null;
                button8.Image = null;
                button9.Image = null;
                button10.Image = null;
                button11.Image = null;
                button12.Image = null;
                button13.Image = null;
                button14.Image = null;
                button15.Image = null;
                button16.Image = null;
                button17.Image = null;
                button18.Image = null;
                button19.Image = null;
                button20.Image = null;
                button21.Image = null;
                button22.Image = null;
                button23.Image = null;
                button24.Image = null;

                groupBox1.Enabled = !groupBox1.Enabled;
                groupBox2.Enabled = !groupBox2.Enabled;
            }
        }

        private void ShowCard(Button this_button, int image_index)
        {
            if (firstCard == -1)
            {
                firstCard = image_index;
                firstButton = this_button;
            }
            else if (secondCard == -1)
            {
                secondCard = image_index;
                secondButton = this_button;
            }

            CardForm.BackgroundImage = imageList1.Images[image_index];
            CardForm.Show();

            this_button.Image = imageList2.Images[image_index];

            timer1.Enabled = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ShowCard(button1, img_id[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowCard(button2, img_id[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowCard(button3, img_id[2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[3];
            else if (secondCard == -1) secondCard = img_id[3];

            CardForm.BackgroundImage = imageList1.Images[img_id[3]];
            CardForm.Show();

            button4.Image = imageList2.Images[img_id[3]];

            timer1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[4];
            else if (secondCard == -1) secondCard = img_id[4];

            CardForm.BackgroundImage = imageList1.Images[img_id[4]];
            CardForm.Show();

            button5.Image = imageList2.Images[img_id[4]];

            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[5];
            else if (secondCard == -1) secondCard = img_id[5];

            CardForm.BackgroundImage = imageList1.Images[img_id[5]];
            CardForm.Show();

            button6.Image = imageList2.Images[img_id[5]];

            timer1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[6];
            else if (secondCard == -1) secondCard = img_id[6];

            CardForm.BackgroundImage = imageList1.Images[img_id[6]];
            CardForm.Show();

            button7.Image = imageList2.Images[img_id[6]];

            timer1.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[7];
            else if (secondCard == -1) secondCard = img_id[7];

            CardForm.BackgroundImage = imageList1.Images[img_id[7]];
            CardForm.Show();

            button8.Image = imageList2.Images[img_id[7]];

            timer1.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[8];
            else if (secondCard == -1) secondCard = img_id[8];

            CardForm.BackgroundImage = imageList1.Images[img_id[8]];
            CardForm.Show();

            button9.Image = imageList2.Images[img_id[8]];

            timer1.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[9];
            else if (secondCard == -1) secondCard = img_id[9];

            CardForm.BackgroundImage = imageList1.Images[img_id[9]];
            CardForm.Show();

            button10.Image = imageList2.Images[img_id[9]];

            timer1.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[10];
            else if (secondCard == -1) secondCard = img_id[10];

            CardForm.BackgroundImage = imageList1.Images[img_id[10]];
            CardForm.Show();

            button11.Image = imageList2.Images[img_id[10]];

            timer1.Enabled = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[11];
            else if (secondCard == -1) secondCard = img_id[11];

            CardForm.BackgroundImage = imageList1.Images[img_id[11]];
            CardForm.Show();

            button12.Image = imageList2.Images[img_id[11]];

            timer1.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[12];
            else if (secondCard == -1) secondCard = img_id[12];

            CardForm.BackgroundImage = imageList1.Images[img_id[12]];
            CardForm.Show();

            button13.Image = imageList2.Images[img_id[12]];

            timer1.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[13];
            else if (secondCard == -1) secondCard = img_id[13];

            CardForm.BackgroundImage = imageList1.Images[img_id[13]];
            CardForm.Show();

            button14.Image = imageList2.Images[img_id[13]];

            timer1.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[14];
            else if (secondCard == -1) secondCard = img_id[14];

            CardForm.BackgroundImage = imageList1.Images[img_id[14]];
            CardForm.Show();

            button15.Image = imageList2.Images[img_id[14]];

            timer1.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[15];
            else if (secondCard == -1) secondCard = img_id[15];

            CardForm.BackgroundImage = imageList1.Images[img_id[15]];
            CardForm.Show();

            button16.Image = imageList2.Images[img_id[15]];

            timer1.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[16];
            else if (secondCard == -1) secondCard = img_id[16];

            CardForm.BackgroundImage = imageList1.Images[img_id[16]];
            CardForm.Show();

            button17.Image = imageList2.Images[img_id[16]];

            timer1.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[17];
            else if (secondCard == -1) secondCard = img_id[17];

            CardForm.BackgroundImage = imageList1.Images[img_id[17]];
            CardForm.Show();

            button18.Image = imageList2.Images[img_id[17]];

            timer1.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[18];
            else if (secondCard == -1) secondCard = img_id[18];

            CardForm.BackgroundImage = imageList1.Images[img_id[18]];
            CardForm.Show();

            button19.Image = imageList2.Images[img_id[18]];

            timer1.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[19];
            else if (secondCard == -1) secondCard = img_id[19];

            CardForm.BackgroundImage = imageList1.Images[img_id[19]];
            CardForm.Show();

            button20.Image = imageList2.Images[img_id[19]];

            timer1.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[20];
            else if (secondCard == -1) secondCard = img_id[20];

            CardForm.BackgroundImage = imageList1.Images[img_id[20]];
            CardForm.Show();

            button21.Image = imageList2.Images[img_id[20]];

            timer1.Enabled = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[21];
            else if (secondCard == -1) secondCard = img_id[21];

            CardForm.BackgroundImage = imageList1.Images[img_id[21]];
            CardForm.Show();

            button22.Image = imageList2.Images[img_id[21]];

            timer1.Enabled = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[22];
            else if (secondCard == -1) secondCard = img_id[22];

            CardForm.BackgroundImage = imageList1.Images[img_id[22]];
            CardForm.Show();

            button23.Image = imageList2.Images[img_id[22]];

            timer1.Enabled = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (firstCard == -1) firstCard = img_id[23];
            else if (secondCard == -1) secondCard = img_id[23];

            CardForm.BackgroundImage = imageList1.Images[img_id[23]];
            CardForm.Show();

            button24.Image = imageList2.Images[img_id[23]];

            timer1.Enabled = true;
        }

    }
}
