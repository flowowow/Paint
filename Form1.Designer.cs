using System;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleDescription = "nigger";
            this.trackBar1.AccessibleName = "nigger";
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(536, 12);
            this.trackBar1.Maximum = 70;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(252, 45);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar_changes);
            #region Color Knöppe

            this.EllipsisButton = new Button();
            EllipsisButton.Text = "Press for Ellipsis Tool";
            EllipsisButton.Size = new System.Drawing.Size(70,60);
            EllipsisButton.Location = new System.Drawing.Point(40,10);
            EllipsisButton.Click += new EventHandler(EnableEllipsis);
            this.Controls.Add(EllipsisButton);

            this.PenRed = new Button();
            PenRed.BackColor = Color.Red;
            PenRed.Size = new System.Drawing.Size(20,20);
            PenRed.Location = new System.Drawing.Point(40,80);
            PenRed.Click += new EventHandler(ChangeRed);
            this.Controls.Add(PenRed);

            this.PenBlue = new Button();
            PenBlue.BackColor = Color.Blue;
            PenBlue.Size = new System.Drawing.Size(20,20);
            PenBlue.Location = new System.Drawing.Point(70,80);
            PenBlue.Click += new EventHandler(ChangeBlue);
            this.Controls.Add(PenBlue);

            this.PenGreen = new Button();
            PenGreen.BackColor = Color.Green;
            PenGreen.Size = new System.Drawing.Size(20,20);
            PenGreen.Location = new System.Drawing.Point(40,110);
            PenGreen.Click += new EventHandler(ChangeGreen);
            this.Controls.Add(PenGreen);

            this.PenPurple = new Button();
            PenPurple.BackColor = Color.Purple;
            PenPurple.Size = new System.Drawing.Size(20,20);
            PenPurple.Location = new System.Drawing.Point(70,110);
            PenPurple.Click += new EventHandler(ChangePurple);
            this.Controls.Add(PenPurple);

            this.PenWhite = new Button();
            PenWhite.BackColor = Color.White;
            PenWhite.Size = new System.Drawing.Size(20,20);
            PenWhite.Location = new System.Drawing.Point(40,140);
            PenWhite.Click += new EventHandler(ChangeWhite);
            this.Controls.Add(PenWhite);

            this.PenBlack = new Button();
            PenBlack.BackColor = Color.Black;
            PenBlack.Size = new System.Drawing.Size(20,20);
            PenBlack.Location = new System.Drawing.Point(70,140);
            PenBlack.Click += new EventHandler(ChangeBlack);
            this.Controls.Add(PenBlack);
            
            #endregion
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "5";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "15";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "25";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "35";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "45";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "55";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "65";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


            this.MouseDown += MousePressed;
            this.MouseUp += MouseReleased;
            this.MouseMove += MouseMoved;

            this.EllipsisButton = new Button();
            EllipsisButton.Text = "Press for Ellipsis Tool";
            EllipsisButton.Size = new System.Drawing.Size(70,60);
            EllipsisButton.Location = new System.Drawing.Point(40,10);
            EllipsisButton.Click += new EventHandler(EnableEllipsis);
            this.Controls.Add(EllipsisButton);
        }
        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}