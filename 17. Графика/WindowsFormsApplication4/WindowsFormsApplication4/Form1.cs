using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
            openFileDialog1.Title = "Open Graphic File";
            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures\\";
            openFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|TIFF files (*.tif)|*.tif";
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;
            
            saveFileDialog1.Filter = "JPEG files *.jpeg|PNG files *.png|GIF files *.gif|TIFF files *.tiff";

        }

        // Show openFileDialog and load picture to PictureBox
        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
          
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    myStream = openFileDialog1.OpenFile();
                    if (myStream != null)
                    {
                        // Show path, name and size in KB
                        label1.Text = openFileDialog1.FileName + " - " + (myStream.Length / 1024) + " KBytes";
                        // Show picture
                        pictureBox1.Image = Image.FromStream(myStream);
                        // Close file
                        myStream.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong. -> " + ex.Message);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        // Let user to change SizeMode for a detailed view
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                pictureBox1.SizeMode = pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBox1.SizeMode = pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // Direction to the corresponding function according to the user's choice
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "JPEG":
                    JpegSelected();
                    break;
                case "PNG":
                    break;
                case "GIF": 
                    break;
                case "TIFF":
                    break;
                default:
                    break;
            }
        }

        
        // Try to save temporary picture
        private void JpegSelected()
        {
            try
            {
                FileStream openfile = new FileStream(openFileDialog1.FileName, FileMode.Open);
                FileStream tempfile = new FileStream(openFileDialog1.InitialDirectory + "tempfile.jpg", FileMode.Create);

                if (openfile != null && tempfile != null)
                {
                    JpegBitmapEncoder encJpeg = new JpegBitmapEncoder();
                    encJpeg.QualityLevel = (int)numericUpDown1.Value;
                    encJpeg.Frames.Add(BitmapFrame.Create(openfile));
                    encJpeg.Save(tempfile);
                    label2.Text = tempfile.Length.ToString();
                    pictureBox2.Image = Image.FromStream(tempfile);
                    openfile.Close();
                    tempfile.Close();
                    // delete closed temp file 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Coulud not write file. " + ex.Message); 
            }
        }

    }
}
