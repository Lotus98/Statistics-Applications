using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Application_1
{
    // Creating a separate class for the balls to manage multiple instances
    class Ball
    {
        public int x;
        public int y;
        public int radius;
        public int moveX;
        public int moveY;

        public Ball(int x, int y, int radius, int moveX, int moveY)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.moveX = moveX;
            this.moveY = moveY;
        }

        public void MoveBall(Rectangle box)
        {
            x += moveX;
            if ((x+radius) >= box.Width || x <= box.X)
            {
                moveX = -moveX;
            }
            y += moveY;
            if ((y + radius) >= box.Height || y <= box.Y)
            {
                moveY = -moveY;
            }
        }

    }
}
