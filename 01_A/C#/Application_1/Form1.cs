using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_1
{
    public partial class Form1 : Form
    {
        // Variables needed for the rectangle box and for the balls
        const int boxHeight = 136;
        const int boxWidth = 500;
        Rectangle box = new Rectangle(0, 0, boxWidth, boxHeight);
        Ball ball1 = new Ball(20, 0, 60, 4, 4);
        Ball ball2 = new Ball(220, 0, 80, 2, 2);
        Ball ball3 = new Ball(360, 60, 32, 8, 8);
        Ball ball4 = new Ball(400, 40, 40, 4, 4);


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "Some text";
        }

        private void paintFrame()
        {
            // Create bitmap for the rectangle
            Bitmap rectangle = new Bitmap(boxWidth, boxHeight);
            Graphics grafx = Graphics.FromImage(rectangle);
            // Enable anti-aliasing to smooth picture
            grafx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw the rectangle
            grafx.FillRectangle(Brushes.White, box);
            grafx.DrawRectangle(Pens.Black, box);

            // Draw the balls
            grafx.FillEllipse(Brushes.Red, ball1.x, ball1.y, ball1.radius, ball1.radius);
            grafx.FillEllipse(Brushes.Blue, ball2.x, ball2.y, ball2.radius, ball2.radius);
            grafx.FillEllipse(Brushes.Green, ball3.x, ball3.y, ball3.radius, ball3.radius);
            grafx.FillEllipse(Brushes.BlueViolet, ball4.x, ball4.y, ball4.radius, ball4.radius);

            this.pictureBox1.Image = rectangle;
            // Clear the image from the previous frame
            grafx.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            // Move balls
            ball1.MoveBall(box);
            ball2.MoveBall(box);
            ball3.MoveBall(box);
            ball4.MoveBall(box);
            this.paintFrame();
        }

        private void paintFrame(object sender, PaintEventArgs e)
        {
            // Create bitmap for the rectangle
            //Graphics grafx = CreateGraphics();
            //grafx.Clear(this.BackColor);
            Bitmap rectangle = new Bitmap(boxWidth, boxHeight);
            Graphics grafx = Graphics.FromImage(rectangle);
            // Enable anti-aliasing to smooth picture
            grafx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw the rectangle
            grafx.FillRectangle(Brushes.White, box);
            grafx.DrawRectangle(Pens.Black, box);

            this.pictureBox1.Image = rectangle;
            // Clear the image from the previous frame
            grafx.Dispose();
        }
    }
}
