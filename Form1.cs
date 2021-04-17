using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        bool mouse_active = false;
        Point old_point = new Point();
        Point new_point = new Point();
        public Form1()
        {
            InitializeComponent();

            // Assigning mouse events
            this.MouseDown += MousePressed;
            this.MouseUp += MouseReleased;
            this.MouseMove += MouseMoved;
        }

        protected void MousePressed(object instance, MouseEventArgs args)
        {
            if (args.Button == MouseButtons.Left)
            {
                new_point = new Point(args.X, args.Y);
                old_point = new Point(args.X, args.Y);
                mouse_active = true;
            }  
        }

        protected void MouseReleased(object instance, MouseEventArgs args)
        {
            if (args.Button == MouseButtons.Left)
            {
                old_point = new Point();
                mouse_active = false;
            }
        }

        protected void MouseMoved(object instance, MouseEventArgs args)
        {
            if (mouse_active)
            {
                Graphics graphics = CreateGraphics();
                new_point = new Point(args.X, args.Y);
                graphics.DrawLine(new Pen(Color.Blue), new_point, old_point);
                old_point = new_point;
            }
        }
    }
}