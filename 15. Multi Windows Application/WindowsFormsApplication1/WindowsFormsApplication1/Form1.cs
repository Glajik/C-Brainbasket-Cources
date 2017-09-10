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
    
    // Interface for acts with main form
    public interface IPlayerName
    {
        string player1_Name { get; set; }
        string player2_Name { get; set; }
        string winner_Name { get; set; }

        void StartNewGame();
    }

    public partial class Form1 : Form, IPlayerName
    {


        Form CardForm = new Form();
        Form3 GameRulesForm = new Form3();
        Form5 AboutForm = new Form5();
        Form4 NamesDialog; // we call constructor later
        Form2 WinDialog; // .. and there too
       

        // Array for image index of randomised cards;
        int[] img_id = new int[24];

        // value for game logic
        int firstCard = -1, secondCard = -1;
        Button firstButton, secondButton;
        int scoreP1 = 0, scoreP2 = 0;
        int timeP1 = 300, timeP2 = 300;
        // field for interface
        string nameP1 = "Player 1";
        string nameP2 = "Player 2";
        string winner = "noname";

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

        public string winner_Name
        {
            get { return winner; }
            set { winner = value; }
        }
        

        public Form1()
        {
            InitializeComponent();
            
            // make new instance of interface class
            //PlayerName playername = new PlayerName("Player 1 form1", "Player 2 Form1"); 
            
            // give link over constructor to Form4 and Form2
            NamesDialog = new Form4(this);

            WinDialog = new Form2(this);

            CardForm.ShowInTaskbar = false;
            
            /*System.Drawing.Image Cards; // = new System.Drawing.Bitmap();
            Cards = System.Drawing.Bitmap.FromFile("img/Untitled-2.jpg");
            
            CardForm.BackgroundImage = Cards;*/

            CardForm.Width = 228;
            CardForm.Height = 228+25;
            CardForm.StartPosition = FormStartPosition.CenterScreen;
            CardForm.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // implement method of interface
        public void StartNewGame()
        {
            // Init img_id array
            for (int i = 0; i < 12; i++)
            {
                img_id[i] = i;
                img_id[i + 12] = i;
            }

            // Random cards, 200 times.
            Random rnd = new Random();
            int i1, i2, swap;
            for (int i = 0; i < 200; i++)
            {
                i1 = rnd.Next(0, 23);
                i2 = rnd.Next(0, 23);
                swap = img_id[i1];
                img_id[i1] = img_id[i2];
                img_id[i2] = swap;
            }

            // reset scores and time
            scoreP1 = scoreP2 = 0;
            timeP1 = timeP2 = 300;
            nameP1 = "Player 1";
            nameP2 = "Player 2";
            winner = "noname";

            // Who is first Player
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            if (rnd.Next(1) == 0) groupBox1.Enabled = true;
            else groupBox2.Enabled = true;

            //init Listview
            listView1.Clear();
            listView1.LargeImageList = imageList2;
            listView2.Clear();
            listView2.LargeImageList = imageList2;
            
            // Activate game field
            GameField_HideImages();
            GameField_Enable(true);
            GameField_ShowAll();

            // Show Names dialog
            if (!NamesDialog.Visible) NamesDialog.ShowDialog();
            timer2.Enabled = true;

        }


        // All game's mechanics is there
        private void timer1_Tick(object sender, EventArgs e)
        {
            CardForm.Hide(); 
            timer1.Enabled = false;
            if (firstCard != -1 && secondCard != -1)
            {
                if (firstCard == secondCard) // Player open two equal cards
                {
                    firstButton.Hide();
                    secondButton.Hide();
                    
                    if (groupBox1.Enabled) // Player 1 
                    {
                        var li = listView1.Items.Add("", firstCard);
                        li.Focused = true;
                        scoreP1++;
                        label2.Refresh();
                    }
                    else                   // Player 2
                    {
                        var li = listView2.Items.Add("", firstCard);
                        li.Focused = true;
                        scoreP2++;
                        label5.Refresh();
                    }
                    if (GameField_NoCards()) // win conditions
                    {
                        if (scoreP1 > scoreP2) WinGame(nameP1); //by scores
                        else if (scoreP2 > scoreP1) WinGame(nameP2);
                        else // if scores is equal - see who spend less time
                            if (timeP1 > timeP2) WinGame(nameP1);
                            else if (timeP2 > timeP1) WinGame(nameP2);
                            else WinGame("Wow! It's imposible. We have two winners!");
                    }

                }
                else // Turn goes to another player
                {
                    groupBox1.Enabled = !groupBox1.Enabled;
                    groupBox2.Enabled = !groupBox2.Enabled;
                }

                firstCard = secondCard = -1;

                GameField_HideImages();
                //TestGameField();

                GameField_Enable(true);
                
            }
        }

        // Show first or second card, and fix what and which button pressed
        private void ShowCard(Button this_button, int image_index)
        {
            if (!CardForm.Visible)
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
        }

        // Win and loose by time is up
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (groupBox1.Enabled) // Player 1
            {
                if (timeP1 <= 0)
                {
                    timer2.Enabled = false;
                    WinGame(nameP1);
                    return;
                }
                timeP1--;
            }
            else // Player 2
            {
                if (timeP2 <= 0)
                {
                    timer2.Enabled = false;
                    WinGame(nameP2);
                    return;
                }
                timeP2--;
            }

            // show time
            label3.Text = FormatTime(timeP1);
            label4.Text = FormatTime(timeP2);

        }

        // function convert seconds to formatted string like "2:58" or "0:03"
        private String FormatTime(int t)
        {
            int m = t / 60;
            int s = t % 60;
            String a = m.ToString("0") + ":" + s.ToString("00");
            return a;
        }

        private void WinGame(string p)
        {
            winner = p;

            GameField_Enable(false);

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

            CardForm.Visible = false;

            timer1.Enabled = false;
            timer2.Enabled = false;

            WinDialog.ShowDialog();
        }

        void TestGameField()
        {
            button1.Image = imageList2.Images[img_id[0]];
            button2.Image = imageList2.Images[img_id[1]];
            button3.Image = imageList2.Images[img_id[2]];
            button4.Image = imageList2.Images[img_id[3]];
            button5.Image = imageList2.Images[img_id[4]];
            button6.Image = imageList2.Images[img_id[5]];
            button7.Image = imageList2.Images[img_id[6]];
            button8.Image = imageList2.Images[img_id[7]];
            button9.Image = imageList2.Images[img_id[8]];
            button10.Image = imageList2.Images[img_id[9]];
            button11.Image = imageList2.Images[img_id[10]];
            button12.Image = imageList2.Images[img_id[11]];
            button13.Image = imageList2.Images[img_id[12]];
            button14.Image = imageList2.Images[img_id[13]];
            button15.Image = imageList2.Images[img_id[14]];
            button16.Image = imageList2.Images[img_id[15]];
            button17.Image = imageList2.Images[img_id[16]];
            button18.Image = imageList2.Images[img_id[17]];
            button19.Image = imageList2.Images[img_id[18]];
            button20.Image = imageList2.Images[img_id[19]];
            button21.Image = imageList2.Images[img_id[20]];
            button22.Image = imageList2.Images[img_id[21]];
            button23.Image = imageList2.Images[img_id[22]];
            button24.Image = imageList2.Images[img_id[23]];
        }
        void GameField_HideImages()
        {
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
        }

        void GameField_Enable(bool value)
        {
            button1.Enabled = value;
            button2.Enabled = value;
            button3.Enabled = value;
            button4.Enabled = value;
            button5.Enabled = value;
            button6.Enabled = value;
            button7.Enabled = value;
            button8.Enabled = value;
            button9.Enabled = value;
            button10.Enabled = value;
            button11.Enabled = value;
            button12.Enabled = value;
            button13.Enabled = value;
            button14.Enabled = value;
            button15.Enabled = value;
            button16.Enabled = value;
            button17.Enabled = value;
            button18.Enabled = value;
            button19.Enabled = value;
            button20.Enabled = value;
            button21.Enabled = value;
            button22.Enabled = value;
            button23.Enabled = value;
            button24.Enabled = value;
        }

        void GameField_ShowAll()
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
            button17.Visible = true;
            button18.Visible = true;
            button19.Visible = true;
            button20.Visible = true;
            button21.Visible = true;
            button22.Visible = true;
            button23.Visible = true;
            button24.Visible = true;
        }

        // Test Game field if have some card yet.
        // Return true if it have nothing.
        bool GameField_NoCards() {
            bool result = true;
            if (button1.Visible) result = false;
            if (button2.Visible) result = false;
            if (button3.Visible) result = false;
            if (button4.Visible) result = false;
            if (button5.Visible) result = false;
            if (button6.Visible) result = false;
            if (button7.Visible) result = false;
            if (button8.Visible) result = false;
            if (button9.Visible) result = false;
            if (button10.Visible) result = false;
            if (button11.Visible) result = false;
            if (button12.Visible) result = false;
            if (button13.Visible) result = false;
            if (button14.Visible) result = false;
            if (button15.Visible) result = false;
            if (button16.Visible) result = false;
            if (button17.Visible) result = false;
            if (button18.Visible) result = false;
            if (button19.Visible) result = false;
            if (button20.Visible) result = false;
            if (button21.Visible) result = false;
            if (button22.Visible) result = false;
            if (button23.Visible) result = false;
            if (button24.Visible) result = false;
            return result;
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
            var result = MessageBox.Show("Do you want to leave game and close program?", "Confirm the closing", MessageBoxButtons.YesNo);
            var yes = System.Windows.Forms.DialogResult.Yes;
            if (result == yes) Application.Exit();
        }

        // Exit app by click [X]. Show dialog for confirming the closing of the program to avoid accidentally clicking.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( e.CloseReason == CloseReason.UserClosing ) 
            {
                var result = MessageBox.Show("Do you want to leave game and close program?","Confirm the closing", MessageBoxButtons.YesNo);
                var no = System.Windows.Forms.DialogResult.No;
                if (result == no) e.Cancel = true;
            }
                    
            
            //QuitDialog.ShowDialog();
        }


        // Start new game when program start
        private void Form1_Shown(object sender, EventArgs e)
        {
            StartNewGame();
        }

        // Start new game from menu
        private void startNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        // redraw labels who writes count cards
        private void label2_Paint(object sender, PaintEventArgs e)
        {
            if (scoreP1 == 0) label2.Text = "No cards yet";
            else if (scoreP1 == 1) label2.Text = scoreP1.ToString() + " card";
            else label2.Text = scoreP1.ToString() + " cards";    
        }

        private void label5_Paint(object sender, PaintEventArgs e)
        {
            if (scoreP2 == 0) label5.Text = "No cards yet";
            else if (scoreP2 == 1) label5.Text = scoreP2.ToString() + " card";
            else label5.Text = scoreP2.ToString() + " cards";
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameRulesForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm.Show();
        }

    }
}
