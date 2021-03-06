
namespace CurveLib
{
    /**
     * The curve canvas.
     * The canvas is a Panel in the form UI. And the canvas size is just the panel size.
     * The canvas is mathematical, and its origin point (0, 0) is at bottom left.
     * But the form UI panel is pixel-wise, and its origin point is at top left.
     */
    public class CurveCanvas
    {
        public int h = 46; // student index of Xu Shifeng on CE7453

        // Such offset is just to move the curve in the coordinates.
        // they are for and only for x(u) and y(u).
        // The Initial purpose is to move the curve above X-axis. that is, y value > 0.
        public double ExprOffsetX = 0;
        public double ExprOffsetY = 0;

        private readonly List<(double X, double Y)> points = new List<(double X, double Y)>();

        // X * TargetRatioX = canvasX; Y * TargetRatioY = canvasY
        public double TargetRatioX { get; set; } = 100;
        public double TargetRatioY { get; set; } = 100;

        public int CanvasMarginX { get; set; }

        public int CanvasMarginY { get; set; }

        private int _canvasWidth = 0;
        public int CanvasWidth { get => _canvasWidth; }

        private int _canvasHeight = 0;
        public int CanvasHeight { get => _canvasHeight; }

        public CubicPolynomial ExpressionCubicX = new CubicPolynomial("cubicX(u)");
        public CubicPolynomial ExpressionCubicY = new CubicPolynomial("cubicY(u)");

        public FourierEngine ExpressionFourierX = new FourierEngine("fourierX(u)");
        public FourierEngine ExpressionFourierY = new FourierEngine("fourierY(u)");

        public CurveCanvas(int canvasWidth, int canvasHeight)
        {
            this._canvasWidth = canvasWidth;
            this._canvasHeight = canvasHeight;
            CanvasMarginX = canvasWidth / 2;
            CanvasMarginY = canvasHeight / 2;
        }

        private double CalcX(double u)
        {
            double res;
            res = 1.5 * Math.Sin(6.2 * u - 0.027 * h);
            res = Math.Exp(res) + 0.1;
            res = 1.5 * res * Math.Cos(12.2 * u);
            res += ExprOffsetX;
            return res;
        }

        private double CalcY(double u)
        {
            double res;
            res = Math.Sin(6.2 * u - 0.027 * h);
            res = Math.Exp(res) + 0.1;
            res = res * Math.Sin(12.2 * u);
            res += ExprOffsetY;
            return res;
        }

        #region CalcCurveByType
        public double CalcValueByType(string type, double u)
        {
            double x = 0;
            if (type == "x(u)")
            {
                x = CalcX(u);
            }
            else if (type == "y(u)")
            {
                x = CalcY(u);
            }
            else if (type == "u")
            {
                x = u;
            }
            else if (type == "cubicX(u)" || type == "cubicY(u)")
            {
                var expr = type == "cubicX(u)" ? ExpressionCubicX : ExpressionCubicY;
                var c = expr.Coefficients;
                if (c != null)
                    x = c[0] + c[1] * u + c[2] * u * u + c[3] * u * u * u;
            }
            else if (type == "fourierX(u)" || type == "fourierY(u)")
            {
                var expr = type == "fourierX(u)" ? ExpressionFourierX : ExpressionFourierY;
                x = expr.CalcValue(u);
            }
            else
            {
                throw new ArgumentException($"Unsupported type: {type}");
            }
            return x;
        }

        private (double X, double Y) CalcPointByType(string xType, string yType, double u)
        {
            double x = CalcValueByType(xType, u);
            double y = CalcValueByType(yType, u);
            return (x, y);
        }

        public List<(double X, double Y)> CalcCurveByType(string xType, string yType, int segmentCount = 1000)
        {
            points.Clear();
            var p0 = CalcPointByType(xType, yType, 0);
            points.Add(p0);

            for (int i = 1; i <= segmentCount; i++)
            {
                var p = CalcPointByType(xType, yType, (double)i / segmentCount);
                points.Add(p);
            }
            return points;
        }
        #endregion

        public void UpdateSizeMarginRatio(int width, int height)
        {
            _canvasWidth = width;
            _canvasHeight = height;
            double minX = 0, minY = 0, maxX = 0, maxY = 0;

            if (points != null && points.Count > 0)
            {
                var p0 = points[0];
                minX = maxX = p0.X;
                minY = maxY = p0.Y;
                for (int i = 1; i < points.Count; i++)
                {
                    var p = points[i];
                    minX = Math.Min(p.X, minX);
                    minY = Math.Min(p.Y, minY);
                    maxX = Math.Max(p.X, maxX);
                    maxY = Math.Max(p.Y, maxY);
                }
            }

            double delta_x = maxX - minX;
            double delta_y = maxY - minY;
            // as delta_x or delta_y could be 0, so not divide by them.
            double ratio_x = (double)delta_x / (width * 0.8);
            double ratio_y = (double)delta_y / (height * 0.8);
            double ratioMax = Math.Max(ratio_x, ratio_y);
            if (ratioMax > 0)
            {
                TargetRatioX = ratio_x == 0 ? 1.0 / ratioMax : 1.0 / ratio_x;
                TargetRatioY = ratio_y == 0 ? 1.0 / ratioMax : 1.0 / ratio_y;
            }
            CanvasMarginX = (int)(-minX * TargetRatioX + 0.1 * _canvasWidth);
            CanvasMarginY = (int)(-minY * TargetRatioY + 0.1 * _canvasHeight);
        }

        #region Real value <=> Canvas value
        public int RealX2CanvasX(double x, double? targetRatioX = null)
        {
            if (targetRatioX == null)
                targetRatioX = TargetRatioX;

            return (int)(x * targetRatioX) + CanvasMarginX;
        }

        public int RealY2CanvasY(double y, double? targetRatioY = null)
        {
            if (targetRatioY == null)
                targetRatioY = TargetRatioY;

            return (int)(y * targetRatioY) + CanvasMarginY;
        }

        public double CanvasX2RealX(int x, double? targetRatioX = null)
        {
            if (targetRatioX == null)
                targetRatioX = TargetRatioX;

            return (double)(x - CanvasMarginX) / targetRatioX.Value;
        }

        public double CanvasY2RealY(int y, double? targetRatioY = null)
        {
            if (targetRatioY == null)
                targetRatioY = TargetRatioY;

            return (double)(y - CanvasMarginY) / targetRatioY.Value;
        }
        #endregion

    }
}