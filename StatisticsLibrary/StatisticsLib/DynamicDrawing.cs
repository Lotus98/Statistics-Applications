using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticsLib {
    public abstract class DynamicDrawing {
        public Rectangle drawingArea;

        // Resize according to InteractiveRectangle and draw
        public void ResizeDraw(Graphics gfx, Rectangle actualArea) {
            drawingArea = actualArea;
            this.Draw(gfx);

            return;
        }

        // Abstract method to draw the actual content (Will be defined in implementation classes)
        abstract public void Draw(Graphics gfx);
    }
}
