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
    }
}
