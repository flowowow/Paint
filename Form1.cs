using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int pen_size = 10;
        double form_shift_factor = 1.5;
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
                SolidBrush brush = new SolidBrush(Color.Blue);
                Rectangle rect = new Rectangle(args.X, args.Y, pen_size, pen_size);
                // vector abs between old and new vector -> not used atm
                // double distance = Math.Sqrt(Math.Pow((new_point.X - old_point.X), 2) + Math.Pow((new_point.Y - old_point.Y), 2));

                // this slightly adjusts the rectangle's width and height to make the drawing look less stutteringly
                // it helps a little but the result is still pretty ugly, especially when rapidly drawing diagonally
                rect.Width = (Math.Abs(old_point.X - new_point.X) > pen_size / 2) ? Convert.ToInt32(Math.Abs(old_point.X - new_point.X) * form_shift_factor) : pen_size;
                rect.Height = (Math.Abs(old_point.Y - new_point.Y) > pen_size / 2) ? Convert.ToInt32(Math.Abs(old_point.Y - new_point.Y) * form_shift_factor) : pen_size;

                graphics.FillEllipse(brush, rect);

                old_point = new_point;
            }
        }
    }
}