
namespace CurveLib
{
    public class CurveCanvasPoint
    {
        public int index;
        public double X;    // dobule. logical location in canvas.
        public double Y;

        /**
         * int. the pixel location in canvas.
         * But this is not the Panel pixel location (coordinate).
         * Because the origin point (0, 0) is different:
         *      Canvas origin point is at bottom left corner;
         *      Panel origin point is at top left corner.
         */
        //public int canvasX;
        //public int canvasY;

        public CurveCanvasPoint(int index, CurveCanvasPoint canvasPoint)
        {
            this.index = index;
            this.X = canvasPoint.X;
            this.Y = canvasPoint.Y;
        }

        public CurveCanvasPoint(int index, double x, double y)
        {
            this.index = index;
            this.X = x;
            this.Y = y;
        }

        override
        public string ToString()
        {
            string xStr = $"{X,5:N2}".Replace(".00", "   ");
            string yStr = $"{Y,5:N2}".Replace(".00", "   ");
            return $"({xStr}, {yStr})";
        }
    }
}
