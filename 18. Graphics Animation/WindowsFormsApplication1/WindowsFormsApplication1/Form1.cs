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

        Bitmap sky = new Bitmap(Properties.Resources.Sky);
        Bitmap plane = new Bitmap(Properties.Resources.plane2);
        Graphics hwnd;
        int dx;
        Rectangle rect;


        public Form1()
        {
            InitializeComponent();

            plane.MakeTransparent();
            this.BackgroundImage = sky;
            this.ClientSize = new System.Drawing.Size(new Point(BackgroundImage.Width, BackgroundImage.Height));
            hwnd = Graphics.FromImage(sky);
            rect.X = -65;
            rect.Y = 65;
            rect.Width = plane.Width;
            rect.Height = plane.Height;

            dx = 2;
            timer1.Interval = 20;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hwnd.DrawImage(sky, new Point(0, 0));

            if (rect.X < this.ClientRectangle.Width)
            {
                rect.X += dx;
            }
            else
            {
                rect.X = -65;
                rect.Y = 65;
            }

            hwnd.DrawImage(plane, rect.X, rect.Y);
            this.Invalidate(rect);

            // redraw
            //Rectangle r = new Rectangle(20, 20, sky.Width - 40, sky.Height - 40);

            //hwnd.DrawRectangle(Pens.Black, r.X, r.Y, r.Width - 1, r.Height - 1);
            //this.Invalidate(r);
        }


    }
}
