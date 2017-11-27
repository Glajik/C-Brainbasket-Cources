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

        Bitmap sky = new Bitmap(Properties.Resources.Sky); // get Sky bitmap from resources
        Bitmap plane = new Bitmap(Properties.Resources.plane23); // get Plane bitmap
        Graphics hwnd; // handle for drawing
        int dx = 2; // speed of moving in px
        Rectangle rect; // rectangle of area to update - where we drawing plane


        public Form1()
        {
            InitializeComponent();

            plane.MakeTransparent(Color.Lime); // make Plane transparent
            this.BackgroundImage = new Bitmap(sky); // set Bitmap to background
            this.ClientSize = new System.Drawing.Size(new Point(BackgroundImage.Width, BackgroundImage.Height)); // set size of Form
            hwnd = Graphics.FromImage(this.BackgroundImage); // set handle to Background
            
            // set start point and size of updating area, where
            rect.X = -65; 
            rect.Y = 65;
            rect.Width = plane.Width;
            rect.Height = plane.Height;

            // set time delay and start Timer
            timer1.Interval = 20; 
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hwnd.DrawImage(sky, new Point(0, 0)); // Draw Sky (and clear from old position of Plane)
            
            // make step right for Plane
            if (rect.X < this.ClientRectangle.Width)
            {
                rect.X += dx;
            }
            else
            {
                rect.X = -65;
                rect.Y = 65;
            }

            

            hwnd.DrawImage(plane, rect.X, rect.Y); // Draw Plane

            this.Invalidate(rect); // Update area with Plane

        }


    }
}
