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
        private MemoryStream memStream;
        private FileStream sourceFile = null;
        private JpegBitmapEncoder encJpeg;
        private PngBitmapEncoder encPng;
        private GifBitmapEncoder encGif;
        private TiffBitmapEncoder encTiff;
        private BmpBitmapEncoder encBmp;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Title = "Open Graphic File";
            openFileDialog1.InitialDirectory = "C:\\Users\\Public\\Pictures\\Sample Pictures\\";
            openFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|TIFF files (*.tif)|*.tif";
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;

            saveFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|GIF files (*.gif)|*.gif|TIFF files (*.tif)|*.tif";
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            comboBox3.Enabled = false;
        }

        // Show openFileDialog and load picture to PictureBox
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    // close previous opened file
                    if (sourceFile != null)
                    {
                        sourceFile.Close();
                        sourceFile = null;
                    }
                    
                    // open selected file
                    sourceFile = new FileStream(openFileDialog1.FileName, FileMode.Open);

                    if (sourceFile != null)
                    {
                        // Show path, name and size in KB
                        label1.Text = openFileDialog1.FileName + " - " + (sourceFile.Length / 1024) + " KBytes";
                        // Show picture
                        pictureBox1.Image = Image.FromStream(sourceFile);
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
                    MessageBox.Show("Error: Couldn't open selected file. -> " + ex.Message);
                }
            }

        }

        // Write result to file
        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    FileStream resultFile = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    memStream.Position = 0;
                    memStream.WriteTo(resultFile);
                    resultFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Couldn't save to file. -> " + ex.Message);
                }
            }
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


        // Free old, and allocate new piece of memory
        private void RenewMemStream()
        {
            try
            {
                // if it's first time to allocate memory
                if (memStream == null) memStream = new MemoryStream();
                // free memory
                if (memStream.Capacity != 0)
                {
                    memStream.Close();
                    memStream = new MemoryStream();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Try to show preview - result of compression
        private void ShowPreview()
        {
            try
            {
                if (memStream.Capacity != 0)
                {
                    label2.Text = "Result: size - " + (memStream.Length / 1024) + " KBytes";
                    pictureBox2.Image = Image.FromStream(memStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EncodeToBmp()
        {
            RenewMemStream();

            try
            {
                if (sourceFile != null)
                {
                    sourceFile.Position = 0;
                    encBmp = new BmpBitmapEncoder();
                    encBmp.Frames.Add(BitmapFrame.Create(sourceFile));
                    encBmp.Save(memStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EncodeToTiff(TiffCompressOption mode)
        {
            RenewMemStream();

            try
            {
                if (sourceFile != null)
                {
                    sourceFile.Position = 0;
                    encTiff = new TiffBitmapEncoder();
                    encTiff.Frames.Add(BitmapFrame.Create(sourceFile));
                    encTiff.Compression = mode;
                    encTiff.Save(memStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EncodeToGif()
        {
            RenewMemStream();

            try
            {
                if (sourceFile != null)
                {
                    sourceFile.Position = 0;
                    encGif = new GifBitmapEncoder();
                    encGif.Frames.Add(BitmapFrame.Create(sourceFile));
                    encGif.Save(memStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EncodeToPng()
        {
            RenewMemStream();

            try
            {
                if (sourceFile != null)
                {
                    sourceFile.Position = 0;
                    encPng = new PngBitmapEncoder();
                    encPng.Frames.Add(BitmapFrame.Create(sourceFile));
                    encPng.Save(memStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EncodeToJpeg(decimal quality)
        {
            RenewMemStream();

            try
            {
                if (sourceFile != null)
                {
                    sourceFile.Position = 0;
                    encJpeg = new JpegBitmapEncoder();
                    encJpeg.Frames.Add(BitmapFrame.Create(sourceFile));
                    encJpeg.QualityLevel = (int)quality;
                    encJpeg.Save(memStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Handle of changing percent of quality for Jpeg
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            EncodeToJpeg(numericUpDown1.Value);
            ShowPreview();
        }

        // Handle of change format type
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                // pre-config controls
                comboBox1.Enabled = true;
                numericUpDown1.Enabled = false;
                comboBox3.Enabled = false;

                switch (comboBox1.SelectedItem.ToString())
                {
                    case "JPEG":
                        numericUpDown1.Enabled = true; // Jpeg Quality
                        EncodeToJpeg(numericUpDown1.Value);
                        ShowPreview();
                        saveFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg";
                        break;

                    case "PNG":
                        EncodeToPng();
                        ShowPreview();
                        saveFileDialog1.Filter = "PNG files (*.png)|*.png";
                        break;

                    case "GIF":
                        EncodeToGif();
                        ShowPreview();
                        saveFileDialog1.Filter = "GIF files (*.gif)|*.gif";
                        break;

                    case "TIFF":
                        comboBox3.Enabled = true; // Tiff compression mode
                        comboBox3_SelectedIndexChanged(sender, e);
                        // Functions EncodeToTiff() & ShowPreview will calling in comboBox_SelectedIndexChanged();
                        saveFileDialog1.Filter = "TIFF files (*.tif)|*.tif";
                        break;

                    case "BMP":
                        EncodeToBmp();
                        ShowPreview();
                        saveFileDialog1.Filter = "BMP files (*.bmp)|*.bmp";
                        break;

                    default:
                        MessageBox.Show("Please, select graphic format from a list");
                        break;
                }
            }
        }

        // handle of changing compression mode for Tiff
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedItem != null)
                {
                    switch (comboBox3.SelectedItem.ToString())
                    {
                        case "None":
                            EncodeToTiff(TiffCompressOption.None);
                            ShowPreview();
                            break;
                        case "Default":
                            EncodeToTiff(TiffCompressOption.Default);
                            ShowPreview();
                            break;
                        case "Lwz":
                            EncodeToTiff(TiffCompressOption.Lzw);
                            ShowPreview();
                            break;
                        case "Rle":
                            EncodeToTiff(TiffCompressOption.Rle);
                            ShowPreview();
                            break;
                        case "Zip":
                            EncodeToTiff(TiffCompressOption.Zip);
                            ShowPreview();
                            break;
                        default:
                            MessageBox.Show("Please, select a proper type of compression from a list");
                            EncodeToTiff(TiffCompressOption.Default);
                            ShowPreview();
                            break;
                    }
                }
                else
                {
                    comboBox3.SelectedItem = "None";
                    EncodeToTiff(TiffCompressOption.None);
                    ShowPreview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }
}