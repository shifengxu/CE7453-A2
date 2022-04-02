using System;
using System.Collections.Generic;
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
            textBoxXScale.Text = $"{_cc.TargetRatioX,5:N2}".Replace(".00", "");
            textBoxYScale.Text = $"{_cc.TargetRatioY,5:N2}".Replace(".00", "");
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

        private void DrawSamplePoints()
        {
            if (_sampledU == null)
                return;

            for (int i = 0; i < _sampledU.Count; i++)
            {
                DrawSamplePoint(_sampledU[i], _sampledFu[i]);
            }
        }

        private void DrawSamplePoint(double u, double fu)
        {
            int panelX = _cc.RealX2CanvasX(u);
            int panelY = _cc.CanvasHeight - _cc.RealY2CanvasY(fu);
            _g.FillEllipse(_brush4SamplePoint, panelX - 3, panelY - 3, 6, 6);
            _g.DrawString($"({u,5:N3},{fu,5:N3})", panel1.Font, _brush4SamplePoint, panelX, panelY);
        }

        private void DrawCubicPolynomial()
        {
            if (_sampledCubic == null || _sampledCubic.Length < 4)
                return;

            double c0 = _sampledCubic[0];
            double c1 = _sampledCubic[1];
            double c2 = _sampledCubic[2];
            double c3 = _sampledCubic[3];
            double min = _sampledU[0];
            double max = _sampledU[0];
            for (int i = 1; i < _sampledU.Count; i++)
            {
                min = Math.Min(min, _sampledU[i]);
                max = Math.Max(max, _sampledU[i]);
            }
            if (min > 0)
                min = 0;
            if (max < 1)
                max = 1;
            double len = max - min;
            min -= len / 10;
            max += len / 10;
            len = max - min;
            // draw curve by points
            Pen pen4Curve = new Pen(Color.Green, 2);
            int pht = _cc.CanvasHeight;
            double u = min;
            int prevCanvasX = _cc.RealX2CanvasX(u);
            int prevCanvasY = _cc.RealY2CanvasY(c0 + c1 * u + c2 * u * u + c3 * u * u * u);
            for (int i = 1; i <= _panel1SegCount; i++)
            {
                u = min + len * i / _panel1SegCount;
                var x = _cc.RealX2CanvasX(u);
                var y = _cc.RealY2CanvasY(c0 + c1*u + c2*u*u + c3*u*u*u);
                _g.DrawLine(pen4Curve, prevCanvasX, pht - prevCanvasY, x, pht - y);
                prevCanvasX = x;
                prevCanvasY = y;
            }

        }

        private void DrawAll()
        {
            // clear old graph
            _g.Clear(Color.White);

            DrawCoordinateLines();
            DrawCurve();
            DrawSamplePoints();
            DrawCubicPolynomial();
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
                textBoxXScale.Text = $"{_cc.TargetRatioX * changeX,5:N2}".Replace(".00", "");
                needRedraw = true;
            }
            if (_scaleYFlag && _scaleYMouseDownValue != 0)
            {
                var newY = panel1.Height - Y;
                var oldY = panel1.Height - _scaleYMouseDownValue;
                changeY = (double)newY / oldY;
                textBoxYScale.Text = $"{_cc.TargetRatioY * changeY,5:N2}".Replace(".00", "");
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
    }
}
