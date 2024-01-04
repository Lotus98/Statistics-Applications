using StatisticsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application12 {
    public partial class Form1 : Form {
        private float MAX_RADIUS;
        private ContinuousDistribution xDist, yDist;
        private Histogram xHist, yHist;
        private DynamicRectangle xRect, yRect;
        private PointF center;
        private List<PointF> points;
        private Random rand;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Set the maximum radius to the minimum of the width and height of the picture box 
            MAX_RADIUS = Math.Min(simulationPictureBox.Width, simulationPictureBox.Height) / 2.0f;
            // Set coordinates of the center of the picture box (these are used once we find the cartesian coordinates)
            center = new PointF(simulationPictureBox.Width / 2.0f, simulationPictureBox.Height / 2.0f);
            rand = new Random();
            // Initialize picturebox
            simulationPictureBox.Image = new Bitmap(simulationPictureBox.Width, simulationPictureBox.Height);
            // Initialize histogram pictureboxes and their dynamic rectangles
            vertHisto.Image = new Bitmap(vertHisto.Width, vertHisto.Height);
            horizHisto.Image = new Bitmap(horizHisto.Width, horizHisto.Height);
            xRect = new DynamicRectangle(new Rectangle(new Point(0, 0), horizHisto.Size), horizHisto, Color.Black);
            yRect = new DynamicRectangle(new Rectangle(new Point(0, 0), vertHisto.Size), vertHisto, Color.Black);
        }

        private void button1_Click(object sender, EventArgs e) {
            int n = (int)numericUpDown1.Value;
            // Initialize points list
            points = new List<PointF>();

            // Initialize the distributions
            xDist = new ContinuousDistribution("xDist", -MAX_RADIUS, MAX_RADIUS, 20);
            yDist = new ContinuousDistribution("yDist", -MAX_RADIUS, MAX_RADIUS, 20);

            for (int i = 0; i < n; i++)
            {
                // Get random values for radius and angle
                double radius = rand.NextDouble() * MAX_RADIUS;
                double angle = rand.NextDouble() * 2 * Math.PI;

                // Convert the polar coordinates to cartesian coordinates with respect to the center of the picture box
                float x = (float)(radius * Math.Cos(angle) + center.X);
                float y = (float)(radius * Math.Sin(angle) + center.Y);
                xDist.InsertInList(x);
                yDist.InsertInList(y);

                points.Add(new PointF(x, y));
            }

            // Initialize the histograms
            xHist = new Histogram(xDist, false);
            yHist = new Histogram(yDist, true);
            // Assign the histograms to the picture boxes
            xRect.drawing = xHist;
            yRect.drawing = yHist;

            // Clear the picture box and draw the points
            Graphics gfx = Graphics.FromImage(simulationPictureBox.Image);
            gfx.Clear(simulationPictureBox.BackColor);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (PointF p in points)
            {
                gfx.FillEllipse(Brushes.Aqua, p.X, p.Y, 2f, 2f);
            }
            simulationPictureBox.Refresh();
            gfx.Dispose();

            // Draw the histograms
            gfx = Graphics.FromImage(horizHisto.Image);
            gfx.Clear(Color.White);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            xRect.Draw(gfx);
            horizHisto.Refresh();
            gfx.Dispose();

            gfx = Graphics.FromImage(vertHisto.Image);
            gfx.Clear(Color.White);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            yRect.Draw(gfx);
            vertHisto.Refresh();
            gfx.Dispose();
        }

    }
}
