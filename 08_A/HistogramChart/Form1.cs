using StatisticsLib;

namespace HistogramChart {
    public partial class Form1 : Form {

        private const int MIN_AGE = 6;
        private const int MAX_AGE = 20;


        private ContinuousDistribution dist;
        private DynamicRectangle vertChart;
        private DynamicRectangle horizChart;

        public Form1() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Graphics gfx = Graphics.FromImage(pictureBox1.Image);
            gfx.Clear(pictureBox1.BackColor);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            vertChart.Draw(gfx);
            horizChart.Draw(gfx);
            pictureBox1.Refresh();
            gfx.Dispose();
        }

        private void InitializeDist() {
            // Pick 100 random values
            Random rnd = new Random();
            for (int i = 0; i < 100; i++) {
                int rv = rnd.Next(MIN_AGE, MAX_AGE);
                dist.InsertInList((double)rv);
            }
        }

            private void Form1_Load(object sender, EventArgs e) {
            // Initialize Distribution
            dist = new ContinuousDistribution("Age", MIN_AGE, 1);
            InitializeDist();
            // Create Bitmap to draw inside the picturebox
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // Initialize chart components
            var rect = new Rectangle(pictureBox1.Left, pictureBox1.Top, 100, 100);
            vertChart = new DynamicRectangle(rect, this.pictureBox1, Color.Green);
            rect = new Rectangle(pictureBox1.Left + 200, pictureBox1.Top, 100, 100);
            horizChart = new DynamicRectangle(rect, this.pictureBox1, Color.DarkGreen);
            // Assign DynamicDrawing
            vertChart.drawing = new Histogram(dist, true);
            horizChart.drawing = new Histogram(dist, false);
            this.timer1.Enabled = true;
        }
    }
}