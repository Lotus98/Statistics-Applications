using StatisticsLib;

namespace Application13 {
    public partial class Form1 : Form {
        private RandomNormal xRand = new RandomNormal(10, 1);
        private RandomNormal yRand = new RandomNormal(10, 1);
        private DynamicRectangle dynRect;
        private Histogram xHist, x2Hist, xyHist, xy2Hist, x2y2Hist;
        private ContinuousDistribution xDist, x2Dist, xyDist, xy2Dist, x2y2Dist;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            dynRect = new DynamicRectangle(new Rectangle(new Point(0,0), pictureBox.Size), pictureBox, Color.Black);

            // Initialize distributions
            xDist = new ContinuousDistribution("X", 10, 0.1);
            x2Dist = new ContinuousDistribution("X²", 10, 1);
            xyDist = new ContinuousDistribution("XY", 10, 0.05);
            xy2Dist = new ContinuousDistribution("XY²", 10, 0.02);
            x2y2Dist = new ContinuousDistribution("X²Y²", 10, 0.05);

            // Generate distributions
            generateDist();

            // Initialize histograms
            xHist = new Histogram(xDist, true);
            x2Hist = new Histogram(x2Dist, false);
            xyHist = new Histogram(xyDist, false);
            xy2Hist = new Histogram(xy2Dist, false);
            x2y2Hist = new Histogram(x2y2Dist, false);

            // By default, show X distribution
            dynRect.drawing = xHist;
            draw();
        }

        private void draw() {
            Graphics g = Graphics.FromImage(pictureBox.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            dynRect.Draw(g);
            pictureBox.Refresh();
            g.Dispose();
        }

        private void generateDist() {
            for (int i = 0; i < 10000; i++)
            {
                double x = xRand.Next();
                double y = yRand.Next();
                double x2 = Math.Pow(x, 2);
                double y2 = Math.Pow(y, 2);
                xDist.InsertInList(x);
                x2Dist.InsertInList(x2);
                xyDist.InsertInList(x / y);
                xy2Dist.InsertInList(x / y2);
                x2y2Dist.InsertInList(x2 / y2);
            }
        }

        private void xButton_Click(object sender, EventArgs e) {
            dynRect.drawing = xHist;
            draw();
        }

        private void x2Button_Click(object sender, EventArgs e) {
            dynRect.drawing = x2Hist;
            draw();
        }

        private void xyButton_Click(object sender, EventArgs e) {
            dynRect.drawing = xyHist;
            draw();
        }

        private void xy2Button_Click(object sender, EventArgs e) {
            dynRect.drawing = xy2Hist;
            draw();
        }

        private void x2y2Button_Click(object sender, EventArgs e) {
            dynRect.drawing = x2y2Hist;
            draw();
        }
    }
}
