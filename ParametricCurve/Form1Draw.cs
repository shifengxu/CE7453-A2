using CurveLib;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricCurve
{
    public partial class Form1
    {
        // ******************************************************************** drawCoordinateLines()
        private void DrawCoordinateLines(double? targetRatioX = null, double? targetRatioY = null)
        {
            int pWidth = panel1.Width;
            int pHeight = panel1.Height;

            Pen pen4Coordinate = new Pen(Color.LightGray, 2);
            pen4Coordinate.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            pen4Coordinate.DashPattern = new float[] { 1, 3 };
            int panelOriginX = _cc.RealX2CanvasX(0.0, targetRatioX);
            int panelOriginY = pHeight - _cc.RealY2CanvasY(0.0, targetRatioY);
            _g.DrawLine(pen4Coordinate, panelOriginX, 0, panelOriginX, pHeight);
            _g.DrawLine(pen4Coordinate, 0, panelOriginY, pWidth, panelOriginY);

            // draw number on X-axis: 1, 2, 3, , , 
            int valueX = 1;
            int panelX = _cc.RealX2CanvasX(valueX, targetRatioX);
            Brush brush = new SolidBrush(Color.LightGray);
            while(panelX < pWidth)
            {
                _g.DrawString($"{valueX}", panel1.Font, brush, panelX - 5, panelOriginY);
                _g.FillEllipse(brush, panelX - 3, panelOriginY - 3, 6, 6);
                valueX++;
                panelX = _cc.RealX2CanvasX(valueX, targetRatioX);
            }
            // draw number on X-axis: -1, -2, -3, , , 
            valueX = -1;
            panelX = _cc.RealX2CanvasX(valueX, targetRatioX);
            while (panelX > 0)
            {
                _g.DrawString($"{valueX}", panel1.Font, brush, panelX - 5, panelOriginY);
                _g.FillEllipse(brush, panelX - 3, panelOriginY - 3, 6, 6);
                valueX--;
                panelX = _cc.RealX2CanvasX(valueX, targetRatioX);
            }

            // draw number on Y-axis: 1, 2, 3, , , 
            int valueY = 1;
            int panelY = _cc.RealY2CanvasY(valueY, targetRatioY);
            while (panelY < pHeight)
            {
                _g.DrawString($"{valueY}", panel1.Font, brush, panelOriginX + 3, pHeight - panelY - 10);
                _g.FillEllipse(brush, panelOriginX - 3, pHeight - panelY - 3, 6, 6);
                valueY++;
                panelY = _cc.RealY2CanvasY(valueY, targetRatioY);
            }
            // draw number on Y-axis: -1, -2, -3, , , 
            valueY = -1;
            panelY = _cc.RealY2CanvasY(valueY, targetRatioY);
            while (panelY > 0)
            {
                _g.DrawString($"{valueY}", panel1.Font, brush, panelOriginX + 3, pHeight - panelY - 10);
                _g.FillEllipse(brush, panelOriginX - 3, pHeight - panelY - 3, 6, 6);
                valueY--;
                panelY = _cc.RealY2CanvasY(valueY, targetRatioY);
            }
        }

        // ******************************************************************** drawCurve()
        //private void UpdateCanvasAndDrawCurve()
        //{
        //    if (_curvePoints != null && _curvePoints.Count > 0)
        //    {
        //        _cc.UpdateCanvasSizeAndRatio(panel1.Width, panel1.Height);
        //    }

        //    DrawAll();
        //}

        private void DrawCurve()
        {
            if (_curvePoints == null || _curvePoints.Count == 0)
                return;

            // draw curve by points
            int penIdx = _panel1CurveCount % _pen4CurveArr.Length;
            Pen pen4Curve = _pen4CurveArr[penIdx];
            int pht = _cc.CanvasHeight;
            int prevCanvasX = _cc.RealX2CanvasX(_curvePoints[0].X);
            int prevCanvasY = _cc.RealY2CanvasY(_curvePoints[0].Y);
            int currCanvasX;
            int currCanvasY;
            for (int i = 1; i < _curvePoints.Count; i++)
            {
                var p = _curvePoints[i];
                currCanvasX = _cc.RealX2CanvasX(p.X);
                currCanvasY = _cc.RealY2CanvasY(p.Y);
                _g.DrawLine(pen4Curve, prevCanvasX, pht - prevCanvasY, currCanvasX, pht - currCanvasY);
                prevCanvasX = currCanvasX;
                prevCanvasY = currCanvasY;
            }
        }

        private void DrawPoint(double x, double y, Brush? b = null, bool drawCoordinate = true)
        {
            if (b == null)
                b = _brush4SamplePoint;

            int panelX = _cc.RealX2CanvasX(x);
            int panelY = _cc.CanvasHeight - _cc.RealY2CanvasY(y);
            _g.FillEllipse(b, panelX - 3, panelY - 3, 6, 6);
            if (drawCoordinate)
            {
                _g.DrawString($"({x,5:N3},{y,5:N3})", panel1.Font, b, panelX, panelY);
            }
        }

        private void DrawPoints(List<(double, double)> pList, SolidBrush? b = null)
        {
            if (pList == null || pList.Count == 0)
                return;

            if (pList.Count >= 200)
            {
                toolStripStatusLabel1.Text = $"Won't plot sample points as too many: {pList.Count}";
                return;
            }

            if (b == null)
                b = _brush4SamplePoint;

            bool drawCoordinate = pList.Count < 100;
            for (int i = 0; i < pList.Count; i++)
            {
                DrawPoint(pList[i].Item1, pList[i].Item2, b, drawCoordinate);
            }
        }

        private void DrawAndLinkPoints(List<(double, double)> pList, SolidBrush? b = null, Pen? p = null)
        {
            if (pList == null || pList.Count == 0)
                return;

            if (b == null)
                b = _brush4SamplePoint;

            if (p == null)
                p = new Pen(b.Color);

            for (int i = 0; i < pList.Count; i++)
            {
                DrawPoint(pList[i].Item1, pList[i].Item2, b);
            }
            var prevP = pList[0];
            for (int i = 1; i < pList.Count; i++)
            {
                int prevX = _cc.RealX2CanvasX(prevP.Item1);
                int prevY = _cc.CanvasHeight - _cc.RealY2CanvasY(prevP.Item2);
                int currX = _cc.RealX2CanvasX(pList[i].Item1);
                int currY = _cc.CanvasHeight - _cc.RealY2CanvasY(pList[i].Item2);
                _g.DrawLine(p, prevX, prevY, currX, currY);
                prevP = pList[i];
            }
        }

        private void DrawCubicPolynomial()
        {
            if (_tempCP.Coefficients == null || _tempCP.Coefficients.Count < 4)
                return;

            double minX = 0, maxX = 1;
            foreach (var p in _tempCP.SamplePoints)
            {
                minX = Math.Min(minX, p.Item1);
                maxX = Math.Max(maxX, p.Item1);
            }
            double c0 = _tempCP.Coefficients[0];
            double c1 = _tempCP.Coefficients[1];
            double c2 = _tempCP.Coefficients[2];
            double c3 = _tempCP.Coefficients[3];
            // draw curve by points
            Pen pen4Curve = new Pen(Color.Green, 2);
            int pht = _cc.CanvasHeight;
            double u = minX;
            double len = maxX - minX;
            int prevCanvasX = _cc.RealX2CanvasX(u);
            int prevCanvasY = _cc.RealY2CanvasY(c0 + c1 * u + c2 * u * u + c3 * u * u * u);
            for (int i = 1; i <= _panel1SegCount; i++)
            {
                u = minX + len * i / _panel1SegCount;
                var x = _cc.RealX2CanvasX(u);
                var y = _cc.RealY2CanvasY(c0 + c1*u + c2*u*u + c3*u*u*u);
                _g.DrawLine(pen4Curve, prevCanvasX, pht - prevCanvasY, x, pht - y);
                prevCanvasX = x;
                prevCanvasY = y;
            }

        }

        private void DrawFourier()
        {
            int pht = _cc.CanvasHeight;

            Pen pen4Curve = new Pen(Color.Red, 2);
            double realX = 0;
            double realY = _fourierEngine.CalcValue(realX);
            int prevPanelX = _cc.RealX2CanvasX(realX);
            int prevPanelY = pht - _cc.RealY2CanvasY(realY);
            int currPanelX;
            int currPanelY;
            for (int i = 1; i <= _panel1SegCount; i++)
            {
                realX = (double)i / _panel1SegCount;
                realY = _fourierEngine.CalcValue(realX);
                currPanelX = _cc.RealX2CanvasX(realX);
                currPanelY = pht - _cc.RealY2CanvasY(realY);
                _g.DrawLine(pen4Curve, prevPanelX, prevPanelY, currPanelX, currPanelY);
                prevPanelX = currPanelX;
                prevPanelY = currPanelY;
            }
        }

        private void DrawIntgrCompositeTrapezoid(List<(double X, double Y)> gridPoints)
        {
            int pht = _cc.CanvasHeight;
            int prevPanelX = _cc.RealX2CanvasX(gridPoints[0].X);
            int prevPanelY = pht - _cc.RealY2CanvasY(gridPoints[0].Y);
            int panelY0 = pht - _cc.RealY2CanvasY(0);
            Point prevP0 = new Point(prevPanelX, panelY0);
            Point prevP1 = new Point(prevPanelX, prevPanelY);

            Pen pen4Line = new Pen(Color.Green, 1);
            _g.DrawLine(pen4Line, prevPanelX, panelY0, prevPanelX, prevPanelY);
            Brush brush4Dot = new SolidBrush(Color.Green);
            _g.FillEllipse(brush4Dot, prevPanelX - 4, panelY0 - 4, 8, 8);

            Color cBgTransparent = Color.FromArgb(0, 0, 0, 0); // transparent background
            HatchBrush hBrush = new HatchBrush(HatchStyle.DashedHorizontal, Color.Green, cBgTransparent);

            for (int i = 1; i < gridPoints.Count; i++)
            {
                int currPanelX = _cc.RealX2CanvasX(gridPoints[i].X);
                int currPanelY = pht - _cc.RealY2CanvasY(gridPoints[i].Y);
                _g.DrawLine(pen4Line, currPanelX, panelY0, currPanelX, currPanelY);
                _g.FillEllipse(brush4Dot, currPanelX - 4, panelY0 - 4, 8, 8);

                Point currP0 = new Point(currPanelX, panelY0);
                Point currP1 = new Point(currPanelX, currPanelY);
                _g.FillPolygon(hBrush, new Point[] { prevP0, prevP1, currP1, currP0 });
                prevP0 = currP0;
                prevP1 = currP1;
            }
        }

        private void DrawIntgrCompositeSimpson(List<(double X, double Y)> gridPoints)
        {
            int pht = _cc.CanvasHeight;
            double delta = (double)1 / _panel1SegCount; // should be 0.001

            Pen pen4Curve = new Pen(Color.Red, 2);
            double realX = gridPoints[0].X;
            double realY = gridPoints[0].Y;
            int prevPanelX = _cc.RealX2CanvasX(realX);
            int prevPanelY = pht - _cc.RealY2CanvasY(realY);

            // draw vertical lines
            Pen pen4Line = new Pen(Color.Red, 1);
            Brush brush4Dot = new SolidBrush(Color.Red);
            var panelYAxis0 = pht - _cc.RealY2CanvasY(0);
            _g.DrawLine(pen4Line, prevPanelX, panelYAxis0, prevPanelX, prevPanelY);
            _g.FillEllipse(brush4Dot, prevPanelX - 4, panelYAxis0 - 4, 8, 8);

            Color cBgTransparent = Color.FromArgb(0, 0, 0, 0); // transparent background
            HatchBrush hBrush = new HatchBrush(HatchStyle.DashedVertical, Color.Red, cBgTransparent);

            int currPanelX;
            int currPanelY;
            for (int i = 2; i < gridPoints.Count; i+=2)
            {
                var P0 = gridPoints[i - 2];
                var P1 = gridPoints[i - 1];
                var P2 = gridPoints[i];
                for (realX = P0.X + delta; realX <= P2.X; realX += delta)
                {
                    realY = IntegrationEngine.LagrangeValueOrder2(realX, P0, P1, P2);
                    currPanelX = _cc.RealX2CanvasX(realX);
                    currPanelY = pht - _cc.RealY2CanvasY(realY);
                    // draw Lagrange order 2 curve
                    _g.DrawLine(pen4Curve, prevPanelX, prevPanelY, currPanelX, currPanelY);
                    prevPanelX = currPanelX;
                    prevPanelY = currPanelY;
                }
                // draw vertical lines
                var panelX1 = _cc.RealX2CanvasX(P1.X);
                var panelY1 = pht - _cc.RealY2CanvasY(P1.Y);
                var panelX2 = _cc.RealX2CanvasX(P2.X);
                var panelY2 = pht - _cc.RealY2CanvasY(P2.Y);
                _g.DrawLine(pen4Line, panelX1, panelYAxis0, panelX1, panelY1);
                _g.DrawLine(pen4Line, panelX2, panelYAxis0, panelX2, panelY2);
                _g.FillEllipse(brush4Dot, panelX1 - 4, panelYAxis0 - 4, 8, 8);
                _g.FillEllipse(brush4Dot, panelX2 - 4, panelYAxis0 - 4, 8, 8);

                // draw rectangle for the Simpson area
                DrawCompositeSimpsonRects(P0, P1, P2, panelYAxis0, hBrush);
            }
        }

        private void DrawIntgrGaussianQuadrature(List<(double x, double y, double weight)> xywList, double minX, double maxX)
        {
            int pht = _cc.CanvasHeight;
            Color cBgTransparent = Color.FromArgb(0, 0, 0, 0); // transparent background
            HatchBrush hBrush = new HatchBrush(HatchStyle.DashedVertical, Color.YellowGreen, cBgTransparent);

            Pen pen4Line = new Pen(Color.YellowGreen, 2);
            Brush brush4Dot = new SolidBrush(Color.YellowGreen);

            // the weight sum should be the X-axis length: maxX - minX
            // so when calculating the x value, we can just use: minX + wAccu
            double wAccu = 0; // weight accumulation
            int prevPanelX = _cc.RealX2CanvasX(minX);
            int panelY0 = pht - _cc.RealY2CanvasY(0);
            foreach (var (x, y, weight) in xywList)
            {
                // draw line
                int currPanelX = _cc.RealX2CanvasX(x);
                int currPanelY = pht - _cc.RealY2CanvasY(y);
                _g.DrawLine(pen4Line, currPanelX, panelY0, currPanelX, currPanelY);

                // draw dot
                _g.FillEllipse(brush4Dot, currPanelX - 4, panelY0 - 4, 8, 8);

                // draw rectangle
                wAccu += weight;
                currPanelX = _cc.RealX2CanvasX(minX + wAccu);
                int w = currPanelX - prevPanelX;
                int h = panelY0 - currPanelY;
                DrawIntgrGaussianQuadratureRect(hBrush, prevPanelX, currPanelY, w, h);
                prevPanelX = currPanelX;
            }
        }

        private void DrawIntgrGaussianQuadratureRect(Brush brush, int panelX, int panelY, int w, int h)
        {
            if (h < 0)
            {
                h = -h;
                panelY -= h;
            }
            Rectangle rect = new Rectangle(panelX, panelY, w, h);
            _g.FillRectangle(brush, rect);
        }

        private void DrawCompositeSimpsonRects((double X, double Y) P0, (double X, double Y) P1,
            (double X, double Y) P2, int panelYAxis0, Brush brush)
        {
            var pht = _cc.CanvasHeight;
            var panelX0 = _cc.RealX2CanvasX(P0.X);
            var panelY0 = pht - _cc.RealY2CanvasY(P0.Y);
            var panelX1 = _cc.RealX2CanvasX(P1.X);
            var panelY1 = pht - _cc.RealY2CanvasY(P1.Y);
            var panelX2 = _cc.RealX2CanvasX(P2.X);
            var panelY2 = pht - _cc.RealY2CanvasY(P2.Y);
            int w = (panelX1 - panelX0) / 3;
            int h = panelYAxis0 - panelY0;
            DrawCompositeSimpsonRect(panelX0, panelY0, w, h, brush);

            var panelX = panelX1 - (panelX1 - panelX0) * 2 / 3;
            w = (panelX1 - panelX0) * 2 / 3 + (panelX2 - panelX1) * 2 / 3;
            h = panelYAxis0 - panelY1;
            DrawCompositeSimpsonRect(panelX, panelY1, w, h, brush);

            panelX = panelX2 - (panelX2 - panelX1) / 3;
            w = (panelX2 - panelX1) / 3;
            h = panelYAxis0 - panelY2;
            DrawCompositeSimpsonRect(panelX, panelY2, w, h, brush);
        }

        private void DrawCompositeSimpsonRect(int panelX, int panelY, int w, int h, Brush brush)
        {
            if (h < 0)
            {
                h = -h;
                panelY -= h;
            }
            Rectangle rect = new Rectangle(panelX, panelY, w, h);
            _g.FillRectangle(brush, rect);
        }

        private void DrawBspline()
        {
            int pht = _cc.CanvasHeight;
            SolidBrush brush4Rect = new SolidBrush(Color.Red);
            // draw control points
            for (int i = 0; i < _bspline.ControlPoints.Count; i++)
            {
                var p = _bspline.ControlPoints[i];
                int panelX = _cc.RealX2CanvasX(p.X);
                int panelY = pht - _cc.RealY2CanvasY(p.Y);
                _g.FillRectangle(brush4Rect, panelX - 3, panelY - 3, 6, 6);
            }

            // draw B-Spline curve by points
            Pen pen4Curve = new Pen(Color.Red, 2);
            var prevP = _bspline.GetXYByUValue(0);
            int prevPanelX = _cc.RealX2CanvasX(prevP.X);
            int prevPanelY = pht - _cc.RealY2CanvasY(prevP.Y);
            int currPanelX;
            int currPanelY;
            (double X, double Y) currP;
            for (int i = 1; i < _panel1SegCount; i++)
            {
                currP = _bspline.GetXYByUValue((double)i / _panel1SegCount);
                currPanelX = _cc.RealX2CanvasX(currP.X);
                currPanelY = pht - _cc.RealY2CanvasY(currP.Y);
                _g.DrawLine(pen4Curve, prevPanelX, prevPanelY, currPanelX, currPanelY);
                prevPanelX = currPanelX;
                prevPanelY = currPanelY;
            }
            currP = _bspline.TargetPoints.Last();
            currPanelX = _cc.RealX2CanvasX(currP.X);
            currPanelY = pht - _cc.RealY2CanvasY(currP.Y);
            _g.DrawLine(pen4Curve, prevPanelX, prevPanelY, currPanelX, currPanelY);
        }

        private void DrawAll()
        {
            // clear old graph
            _g.Clear(Color.White);

            DrawCoordinateLines();
            DrawCurve();
            DrawPoints(listBoxPoints.Points);
            DrawCubicPolynomial();
            if (_bsplineSelectFlag)
            {
                DrawAndLinkPoints(listBoxPoints.Points);
            }
        }

        private void ScaleWhenMouseMove(int X, int Y)
        {
            bool needRedraw = false;
            double changeX = 1;
            double changeY = 1;
            if (_scaleXFlag && _scaleXMouseDownValue != 0)
            {
                var newX = X;
                changeX = (double)newX / _scaleXMouseDownValue;
                needRedraw = true;
            }
            if (_scaleYFlag && _scaleYMouseDownValue != 0)
            {
                var newY = panel1.Height - Y;
                var oldY = panel1.Height - _scaleYMouseDownValue;
                changeY = (double)newY / oldY;
                needRedraw = true;
            }
            if (needRedraw)
            {
                _g.Clear(Color.White);
                DrawCoordinateLines(_cc.TargetRatioX * changeX, _cc.TargetRatioY * changeY);
            }
        }

        private int AddExpression(string expr)
        {
            int s = 0;
            s += AddExpression2ComboBox(expr, comboBoxX);
            s += AddExpression2ComboBox(expr, comboBoxY);
            return s;
        }

        /**
         * Add "cubicX(u)" or "cubicY(u)" into combobox.
         */
        private int AddExpression2ComboBox(string expr, ComboBox cb)
        {
            foreach (var item in cb.Items)
            {
                if (item.ToString() == expr)
                    return 0;
            }
            cb.Items.Add(expr);
            return 1;
        }

        private void AddDrawBsplineTargetPoint(object sender, MouseEventArgs e)
        {
            double cursorRealX = _cc.CanvasX2RealX(e.X);
            double cursorRealY = _cc.CanvasY2RealY(_cc.CanvasHeight - e.Y);
            if (_curvePoints == null || _curvePoints.Count == 0 || _panel1CurveCount == 0)
            {
                //MessageBox.Show("Please draw curve first.");
                //return;
                listBoxPoints.Add(cursorRealX, cursorRealY);
            }
            else
            {
                // squared distance
                Func<double, double, double, double, double> sd = (a, b, c, d) => (a - c) * (a - c) + (b - d) * (b - d);
                var nearestP = _curvePoints[0];
                double nearestDist = sd(nearestP.X, nearestP.Y, cursorRealX, cursorRealY);
                for (int i = 1; i < _curvePoints.Count; i++)
                {
                    var point = _curvePoints[i];
                    var dist = sd(point.X, point.Y, cursorRealX, cursorRealY);
                    if (dist < nearestDist)
                    {
                        nearestDist = dist;
                        nearestP = point;
                    }
                }// for
                listBoxPoints.Add((nearestP.X, nearestP.Y));
            }

            DrawAndLinkPoints(listBoxPoints.Points);
        }

    }
}
