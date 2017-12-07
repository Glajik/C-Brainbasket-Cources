using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FitnessCRM
{
    public partial class Form1 : Form
    {
        Form3 FormCustomersRef = new Form3();
        Form4 FormTariffPlan = new Form4();
        Form5 FormVisitHistory = new Form5();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Clients' table. You can move, or remove it, as needed.
            //this.clientsTableAdapter.Fill(this.customersDataSet.Clients);


            openFileDialog1.Title = "Open Graphic File";
            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures\\";
            openFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|TIFF files (*.tif)|*.tif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;

        }


        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        
        // Timeout for waiting input
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            /*
            if (toolStripTextBox1.Text.Length != 13)
            {
                MessageBox.Show("Warning - must be 13 symbols in the card");
                return;
            }
            */
            // search card in database

            try
            {
                // realize filter by string - number in plastic card
                label1.Text = "";
                this.clientsTableAdapter.FillByCard(this.customersDataSet.Clients, toolStripTextBox1.Text);
                foreach (var value in this.customersDataSet.Clients.Rows[0].ItemArray)
                {
                    if (!value.GetType().IsArray)
                    {
                        label1.Text += value + "\n";
                    }
                    else
                    {
                        pictureBox1.Image = (Image)value;
                    }
                }
                

            }
            catch (Exception err)
            {
                MessageBox.Show("Error. " + err.Message);
            }
        }

        private void showCustomersReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomersRef.Show();
        }

        private void showTrainingPlaneReferenceTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTariffPlan.Show();
        }

        private void showVisitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisitHistory.Show();
        }

        // Load Photo
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    // open selected file
                    FileStream sourceFile = new FileStream(openFileDialog1.FileName, FileMode.Open);

                    if (sourceFile != null)
                    {
                        // Show picture
                        photoPictureBox.Image = Image.FromStream(sourceFile);
                        sourceFile.Close();
                        sourceFile.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Couldn't open selected file. -> " + ex.Message);
                }
            }
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }


    }
}
