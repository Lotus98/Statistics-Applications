using StatisticsLib;
using System;
using System.Diagnostics;
using System.Numerics;

namespace Application11 {
    public partial class Form1 : Form {
        private ContinuousDistribution bernoulli_distrib, interarrivals_distrib;
        private Histogram bernoulli_hist, interarrivals_hist;
        private DynamicRectangle drawing_rect;
        private Random rand;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Initialize Random
            this.rand = new Random(DateTime.Now.Second);

            // Initialize Graphics elements
            drawing_rect = new DynamicRectangle(new Rectangle(picturebox.Location, picturebox.Size), picturebox, Color.Black);
            picturebox.Image = new Bitmap(picturebox.Width, picturebox.Height);
        }

        private void sample_button_Click(object sender, EventArgs e) {
            var m = (int)num_samples.Value;
            var n = (int)samples_size.Value;
            var lambda = (int)num_lambda.Value;
            double prob = (double)lambda / n;

            // Initialize distributions
            bernoulli_distrib = new ContinuousDistribution("Bernoulli", 0, n, 1);
            interarrivals_distrib = new ContinuousDistribution("Interarrivals", 0, 0.1);

            if (lambda > n)
            {
                MessageBox.Show("Lambda must be smaller than n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate samples
            for (int i = 0; i<m; i++)
            {
                List<int> bernoulliSequence = new List<int>();
                // Generate bernoulli trials
                for (int j = 0; j<n; j++)
                {
                    int success = rand.NextDouble() < prob ? 1 : 0;
                    bernoulliSequence.Add(success);
                }
                bernoulli_distrib.InsertInList(bernoulliSequence.Sum());

                List<double> interarrivalTimes = new List<double>();
                for (int j = 1; j < bernoulliSequence.Count; j++)
                {
                    if (bernoulliSequence[j] == 1 && bernoulliSequence[j - 1] == 1)
                    {
                        // Consecutive successes found, calculate interarrival time
                        double interarrival_time = j * (1.0 / lambda);
                        interarrivalTimes.Add(interarrival_time);
                    }
                }

                // Insert interarrival times into the distribution
                foreach (var time in interarrivalTimes)
                {
                    interarrivals_distrib.InsertInList(time);
                }
            }

            // Initialize histograms
            bernoulli_hist = new Histogram(bernoulli_distrib, false);
            drawing_rect.drawing = bernoulli_hist;
            interarrivals_hist = new Histogram(interarrivals_distrib, false);

            draw_charts();
        }

        private void draw_charts() {
            //Draw bernoulli distribution chart
            Graphics gfx = Graphics.FromImage(picturebox.Image);
            gfx.Clear(picturebox.BackColor);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            drawing_rect.Draw(gfx);
            picturebox.Refresh();
            gfx.Dispose();
        }

        private void switch_distrib_Click(object sender, EventArgs e) {
            if (drawing_rect.drawing == bernoulli_hist)
            {
                drawing_rect.drawing = interarrivals_hist;
                switch_distrib.Text = "Show Bernoulli";
            }
            else
            {
                drawing_rect.drawing = bernoulli_hist;
                switch_distrib.Text = "Show Interarrivals";
            }

            draw_charts();
        }
    }
}