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
    
    // Interface for access to fields in main form
    public interface IPlayerName
    {
        string player1_Name { get; set; }
        string player2_Name { get; set; }
    }

    public partial class Form1 : Form, IPlayerName
    {


        Form CardForm = new Form();
        Form2 WinDialog = new Form2();
        Form3 QuitDialog = new Form3();
        Form4 NamesDialog; // we call constructor later
       

        // Array for image index of randomised cards;
        int[] img_id = new int[24];

        // value for game logic
        int firstCard = -1, secondCard = -1;
        Button firstButton, secondButton;
        int scoreP1 = 0, scoreP2 = 0;
        int timeP1 = 300, timeP2 = 300;
        // field for interface
        string nameP1 = "Player 1", nameP2 = "Player 2";

        // properties for Interface IPlayerName
        public string player1_Name
        {
            get { return nameP1; }
            set
            {
                nameP1 = value;
                groupBox1.Text = nameP1;
            }
        }

        public string player2_Name
        {
            get { return nameP2; }
            set
            {
                nameP2 = value;
                groupBox2.Text = nameP2;
            }
        }

        public Form1()
        {
            InitializeComponent();
            
            // make new instance of interface class
            //PlayerName playername = new PlayerName("Player 1 form1", "Player 2 Form1"); 
            
            // give link over constructor to Form4
            NamesDialog = new Form4(this);

            
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
            if (rnd.Next(1) == 0) groupBox1.Enabled = true;
                             else groupBox2.Enabled = true;

            // reset scores and time
            scoreP1 = scoreP2 = 0;
            timeP1 = timeP2 = 3;
            nameP1 = "Player 1";
            nameP2 = "Player 2";

            //init Listview
            listView1.Clear();
            listView1.LargeImageList = imageList2;
            listView2.Clear();
            listView2.LargeImageList = imageList2;
        }
         
        
        // All game's mechanics is there
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

                    if (groupBox1.Enabled)
                    {
                        listView1.Items.Insert(0, "", firstCard);
                        scoreP1++;
                        label2.Text = scoreP1.ToString() + " cards";
                    }
                    else
                    {
                        listView2.Items.Insert(0, "", firstCard);
                        scoreP2++;
                        label5.Text = scoreP2.ToString() + "cards";
                    }
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

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button18.Enabled = true;
                button19.Enabled = true;
                button20.Enabled = true;
                button21.Enabled = true;
                button22.Enabled = true;
                button23.Enabled = true;
                button24.Enabled = true;

                groupBox1.Enabled = !groupBox1.Enabled;
                groupBox2.Enabled = !groupBox2.Enabled;
            }
        }

        // Show first or second card, and fix what and which button pressed
        private void ShowCard(Button this_button, int image_index)
        {
            if (firstCard == -1)
            {
                firstCard = image_index;
                firstButton = this_button;
                firstButton.Enabled = false;
            }
            else if (secondCard == -1)
            {
                secondCard = image_index;
                secondButton = this_button;
                secondButton.Enabled = false;
            }

            CardForm.BackgroundImage = imageList1.Images[image_index];
            CardForm.Show();

            this_button.Image = imageList2.Images[image_index];

            timer1.Enabled = true;
        }

        //****************************
        // Processing the game board
        //**************************** 
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
            ShowCard(button4, img_id[3]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowCard(button5, img_id[4]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowCard(button6, img_id[5]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowCard(button7, img_id[6]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowCard(button8, img_id[7]);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowCard(button9, img_id[8]);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowCard(button10, img_id[9]);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowCard(button11, img_id[10]);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ShowCard(button12, img_id[11]);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShowCard(button13, img_id[12]);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ShowCard(button14, img_id[13]);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ShowCard(button15, img_id[14]);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ShowCard(button16, img_id[15]);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ShowCard(button17, img_id[16]);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ShowCard(button18, img_id[17]);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ShowCard(button19, img_id[18]);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ShowCard(button20, img_id[19]);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ShowCard(button21, img_id[20]);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ShowCard(button22, img_id[21]);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ShowCard(button23, img_id[22]);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ShowCard(button24, img_id[23]);
        }

        // ************************* ^ End of processing game field

        // Exit app from menu
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitDialog.ShowDialog();
        }

        // Exit app by click [X]
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( e.CloseReason == CloseReason.UserClosing ) QuitDialog.ShowDialog();
        }

        // Win and loose by time is up
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (groupBox1.Enabled) // Player 1
            {
                if (timeP1 <= 0)
                {
                    WinDialog.ShowDialog();
                    timer2.Enabled = false;
                }
                timeP1--;
            }
                else // Player 2
            {
                if (timeP2 <= 0)
                {
                    WinDialog.ShowDialog();
                    timer2.Enabled = false;
                }
                timeP2--;
            }

            // show time
            label3.Text = timeP1.ToString();
            label4.Text = timeP2.ToString();
            
        }

        // Show Player's name dialog
        private void Form1_Shown(object sender, EventArgs e)
        {
            NamesDialog.ShowDialog();
            timer2.Enabled = true;
            
        }

    }
}
