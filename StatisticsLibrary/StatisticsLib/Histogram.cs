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
        private int max = 0;
        // Scaling factor for each column height
        private double scaleFactor;
        private bool vertical;

        // Utils to draw
        SolidBrush brush1 = new SolidBrush(Color.Green);
        SolidBrush brush2 = new SolidBrush(Color.Lime);


        public Histogram(ContinuousDistribution distribution, bool vertical) {
            this.distribution = distribution;
            this.vertical = vertical;
            InitHisto();
        }


        // Methods
        private void InitHisto() {
            foreach (Interval i in distribution.intervals) {
                if (i.Count > max) max = i.Count;
            }
        }

        public override void Draw(Graphics gfx) {
            if (vertical) DrawVertical(gfx);
            else DrawHorizontal(gfx);
        }

        private void DrawHorizontal(Graphics gfx) {
            int colsNum, colWidth;
            bool dark = true;

            // Calculate Scaling factor
            scaleFactor = (double)drawingArea.Height / (double)max;

            // Get cols and width
            colsNum = distribution.intervals.Count;
            colWidth = drawingArea.Width / colsNum;

            // Create rectangle to draw the histogram columns ==> Initially y and height are not correct
            Rectangle column = new Rectangle(drawingArea.X, drawingArea.Y, colWidth, drawingArea.Height);

            foreach (Interval i in distribution.intervals) {
                int colHeight = (int)Math.Round(i.Count * scaleFactor);
                int d = drawingArea.Height - colHeight;
                column.Height = colHeight;
                column.Y += d;
                if (dark) {
                    gfx.FillRectangle(brush1, column);
                    dark = !dark;
                }
                else {
                    gfx.FillRectangle(brush2, column);
                    dark = !dark;
                }
                gfx.DrawRectangle(Pens.Black, column);

                // Draw mean line
                int meanX = column.X + (int)((i.Mean.Avg - i.lowerEnd) / i.intervalSize);
                Point top = new Point(meanX, column.Y);
                Point bot = new Point(meanX, column.Bottom);
                gfx.DrawLine(Pens.Red, top, bot);

                // Reset position for next column
                column.X += colWidth;
                column.Y = drawingArea.Y;
            }
        }

        private void DrawVertical(Graphics gfx) {
            int rowsNum, rowHeight;
            bool dark = true;

            // Calculate Scaling factor
            scaleFactor = (double)drawingArea.Width / (double)max;

            // Get cols and width
            rowsNum = distribution.intervals.Count;
            rowHeight = drawingArea.Height / rowsNum;

            // Create rectangle to draw the histogram columns ==> Initially the width is not correct
            Rectangle column = new Rectangle(drawingArea.X, drawingArea.Bottom - rowHeight, drawingArea.Width, rowHeight);

            foreach (Interval i in distribution.intervals) {
                column.Width = (int)Math.Round(i.Count * scaleFactor);
                if (dark) {
                    gfx.FillRectangle(brush1, column);
                    dark = !dark;
                }
                else {
                    gfx.FillRectangle(brush2, column);
                    dark = !dark;
                }
                gfx.DrawRectangle(Pens.Black, column);

                // Draw mean line
                int meanY = column.Y + (int)((i.Mean.Avg - i.lowerEnd) / i.intervalSize);
                Point top = new Point(column.X, meanY);
                Point bot = new Point(column.Right, meanY);
                gfx.DrawLine(Pens.Red, top, bot);

                // Reset position for next column
                column.Y -= rowHeight;
            }
        }

    }
}
