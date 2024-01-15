using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public class Histogram : DynamicDrawing {
        // Data
        private ContinuousDistribution distribution;
        private int max = 0, total = 0;
        // Scaling factor for each column height
        private double scaleFactor;
        private bool vertical;
        private int fontSize = 20;

        // Utils to draw
        private SolidBrush brush1 = new SolidBrush(Color.Green);
        private SolidBrush brush2 = new SolidBrush(Color.Lime);

         public Histogram(ContinuousDistribution distribution, bool vertical) {
            this.distribution = distribution;
            this.vertical = vertical;
            InitHisto();
        }


        // Methods
        private void TrimTails() {
            int threshold = total / 500;
            // Identify and trim left tail
            while (distribution.intervals.Count > 0 && distribution.intervals.First().Count < threshold)
            {
                distribution.intervals.RemoveAt(0);
            }

            // Identify and trim right tail
            while (distribution.intervals.Count > 0 && distribution.intervals.Last().Count < threshold)
            {
                distribution.intervals.RemoveAt(distribution.intervals.Count - 1);
            }
        }

        private void InitHisto() {
            total = distribution.intervals.Sum(i => i.Count);
            max = distribution.intervals.Max(i => i.Count);
            TrimTails();
        }

        public override void Draw(Graphics gfx) {
            DrawHistogram(gfx, vertical);
        }

        private void DrawHistogram(Graphics gfx, bool isVertical) {
            Rectangle histogramArea = new Rectangle(drawingArea.Location, drawingArea.Size);
            int colsNum, colWidth;
            bool dark = true;

            // Adjust histogram area to leave space for the labels
            histogramArea.X += fontSize;
            histogramArea.Width -= fontSize;
            histogramArea.Height -= fontSize;

            // Calculate Scaling factor
            scaleFactor = isVertical ? (double)histogramArea.Width / (double)max : (double)histogramArea.Height / (double)max;

            // Get cols and width
            colsNum = distribution.intervals.Count;
            colWidth = isVertical ? histogramArea.Height / colsNum : histogramArea.Width / colsNum;

            // Create rectangle to draw the histogram columns ==> Initially x, y, width, and height are not correct
            Rectangle column = isVertical
                ? new Rectangle(histogramArea.X, histogramArea.Y,  histogramArea.Width, colWidth)
                : new Rectangle(histogramArea.X, histogramArea.Y, colWidth, histogramArea.Height);

            foreach (Interval i in distribution.intervals)
            {
                int colSize = (int)Math.Round(i.Count * scaleFactor);

                if (isVertical)
                {
                    column.Width = colSize;
                }
                else
                {
                    column.Height = colSize;
                    column.Y = histogramArea.Height - colSize;
                }

                drawColumn(gfx, column, dark);
                dark = !dark;

                //// Draw mean line
                //int meanPos = isVertical
                //    ? column.Y + (int)((i.Mean.Avg - i.lowerEnd) / i.intervalSize)
                //    : column.X + (int)((i.Mean.Avg - i.lowerEnd) / i.intervalSize);
                //Point start = isVertical ? new Point(meanPos, column.X) : new Point(column.Y, meanPos);
                //Point end = isVertical ? new Point(meanPos, column.Right) : new Point(column.Bottom, meanPos);
                //gfx.DrawLine(Pens.Red, start, end);

                // Reset position for the next column
                if (isVertical)
                {
                    column.Y += colWidth;
                }
                else
                {
                    column.X += colWidth;
                    column.Y = histogramArea.Y;
                }
            }

            // Draw labels
            drawLabels(gfx, histogramArea, isVertical);
        }

        private void drawColumn(Graphics gfx, Rectangle column, bool dark) {
            SolidBrush brush = dark ? brush1 : brush2;
            gfx.FillRectangle(brush, column);
            gfx.DrawRectangle(Pens.Black, column);
        }

        private void drawLabels(Graphics gfx, Rectangle histogramArea, bool isVertical) {
            // the number of values in the distribution
            int n = distribution.intervals.Sum(i => i.Count);
            int intervalStep = distribution.intervals.Count / 10;
            double maxRelFreq = (double)max / (double)n;

            // Draw vertical axis
            gfx.DrawLine(Pens.Black, histogramArea.Location, new Point(histogramArea.X, drawingArea.Bottom));
            // Draw horizontal axis
            gfx.DrawLine(Pens.Black, new Point(drawingArea.X, histogramArea.Bottom), new Point(drawingArea.Right, histogramArea.Bottom));

            // Divide each axis in 10 parts
            int xStep = histogramArea.Width / 10;
            int yStep = histogramArea.Height / 10;

            // Draw x axis ticks and labels
            for (int i = 0; i < 10; i++)
            {
                int x = histogramArea.X + i * xStep;
                int y = histogramArea.Bottom;
                gfx.DrawLine(Pens.Black, new Point(x, y), new Point(x, y + 5));
                if (isVertical)
                {
                    // Print the relative frequency
                    gfx.DrawString($"{maxRelFreq/10.0 * i:F2}", new Font("Arial", fontSize - 10), Brushes.Black, new Point(x - 15, y + 5));
                }
                else
                {
                    // Print the lower end of the interval
                    gfx.DrawString($"{distribution.intervals[i * intervalStep].lowerEnd:F2}", new Font("Arial", fontSize - 10), Brushes.Black, new Point(x - 15, y + 5));
                }
            }

            // Draw y axis ticks and labels
            for (int i = 0; i < 10; i++)
            {
                int x = histogramArea.X;
                int y = histogramArea.Bottom - i * yStep;
                gfx.DrawLine(Pens.Black, new Point(x, y), new Point(x - 5, y));
                if (isVertical)
                {
                    // Print the lower end of the interval
                    gfx.DrawString($"{distribution.intervals[i * intervalStep].lowerEnd:F2}", new Font("Arial", fontSize - 10), Brushes.Black, new Point(x - 15, y - 15));
                    
                }
                else
                {
                    // Print the relative frequency
                    gfx.DrawString($"{maxRelFreq/10.0 * i:F2}", new Font("Arial", fontSize - 10), Brushes.Black, new Point(x - 15, y - 15));
                }
            }
        }

    }
}
