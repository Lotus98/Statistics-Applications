using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatisticsLib;

namespace Application_06 {
    public partial class Form1 : Form {
        // Data
        private ContinuousDistribution relFreq, absFreq, normFreq; // Used to draw histograms
        private PointF[][] absP, relP, normP;
        private int N, M, J;
        private float XvMax;
        private double EPS, P;
        private Random rand = new Random();
        private Pen[] pens;

        public Form1() {
            InitializeComponent();

            // Initialize Viewport width destined to paths drawing
            XvMax = (float)(pictureBox.Width - (pictureBox.Width / 10));      // Take out 1/10 for the final histogram distribution
            
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
        }

        // Methods
        private Pen RandomPen() {
            return new Pen(Color.FromArgb((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));
        }

        private PointF WtoV(float Xw, float Yw,
                            float XwMin, float YwMin,
                            float XwMax, float YwMax,
                            float XvMin, float YvMin,
                            float XvMax, float YvMax) {
            float Sx, Sy, Xv, Yv;

            Sx = (XvMax - XvMin) / (XwMax - XwMin);
            Sy = (YvMax - YvMin) / (YwMax - YwMin);

            Xv = XvMin + ((Xw - XwMin) * Sx);
            Yv = YvMax - ((Yw - YwMin) * Sy); // Because the coordinates in the Viewport start from top-left

            return new PointF(Xv, Yv);
        }

        private void computeButton_Click(object sender, EventArgs e) {
            // Collect values
            N = (int)nUD.Value;
            M = (int)mUD.Value;
            J = (int)jUD.Value;
            P = (double)pUD.Value;
            EPS = (double)epsUD.Value;

            // Sanity checks
            if (J >= N) {
                MessageBox.Show("J should be a value between 0 and N", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Initialize distributions to draw histograms
            relFreq = new ContinuousDistribution("Relative", 0.0, 1.0, EPS);
            absFreq = new ContinuousDistribution("Absolute", 0.0, N, N*EPS);
            normFreq = new ContinuousDistribution("Normalized", 0.0, N / Math.Sqrt(N), (N / Math.Sqrt(N))*EPS);

            // Initialize Points matrices (jaggered arrays) to draw distribution paths
            absP = new PointF[M][];
            relP = new PointF[M][];
            normP = new PointF[M][];

            
            // Declare extra vars
            int[] success = new int[M];          // Needed to calculate absolute frequency
            OnlineMean[] means = new OnlineMean[M];     // Needed to calculate relative frequencies (also normalized)
            pens = new Pen[M];

            //// Initialize distribution for intermediate histogram
            //ContinuousDistribution jDistrib = new ContinuousDistribution("jdistrib", 0.0, 1.0, EPS);

            // Initialize variables according to number of paths
            for (int i = 0; i < M; i++) {
                success[i] = 0;
                means[i] = new OnlineMean();
                pens[i] = RandomPen();
                // Initializing arrays of points
                absP[i] = new PointF[N];
                relP[i] = new PointF[N];
                normP[i] = new PointF[N];
            }

            // Start generating Bernoulli distributions
            for (int i = 0; i < N; i++) {

                for (int j = 0; j < M; j++) {
                    double val = rand.NextDouble();
                    if (val <= P) {
                        success[j]++;
                        means[j].AddValue(1);
                    }
                    else {
                        means[j].AddValue(0);
                    }

                    //if (i < J) {
                    //    jDistrib.InsertInList(freqs[j].Avg); // Intermediate histogram
                    //}

                    relP[j][i] = WtoV(i, (float)means[j].Avg, 0, 0, N, 1, 0, 0, XvMax, pictureBox.Height);
                    absP[j][i] = WtoV(i, success[j], 0, 0, N, N, 0, 0, XvMax, pictureBox.Height);
                    normP[j][i] = WtoV(i, (float)(success[j]/Math.Sqrt(i+1)), 0, 0, N, (float)(N/Math.Sqrt(N)), 0, 0, XvMax, pictureBox.Height);
                }
            }

            // Filling distributions
            for (int i = 0; i < M; i++) {
                relFreq.InsertInList(means[i].Avg);
                absFreq.InsertInList(success[i]);
                normFreq.InsertInList(success[i] / Math.Sqrt(N));
            }

            if (whichFreq.Text == "Relative")
                DrawRelative(N, M);
            else if (whichFreq.Text == "Absolute")
                DrawAbsolute(N, M);
            else
                DrawNormalized(N, M);

            

            // Draw intermediate histograms
            //distrib = jDistrib.Distribution;
            //maxCount = 0;
            //for (int j = (distrib.Count - 1); j >= 0; j--) {
            //    if (maxCount < distrib[j].Count) {
            //        maxCount = distrib[j].Count;
            //    }
            //}
            //colRatio = (double)(pictureBox.Width / 10) / (double)maxCount;

            //// Draw line
            //p1 = new PointF((float)step * J, 0);
            //p2 = new PointF((float)step * J, (float)pictureBox.Height);
            //gfx.DrawLine(Pens.Red, p1, p2);

            //// Weird loop to modify EPS to get finer granularity
            //colRect = new RectangleF(p1, new SizeF(0, (float)histoStep));
            //for (int j = (numCols - 1); j >= 0; j--) {
            //    colRect.Width = ((float)(distrib[j].Count * colRatio));
            //    gfx.FillRectangle(Brushes.Yellow, colRect);
            //    gfx.DrawRectangle(Pens.Red, colRect.X, colRect.Y, colRect.Width, colRect.Height);
            //    colRect.Y += (float)histoStep;
            //}


            return;
        }

        private void DrawRelative(int N, int M) {
            List<Interval> distrib;

            // Init drawing tools
            Graphics gfx = Graphics.FromImage(pictureBox.Image);
            gfx.Clear(pictureBox.BackColor);

            // Draw distribution paths
            for (int i = 0; i < M; i++) {
                gfx.DrawLines(pens[i], relP[i]);
            }

            // Draw line that separates paths from histogram
            PointF p1, p2;
            p1 = new PointF(XvMax, 0);
            p2 = new PointF(XvMax, pictureBox.Height);
            gfx.DrawLine(Pens.Red, p1, p2);

            // Draw histogram
            distrib = relFreq.Distribution;
            float rectH = (float)pictureBox.Height / distrib.Count;
            for (int i = 0; i < distrib.Count; i++) {
                // Getting the upper-right corner of the rectangle
                PointF rectP = WtoV(distrib[i].Count, i + 1, 0, 0, M, distrib.Count, XvMax, 0, pictureBox.Width, pictureBox.Height);
                //Debug.WriteLine("upper-right corner: [" + rectP.X + ", "+ rectP.Y + "]");
                RectangleF colRect = new RectangleF(XvMax, rectP.Y, rectP.X - XvMax, rectH);
                gfx.FillRectangle(Brushes.Yellow, colRect);
                gfx.DrawRectangle(Pens.Red, colRect.X, colRect.Y, colRect.Width, colRect.Height);
            }
            //Debug.WriteLine("PictureBox width: " + pictureBox.Width);
            //Debug.WriteLine("Number of intervals: " + distrib.Count);
            //Debug.WriteLine("Viewport Histogram X: " + XvMax);
            //Debug.WriteLine("Rectangle height: " + rectH);

            gfx.Dispose();
            pictureBox.Refresh();
            return;
        }

        private void DrawAbsolute(int N, int M) {
            List<Interval> distrib;

            // Init drawing tools
            Graphics gfx = Graphics.FromImage(pictureBox.Image);
            gfx.Clear(pictureBox.BackColor);

            // Draw distribution paths
            for (int i = 0; i < M; i++) {
                gfx.DrawLines(pens[i], absP[i]);
            }

            // Draw line that separates paths from histogram
            PointF p1, p2;
            p1 = new PointF(XvMax, 0);
            p2 = new PointF(XvMax, pictureBox.Height);
            gfx.DrawLine(Pens.Red, p1, p2);

            // Draw histogram
            distrib = absFreq.Distribution;
            float rectH = (float)pictureBox.Height / distrib.Count;
            for (int i = 0; i < distrib.Count; i++) {
                // Getting the upper-right corner of the rectangle
                PointF rectP = WtoV(distrib[i].Count, i + 1, 0, 0, M, distrib.Count, XvMax, 0, pictureBox.Width, pictureBox.Height);
                //Debug.WriteLine("upper-right corner: [" + rectP.X + ", "+ rectP.Y + "]");
                RectangleF colRect = new RectangleF(XvMax, rectP.Y, rectP.X - XvMax, rectH);
                gfx.FillRectangle(Brushes.Yellow, colRect);
                gfx.DrawRectangle(Pens.Red, colRect.X, colRect.Y, colRect.Width, colRect.Height);
            }
            //Debug.WriteLine("PictureBox width: " + pictureBox.Width);
            //Debug.WriteLine("Number of intervals: " + distrib.Count);
            //Debug.WriteLine("Viewport Histogram X: " + XvMax);
            //Debug.WriteLine("Rectangle height: " + rectH);

            gfx.Dispose();
            pictureBox.Refresh();
            return;
        }

        private void DrawNormalized(int N, int M) {
            List<Interval> distrib;

            // Init drawing tools
            Graphics gfx = Graphics.FromImage(pictureBox.Image);
            gfx.Clear(pictureBox.BackColor);

            // Draw distribution paths
            for (int i = 0; i < M; i++) {
                gfx.DrawLines(pens[i], normP[i]);
            }

            // Draw line that separates paths from histogram
            PointF p1, p2;
            p1 = new PointF(XvMax, 0);
            p2 = new PointF(XvMax, pictureBox.Height);
            gfx.DrawLine(Pens.Red, p1, p2);

            // Draw histogram
            distrib = normFreq.Distribution;
            float rectH = (float)pictureBox.Height / distrib.Count;
            for (int i = 0; i < distrib.Count; i++) {
                // Getting the upper-right corner of the rectangle
                PointF rectP = WtoV(distrib[i].Count, i + 1, 0, 0, M, distrib.Count, XvMax, 0, pictureBox.Width, pictureBox.Height);
                //Debug.WriteLine("upper-right corner: [" + rectP.X + ", "+ rectP.Y + "]");
                RectangleF colRect = new RectangleF(XvMax, rectP.Y, rectP.X - XvMax, rectH);
                gfx.FillRectangle(Brushes.Yellow, colRect);
                gfx.DrawRectangle(Pens.Red, colRect.X, colRect.Y, colRect.Width, colRect.Height);
            }
            //Debug.WriteLine("PictureBox width: " + pictureBox.Width);
            //Debug.WriteLine("Number of intervals: " + distrib.Count);
            //Debug.WriteLine("Viewport Histogram X: " + XvMax);
            //Debug.WriteLine("Rectangle height: " + rectH);

            gfx.Dispose();
            pictureBox.Refresh();
            return;
        }

        private void whichFreq_SelectedIndexChanged(object sender, EventArgs e) {
            if (relFreq == null || absFreq == null || normFreq == null) 
                return;

            if (whichFreq.Text == "Relative")
                DrawRelative(N, M);
            else if (whichFreq.Text == "Absolute")
                DrawAbsolute(N, M);
            else if (whichFreq.Text == "Normalized")
                DrawNormalized(N, M);
        }
    }
}
