using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricCurve
{
    public partial class Form1
    {
        public void ClearSamplePoints()
        {
            listBoxPoints.Items.Clear();
            _tempCP.Reset();
            textBoxCubicX.Text = String.Empty;
            textBoxSE.Text = String.Empty;
            textBoxSE2.Text = String.Empty;
        }
    }
}
