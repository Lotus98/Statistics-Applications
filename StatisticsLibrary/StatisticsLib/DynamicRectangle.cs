namespace StatisticsLib {
    public class DynamicRectangle {
        // Constants
        public const int MIN_WIDTH = 50;
        public const int MIN_HEIGHT = 50;

        // Main components
        public Rectangle rect;
        public PictureBox pictureBox;
        // Content
        //public DynamicDrawing drawing;

        // Variables needed for Mouse control
        private Point mouseP;


        public DynamicRectangle(Rectangle rect, PictureBox pictureBox) {
            this.rect = rect;
            this.pictureBox = pictureBox;
            // Binds the handlers for the pictureBox
            BindControls();
        }

        private void BindControls() {
            this.pictureBox.MouseDown += MouseDownHandler;
            this.pictureBox.MouseMove += MouseMoveHandler;
            this.pictureBox.MouseUp += MouseUpHandler;
        }

        public void Draw(Graphics gfx) {

            // Draw resized content
            //if (!(drawing == null)) {
            //    drawing.ResizeDraw(gfx, this.rect);
            //}
            //else {
            //    gfx.DrawRectangle(Pens.Black, this.rect);
            //}            
            gfx.DrawRectangle(Pens.Black, this.rect);

        }

        private void MouseDownHandler(object sender, MouseEventArgs e) {
            if (rect.Contains(e.Location)) mouseP = e.Location;

            return;
        }

        private void MouseUpHandler(object sender, MouseEventArgs e) {
            mouseP = new Point();
        }

        private void MouseMoveHandler(object sender, MouseEventArgs e) {
            if (!mouseP.IsEmpty) {

                // Left click moves
                if (e.Button == MouseButtons.Left) {
                    Point moveP = new Point(mouseP.X - e.X, mouseP.Y - e.Y);
                    Point newLocation = new Point(rect.X - moveP.X, rect.Y - moveP.Y);

                    // Don't move out of the pictureBox
                    if (!(0 > newLocation.X) &&
                            !(0 > newLocation.Y) &&
                            !((pictureBox.Width) <= (newLocation.X + rect.Width)) &&
                            !((pictureBox.Height) <= (newLocation.Y + rect.Height))) {
                        rect.Location = newLocation;
                    }

                }
                // Right click resize
                else if (e.Button == MouseButtons.Right) {

                    Point resP = new Point(e.X - mouseP.X, e.Y - mouseP.Y);
                    // Don't shrink past MIN consts && don't enlarge past pictureBox
                    if (!((rect.Width + resP.X) < MIN_WIDTH) && !((rect.Location.X + rect.Width + resP.X) >= (pictureBox.Width)))
                        rect.Width += resP.X;
                    if (!((rect.Height + resP.Y) < MIN_HEIGHT) && !((rect.Location.Y + rect.Height + resP.Y) >= (pictureBox.Height)))
                        rect.Height += resP.Y;
                }
                mouseP = e.Location;
            }
        }

    }
}