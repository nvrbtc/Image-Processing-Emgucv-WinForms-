using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO_Tsarehradskiy.Services
{
    public class RoiHandler
    {
        private Rectangle rectangle;
        private bool MouseDown = false;
        private Point startPosition;
        private Point endPosition;

        public void MouseDownEvent(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            startPosition = e.Location;
        }
        public void MouseMoveEvent(object sender, MouseEventArgs e)
        {

            if (MouseDown)
            {
                endPosition = e.Location;
                (sender as PanAndZoomPictureBox)?.Invalidate();
            }
        }
        public void PaintEvent(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(Pens.DarkRed, GetRectangle());

        }
        public void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                endPosition = e.Location;
                MouseDown = false;

                /// todo 

            }
        }
        private Rectangle GetRectangle()
        {
            rectangle = new Rectangle();

            rectangle.X = Math.Min(startPosition.X, endPosition.X);
            rectangle.Y = Math.Min(startPosition.Y, endPosition.Y);

            rectangle.Width = Math.Abs(startPosition.X - endPosition.X);
            rectangle.Height = Math.Abs(startPosition.Y - endPosition.Y);

            return rectangle;
        }
    }
}
