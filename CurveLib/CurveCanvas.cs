
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
        private readonly int h = 46; // student index of Xu Shifeng on CE7453

        private readonly List<CurveCanvasPoint> points = new List<CurveCanvasPoint>();

        // X * TargetRatioX = canvasX; Y * TargetRatioY = canvasY
        public double TargetRatioX { get; set; } = 1;
        public double TargetRatioY { get; set; } = 1;

        private int _canvasMarginX = 0;
        public int CanvasMarginX { get => _canvasMarginX; }

        private int _canvasMarginY = 0;
        public int CanvasMarginY { get => _canvasMarginY; }

        private double _minX = 0;
        public double MinX { get => _minX; }

        private double _maxX = 0;
        public double MaxX { get => _maxX; }

        private double _minY = 0;
        public double MinY { get => _minY; }

        private double _maxY = 0;
        public double MaxY { get => _maxY; }

        private int _canvasWidth = 0;
        public int CanvasWidth { get => _canvasWidth; }

        private int _canvasHeight = 0;
        public int CanvasHeight { get => _canvasHeight; }

        public CurveCanvas(int canvasWidth, int canvasHeight)
        {
            this._canvasWidth = canvasWidth;
            this._canvasHeight = canvasHeight;
        }

        private double CalcX(double u)
        {
            double res;
            res = 1.5 * Math.Sin(6.2 * u - 0.027 * h);
            res = Math.Exp(res) + 0.1;
            res = 1.5 * res * Math.Cos(12.2 * u);
            return res;
        }

        private double CalcY(double u)
        {
            double res;
            res = Math.Sin(6.2 * u - 0.027 * h);
            res = Math.Exp(res) + 0.1;
            res = res * Math.Sin(12.2 * u);
            return res;
        }

        private CurveCanvasPoint CalcPoint(double u)
        {
            var x = CalcX(u);
            var y = CalcY(u);
            return new CurveCanvasPoint(0, x, y);
        }

        public List<CurveCanvasPoint> CalcCurve(int segmentCount = 1000)
        {
            points.Clear();
            var p0 = CalcPoint(0);
            p0.index = 0;
            _minX = _maxX = p0.X;
            _minY = _maxY = p0.Y;
            points.Add(p0);

            for(int i = 1; i <= segmentCount; i++)
            {
                var p = CalcPoint((double)i / segmentCount);
                p.index = i;
                _minX = Math.Min(p.X, _minX);
                _minY = Math.Min(p.Y, _minY);
                _maxX = Math.Max(p.X, _maxX);
                _maxY = Math.Max(p.Y, _maxY);
                points.Add(p);
            }
            //UpdateCanvasSize(CanvasWidth, CanvasHeight);
            return points;
        }

        #region CalcCurveByType
        public double CalcValueByType(string type, double u)
        {
            double x;
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
            else
            {
                throw new ArgumentException($"Unsupported type: {type}");
            }
            return x;
        }

        private CurveCanvasPoint CalcPointByType(string xType, string yType, double u)
        {
            double x = CalcValueByType(xType, u);
            double y = CalcValueByType(yType, u);
            return new CurveCanvasPoint(0, x, y);
        }

        public List<CurveCanvasPoint> CalcCurveByType(string xType, string yType, int segmentCount = 1000)
        {
            points.Clear();
            var p0 = CalcPointByType(xType, yType, 0);
            p0.index = 0;
            _minX = _maxX = p0.X;
            _minY = _maxY = p0.Y;
            points.Add(p0);

            for (int i = 1; i <= segmentCount; i++)
            {
                var p = CalcPointByType(xType, yType, (double)i / segmentCount);
                p.index = i;
                _minX = Math.Min(p.X, _minX);
                _minY = Math.Min(p.Y, _minY);
                _maxX = Math.Max(p.X, _maxX);
                _maxY = Math.Max(p.Y, _maxY);
                points.Add(p);
            }
            //UpdateCanvasSize(CanvasWidth, CanvasHeight);
            return points;
        }
        #endregion

        #region CalcCurveByExpr()
        //public List<CurveCanvasPoint> CalcCurveByExpr(string exprX, string exprY, int segmentCount = 1000)
        //{
        //    var p0 = CalcPointByExpr(0, exprX, exprY);
        //    p0.index = 0;
        //    _minX = _maxX = p0.X;
        //    _minY = _maxY = p0.Y;

        //    points.Clear();
        //    points.Add(p0);

        //    for (int i = 1; i <= segmentCount; i++)
        //    {
        //        var p = CalcPointByExpr((double)i / segmentCount, exprX, exprY);
        //        p.index = i;
        //        _minX = Math.Min(p.X, _minX);
        //        _minY = Math.Min(p.Y, _minY);
        //        _maxX = Math.Max(p.X, _maxX);
        //        _maxY = Math.Max(p.Y, _maxY);
        //        points.Add(p);
        //    }
        //    //UpdateCanvasSize(CanvasWidth, CanvasHeight);
        //    return points;
        //}

        //private CurveCanvasPoint CalcPointByExpr(double u, string exprX, string exprY)
        //{
        //    exprX = $"double u = {u};\r\n" + exprX;
        //    exprY = $"double u = {u};\r\n" + exprY;
        //    double x = (double)CSharpScript.EvaluateAsync(exprX).Result;
        //    double y = (double)CSharpScript.EvaluateAsync(exprY).Result;
        //    return new CurveCanvasPoint(0, x, y);
        //}
        #endregion

        public void UpdateCanvasSizeAndRatio(int width, int height)
        {
            _canvasWidth = width;
            _canvasHeight = height;
            _canvasMarginX = width / 10;
            _canvasMarginY = height / 10;

            double delta_x = _maxX - _minX;
            double delta_y = _maxY - _minY;
            // as delta_x or delta_y could be 0, so not divide by them.
            double ratio_x = (double)delta_x / (width - 2 * _canvasMarginX);
            double ratio_y = (double)delta_y / (height - 2 * _canvasMarginY);
            double ratio = Math.Max(ratio_x, ratio_y);
            if (ratio == 0)
                return;
            else
                TargetRatioX = TargetRatioY = 1.0 / ratio;

            //foreach (var p in points)
            //{
            //    p.canvasX = RealX2CanvasX(p.X);
            //    p.canvasY = RealY2CanvasY(p.Y);
            //}
        }

        public int RealX2CanvasX(double x, double? targetRatioX = null)
        {
            if (targetRatioX == null)
                targetRatioX = TargetRatioX;

            return (int)((x - _minX) * targetRatioX) + _canvasMarginX;
        }

        public int RealY2CanvasY(double y, double? targetRatioY = null)
        {
            if (targetRatioY == null)
                targetRatioY = TargetRatioY;

            return (int)((y - _minY) * targetRatioY) + _canvasMarginY;
        }

        public double CanvasX2RealX(int x, double? targetRatioX = null)
        {
            if (targetRatioX == null)
                targetRatioX = TargetRatioX;

            return (double)(x - _canvasMarginX) / targetRatioX.Value + _minX;
        }

        public double CanvasY2RealY(int y, double? targetRatioY = null)
        {
            if (targetRatioY == null)
                targetRatioY = TargetRatioY;

            return (double)(y - _canvasMarginY) / targetRatioY.Value + _minY;
        }

    }
}