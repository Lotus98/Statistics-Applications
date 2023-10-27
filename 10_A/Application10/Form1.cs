using StatisticsLib;
using System;
using System.Diagnostics;
using System.Numerics;

namespace Application10 {
    public partial class Form1 : Form {
        private const int POPULATION_SIZE = 1000;
        // The population is a set of grades
        private int[] population = new int[POPULATION_SIZE];
        private OnlineMean[] sample_means;
        private OnlineVariance[] sample_variances;
        private OnlineMean mean_of_means = new();
        private OnlineMean mean_of_variances = new();
        private OnlineMean population_mean = new();
        private OnlineVariance population_variance = new();
        private ContinuousDistribution dist_sample_means = new ContinuousDistribution("sample means", 18, 30, 1);
        private ContinuousDistribution dist_sample_variances = new ContinuousDistribution("sample variances", 0, 18, 1);
        private Histogram means_histogram;
        private Histogram variances_histogram;
        private DynamicRectangle rect;
        private Random rand;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Initialize Random
            this.rand = new Random(DateTime.Now.Second);
            // Generate population of grades
            Generate_Population();
            // Initialize Dynamic Rectangle
            rect = new DynamicRectangle(new Rectangle(pictureBox1.Location, pictureBox1.Size), pictureBox1, Color.Black);
            // Initialize Image bitmap
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        // Population is a taken from possible exam grades
        private void Generate_Population() {
            for (int i = 0; i < population.Length; i++)
            {
                population[i] = rand.Next(18, 31);
                population_mean.AddValue(population[i]);
                population_variance.AddValue(population[i]);
            }
        }

        private void sample_button_Click(object sender, EventArgs e) {
            var n = (int)sample_size_in.Value;
            var m = (int)n_samples_in.Value;

            // Initialize samples
            sample_means = new OnlineMean[m];
            sample_variances = new OnlineVariance[m];

            compute_samples(n, m);

            // Calculate distributions
            for (int i = 0; i < m; i++)
            {
                mean_of_means.AddValue(sample_means[i].Avg);
                dist_sample_means.InsertInList(sample_means[i].Avg);
                mean_of_variances.AddValue(sample_variances[i].Variance);
                dist_sample_variances.InsertInList(sample_variances[i].Variance);
            }

            // Show output
            means_means_text.Text = string.Format("{0:N2}", mean_of_means.Avg);
            means_var_text.Text = string.Format("{0:N2}", mean_of_variances.Avg);
            pop_mean_text.Text = string.Format("{0:N2}", population_mean.Avg);
            pop_var_text.Text = string.Format("{0:N2}", population_variance.Variance);

            // Initialize Histograms
            means_histogram = new Histogram(dist_sample_means, false);
            variances_histogram = new Histogram(dist_sample_variances, false);
            rect.drawing = means_histogram;
            draw_charts();
        }

        private void draw_charts() {
            Graphics gfx = Graphics.FromImage(pictureBox1.Image);
            gfx.Clear(pictureBox1.BackColor);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rect.Draw(gfx);
            pictureBox1.Refresh();
            gfx.Dispose();
        }

        private void compute_samples(int n, int m) {
            for (int i = 0; i < m; i++)
            {
                sample_means[i] = new OnlineMean();
                sample_variances[i] = new OnlineVariance();
                List<int> picked = new(n);
                for (int j = 0; j < n; j++)
                {
                    int r;
                    // Make sure we are not taking a unit we already sampled
                    do
                    {
                        r = rand.Next(0, population.Length);
                    } while (picked.Contains(r));
                    picked.Add(r);
                    sample_means[i].AddValue(population[r]);
                    sample_variances[i].AddValue(population[r]);
                }
            }
        }

        private void mean_char_button_Click(object sender, EventArgs e) {
            rect.drawing = means_histogram;
            draw_charts();
        }

        private void var_char_button_Click(object sender, EventArgs e) {
            rect.drawing = variances_histogram;
            draw_charts();
        }
    }
}