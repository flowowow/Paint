using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int pen_size = 10;
        bool mouse_active = false;
        Point old_point = new Point();
        Point new_point = new Point();
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += MousePressed;
            this.MouseUp += MouseReleased;
            this.MouseMove += MouseMoved;
            pen_size = this.trackBar1.Value;
        }

        // Für Menü
        // https://www.oreilly.com/library/view/net-windows-forms/0596003382/ch04.html

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
                // Betrag der Vektoren der alten und der neuen Position
                double distance = Math.Sqrt(Math.Pow((new_point.X - old_point.X), 2) + Math.Pow((new_point.Y - old_point.Y), 2));
                // Wenn Distanz zwischen Intervallen so groß ist, dass die Lücke zwischen den platzierten Objekten größer als die Stiftgröße ist,
                // werden so viele extra Objekte platziert, wie die Stiftgröße in die Distanz past
                if (distance > pen_size / 2)
                {
                    double value = distance / (pen_size / 2);
                    for (int i = 0; i < value; i++)
                    {
                        int x = old_point.X + Convert.ToInt32((new_point.X - old_point.X) / value * (i + 1));
                        int y = old_point.Y + Convert.ToInt32((new_point.Y - old_point.Y) / value * (i + 1));
                        Rectangle rect = new Rectangle(x, y, pen_size, pen_size);
                        graphics.FillEllipse(brush, rect);
                    }
                }
                else
                {
                    Rectangle rect = new Rectangle(args.X, args.Y, pen_size, pen_size);
                    graphics.FillEllipse(brush, rect);
                }

                old_point = new_point;
            }
        }

        protected void Resizing(object instance, EventArgs args)
        {
            Invalidate();
        }

        protected void trackBar_changes(object instance, EventArgs args)
        {
            pen_size = trackBar1.Value;
        }
    }
}