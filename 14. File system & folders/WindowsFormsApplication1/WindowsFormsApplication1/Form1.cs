using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // View content of folder, which User enter in textBox. (It need full path)
        // Example - 'C:\Program files'
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Take viewing path from textbox
            string path = textBox1.Text;

            // arrays for files and folders names
            string[] files;
            string[] folders;

            // if textbox and therefore path is not empty - fill arrays 
            // and add it like items to listbox 
            if (path != (null))
            {
                if (Directory.Exists(path))
                {
                    files = Directory.GetFiles(path);
                    folders = Directory.GetDirectories(path);
                    foreach (string item in files) listBox1.Items.Add(item);
                    foreach (string item in folders) listBox1.Items.Add(item);
                }
                else
                {
                    string s = String.Concat(path, " Path is not exist");
                    listBox1.Items.Add(s);
                }

            }

        }

        // Make a folder(s)
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Take viewing path from textbox
            string path = textBox1.Text;

            if (path != (null))
            {
                // Trying to make structure of folders, which User enter
                Directory.CreateDirectory(path);
                if (Directory.Exists(path))
                {
                    string s = String.Concat(path, " Successfully created");
                    listBox1.Items.Add(s);
                }
                else
                {
                    string s = String.Concat(path, " Folder is not created");
                    listBox1.Items.Add(s);
                }
            }
        }

        // Remove folder
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Take viewing path from textbox
            string path = textBox1.Text;

            if (path != (null))
            {
                // Check to exist User entered path and try to delete
                if (Directory.Exists(path))
                        Directory.Delete(path);
                else
                {
                    string s = String.Concat(path, " Folder is not exist");
                    listBox1.Items.Add(s);
                    return; // it need to exit from function, 
                    // to prevent next check: it outputs another message,
                    // when folders not exist
                }
                
                // check if folder still there - may be premission denided or some else.
                if (Directory.Exists(path))
                {
                    string s = String.Concat(path, " Folder is not removed");
                    listBox1.Items.Add(s);
                }
                else
                {
                    string s = String.Concat(path, " Folder successfully removed");
                    listBox1.Items.Add(s);
                }
            }
        }

    }
}
