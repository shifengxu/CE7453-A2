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
        private void drawCoordinateLines(double? targetRatioX = null, double? targetRatioY = null)
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
        private void UpdateCanvasAndDrawCurve()
        {
            if (_curvePoints == null || _curvePoints.Count == 0)
                return;

            int pWidth = panel1.Width;
            int pHeight = panel1.Height;
            _cc.UpdateCanvasSizeAndRatio(pWidth, pHeight);

            DrawCurve();
        }

        private void DrawCurve()
        {
            if (_curvePoints == null || _curvePoints.Count == 0)
                return;

            // clear old graph
            _g.Clear(Color.White);

            drawCoordinateLines();

            // draw curve by points
            Pen pen4Curve = new Pen(Color.Red, 2);
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

            textBoxXScale.Text = $"{_cc.TargetRatioX,5:N2}".Replace(".00", "");
            textBoxYScale.Text = $"{_cc.TargetRatioY,5:N2}".Replace(".00", "");
        }

        private void UpdatePanel1Cursor()
        {
            if (_scaleXFlag == false && _scaleYFlag == false)
            {
                panel1.Cursor = Cursors.Cross;
            }
            else if (_scaleXFlag == true && _scaleYFlag == false)
            {
                panel1.Cursor = Cursors.SizeWE;
            }
            else if (_scaleXFlag == false && _scaleYFlag == true)
            {
                panel1.Cursor = Cursors.SizeNS;
            }
            else
            {
                panel1.Cursor = Cursors.SizeAll;
            }
        }

    }
}
