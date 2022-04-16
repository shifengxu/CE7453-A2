using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricCurve
{
    public partial class Form1
    {

        public void ClearAll()
        {
            _curvePoints.Clear();
            listBoxPoints.Clear();
            _bspline.TargetPoints.Clear();
            _bsplineSelectFlag = false;
        }

        private List<(double X, double Y)> CompositeGridPoints(int gridCnt)
        {
            var points = new List<(double X, double Y)>();
            var ey = (string)comboBoxY.SelectedItem;
            double fu = _cc.CalcValueByType(ey, 0);
            points.Add((0, fu));
            for (int i = 1; i <= gridCnt; i++)
            {
                double u = (double)i / gridCnt;
                fu = _cc.CalcValueByType(ey, u);
                points.Add((u, fu));
            }
            return points;
        }
    }
}
