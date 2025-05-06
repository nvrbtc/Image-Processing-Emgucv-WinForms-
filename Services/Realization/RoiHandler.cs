namespace APO_Tsarehradskiy.Services
{
    public delegate void GetValuesFromSegment(List<Point> points);
    public class RoiHandler
    {
        public GetValuesFromSegment? NotifyLineMoved;
        private PictureBox Surface { get; init; }
        private const uint GRAB_LINE_DISTANCE = 10;

        private bool LineIsMoving = false;
        private bool MouseDown = false;

        private int x0, y0;
        private int x1, y1;

        private int xStartMove, yStartMove;
        private int dx, dy;
        public RoiHandler(PictureBox surface)
        {
            Surface = surface;
        }

        public void MouseDownEvent(object sender, MouseEventArgs e)
        {
            if (IsNearLine(e.Location))
            {
                LineIsMoving = true;
                xStartMove = e.Location.X;
                yStartMove = e.Location.Y;
            }
            else
            {
                MouseDown = true;
                x0 = e.Location.X;
                y0 = e.Location.Y;
            }
        }
        public void MouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (LineIsMoving)
            {
                dx = e.Location.X - xStartMove;
                dy = e.Location.Y - yStartMove;

                x0 += dx;
                y0 += dy;
                x1 += dx;
                y1 += dy;

                xStartMove = e.Location.X;
                yStartMove = e.Location.Y;

                GetLinePoints(x0, y0, x1, y1);
                Surface?.Invalidate();
                return;
            }
            if (MouseDown)
            {
                x1 = e.Location.X;
                y1 = e.Location.Y;
                GetLinePoints(x0, y0, x1, y1);
                Surface?.Invalidate();
            }
        }
        public void PaintEvent(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkRed, x0, y0, x1, y1);
        }
        public void MouseUpEvent(object sender, MouseEventArgs e)
        {
            if (LineIsMoving)
            {
                LineIsMoving = false;

            }
            if (MouseDown)
            {
                x1 = e.Location.X;
                y1 = e.Location.Y;
                MouseDown = false;
            }
        }
        public void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'g')
            {
                x0 = x1 = y0 = y1 = -1;
                Surface?.Invalidate();
            }
        }
        public bool IsNearLine(Point p)
        {

            float dx = x1 - x0;
            float dy = y1 - y0;

            if (dx == 0 && dy == 0)
            {
                // Отрезок - точка
                return Math.Sqrt((p.X - x0) * (p.X - x0) + (p.Y - y0) * (p.Y - y0)) <= GRAB_LINE_DISTANCE;
            }

            float t = ((p.X - x0) * dx + (p.Y - y0) * dy) / (dx * dx + dy * dy);
            t = Math.Max(0, Math.Min(1, t));

            float nearestX = x0 + t * dx;
            float nearestY = y0 + t * dy;

            float distX = p.X - nearestX;
            float distY = p.Y - nearestY;

            return Math.Sqrt(distX * distX + distY * distY) <= GRAB_LINE_DISTANCE;
        }
        public void GetLinePoints(int x0, int y0, int x1, int y1)
        {
            List<Point> points = new List<Point>();

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                points.Add(new Point(x0, y0));

                if (x0 == x1 && y0 == y1) break;

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }

            NotifyLineMoved?.Invoke(points);
        }
    }
}
