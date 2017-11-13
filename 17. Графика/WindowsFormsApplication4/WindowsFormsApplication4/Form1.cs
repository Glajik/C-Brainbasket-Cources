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
        MemoryStream memStream;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Title = "Open Graphic File";
            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures\\";
            openFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|TIFF files (*.tif)|*.tif";
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;

            saveFileDialog1.Filter = "JPEG files *.jpeg|PNG files *.png|GIF files *.gif|TIFF files *.tiff";
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            comboBox3.Enabled = false;

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
                        comboBox1.Enabled = true;
                        numericUpDown1.Enabled = false;
                        comboBox3.Enabled = false;

                    }
                }
                catch (Exception ex)
                {
                    comboBox1.Enabled = false;
                    numericUpDown1.Enabled = false;
                    comboBox3.Enabled = false;
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
            if (checkBox1.Checked)
            {
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
            // pre-config controls
            switch (comboBox1.SelectedItem.ToString())
            {
                case "JPEG":
                    comboBox1.Enabled = true;
                    numericUpDown1.Enabled = true;
                    comboBox3.Enabled = false;
                    break;
                case "PNG":
                    comboBox1.Enabled = true;
                    numericUpDown1.Enabled = false;
                    comboBox3.Enabled = false;
                    break;
                case "GIF":
                    comboBox1.Enabled = true;
                    numericUpDown1.Enabled = false;
                    comboBox3.Enabled = false;
                    break;
                case "TIFF":
                    comboBox1.Enabled = true;
                    numericUpDown1.Enabled = false;
                    comboBox3.Enabled = true;
                    break;
                default:
                    comboBox1.Enabled = true;
                    numericUpDown1.Enabled = false;
                    comboBox3.Enabled = false;
                    break;
            }



            //Make preview match to selected format
            try
            {
                FileStream openfile = new FileStream(openFileDialog1.FileName, FileMode.Open);
                // if it's first time to allocate memory
                if (memStream == null) memStream = new MemoryStream();
                // free memory
                if (memStream.Capacity != 0)
                {
                    memStream.Close();
                    memStream = new MemoryStream();
                }

                if (openfile != null)
                {
                    switch (comboBox1.SelectedItem.ToString())
                    {
                        case "JPEG":
                            JpegBitmapEncoder encJpeg = new JpegBitmapEncoder();
                            encJpeg.QualityLevel = (int)numericUpDown1.Value;
                            encJpeg.Frames.Add(BitmapFrame.Create(openfile));
                            encJpeg.Save(memStream);
                            break;
                        case "PNG":
                            PngBitmapEncoder encPng = new PngBitmapEncoder();
                            encPng.Frames.Add(BitmapFrame.Create(openfile));
                            encPng.Save(memStream);
                            break;
                        case "GIF":
                            GifBitmapEncoder encGif = new GifBitmapEncoder();
                            encGif.Frames.Add(BitmapFrame.Create(openfile));
                            encGif.Save(memStream);
                            break;
                        case "TIFF":
                            TiffBitmapEncoder encTiff = new TiffBitmapEncoder();
                            encTiff.Compression = TiffCompressOption.Default;
                            if (comboBox3.SelectedItem == null) comboBox3.SelectedIndex = 1;
                            switch (comboBox3.SelectedItem.ToString())
                            {
                                case "None":
                                    encTiff.Compression = TiffCompressOption.None;
                                    break;
                                case "Default":
                                    encTiff.Compression = TiffCompressOption.Default;
                                    break;
                                case "Lwz":
                                    encTiff.Compression = TiffCompressOption.Lzw;
                                    break;
                                case "Rle":
                                    encTiff.Compression = TiffCompressOption.Rle;
                                    break;
                                case "Zip":
                                    encTiff.Compression = TiffCompressOption.Zip;
                                    break;
                                default:
                                    MessageBox.Show("Please, select a proper type of compression from a list");
                                    encTiff.Compression = TiffCompressOption.Default;
                                    break;
                            }
                            encTiff.Frames.Add(BitmapFrame.Create(openfile));
                            encTiff.Save(memStream);
                            break;
                        default:
                            MessageBox.Show("Please, select graphic format from a list");
                            BmpBitmapEncoder encBmp = new BmpBitmapEncoder();
                            encBmp.Frames.Add(BitmapFrame.Create(openfile));
                            encBmp.Save(memStream);
                            break;
                    }

                    label2.Text = "Result: size - " + (memStream.Length / 1024) + " KBytes";
                    pictureBox2.Image = Image.FromStream(memStream);
                    //memStream.WriteTo(tempfile);
                    openfile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Coulud not write file. " + ex.Message);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

    }
}