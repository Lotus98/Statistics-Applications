using StatisticsLib;

namespace ChartRectangle {
    public partial class Form1 : Form {
        // Our dynamic chart
        private DynamicRectangle appChart;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            var r = new Rectangle(new Point(100, 100), new Size(100, 100));
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            appChart = new DynamicRectangle(r, pictureBox1);
            timer1.Enabled = true;
        }

        private void DrawFrame() {
            Graphics gfx = Graphics.FromImage(pictureBox1.Image);
            gfx.Clear(pictureBox1.BackColor);
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            appChart.Draw(gfx);
            pictureBox1.Refresh();
            gfx.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            DrawFrame();
        }
    }
}