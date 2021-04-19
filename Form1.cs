﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int pen_size = 10;
        Button EllipsisButton;
        bool mouse_active, EToolActive = false;
        Point old_point = new Point();
        Point new_point = new Point();
        public Form1()
        {
            InitializeComponent();

            // Assigning mouse events
            
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
            if (args.Button == MouseButtons.Left && !EToolActive)
            {
                old_point = new Point();
                mouse_active = false;
            }
            else if(args.Button == MouseButtons.Left && EToolActive)
            {
                Graphics graphics = CreateGraphics();
                new_point = new Point(args.X, args.Y);
                graphics.DrawEllipse(Pens.Brown,old_point.X, old_point.Y, new_point.X - old_point.X, new_point.Y - old_point.Y);
                //Console.WriteLine("oldx: {0}, oldy: {1}, newx: {2},newy: {3}",old_point.X, old_point.Y, new_point.X, new_point.Y);
                old_point = new_point;
                mouse_active = false;
            }
        }

        private void EnableEllipsis(object instance, EventArgs e)
        {
            if(EToolActive == true){
                EToolActive = false;
                EllipsisButton.Text = "Press for Ellipsis Tool";
            }
            else if (EToolActive == false){
                EToolActive = true;
                EllipsisButton.Text = "Ellipsis Tool is active";
            }
        }

        protected void MouseMoved(object instance, MouseEventArgs args)
        {
            if (mouse_active && !EToolActive)
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
    }
}