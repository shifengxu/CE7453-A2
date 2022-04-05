using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurveLib;

namespace CurveLibTest
{
    [TestClass]
    public class BsplineEngineTest : BsplineEngine
    {
        [TestMethod]
        public void resolveEquationTest()
        {
            double[,] matrix = new double[,] {
                {2, 3, 0},
                {4, 5, 6},
                {0, 7, 8},
            };
            var b = new (double X, double Y)[] { (13, 8), (47, 20), (53, 22), };
            int cpCount = matrix.GetLength(0);
            (double X, double Y)[] ctrPoints = new (double X, double Y)[cpCount];
            ResolveEquation(matrix, ctrPoints, b);
            Assert.AreEqual(2, ctrPoints[0].X);
            Assert.AreEqual(3, ctrPoints[1].X);
            Assert.AreEqual(4, ctrPoints[2].X);
            Assert.AreEqual(1, ctrPoints[0].Y);
            Assert.AreEqual(2, ctrPoints[1].Y);
            Assert.AreEqual(1, ctrPoints[2].Y);
        }

        [TestMethod]
        public void calcNiByUIdxTest()
        {
            double[,] targetPointArr = new double[,] {
                {0, 0},
                {0, 2},
                {2, 2},
                {2, 0},
                {4, 0},
            };
            for (int i = 0; i < targetPointArr.GetLength(0); i++)
            {
                var p = (targetPointArr[i, 0], targetPointArr[i, 1]);
                TargetPoints.Add(p);
            }
            CalcKnotValues();

            var u = KnotValues;
            int u_idx = degree;
            double v1 = CalcNiByUIdx(0, u_idx);
            double v2 = CalcNiByUValue(0, u[u_idx]);
            Assert.AreEqual(1, v1, $"u_idx:{u_idx}");
            Assert.AreEqual(1, v2, $"u_idx:{u_idx}");

            v1 = CalcNiByUIdx(1, u_idx);
            v2 = CalcNiByUValue(1, u[u_idx]);
            Assert.AreEqual(0, v1, $"u_idx:{u_idx}");
            Assert.AreEqual(0, v2, $"u_idx:{u_idx}");

            v1 = CalcNiByUIdx(2, u_idx);
            v2 = CalcNiByUValue(2, u[u_idx]);
            Assert.AreEqual(0, v1, $"u_idx:{u_idx}");
            Assert.AreEqual(0, v2, $"u_idx:{u_idx}");

            int n = targetPointArr.GetLength(0) - 1;
            u_idx = n + degree;
            v1 = CalcNiByUIdx(n, u_idx);
            v2 = CalcNiByUValue(n, u[u_idx]);
            Assert.AreEqual(0, v1, $"i:{n}, u_idx:{u_idx}");
            Assert.AreEqual(0, v2, $"i:{n}, u_idx:{u_idx}");

            v1 = CalcNiByUIdx(n + 1, u_idx);
            v2 = CalcNiByUValue(n + 1, u[u_idx]);
            Assert.AreEqual(0, v1, $"i:{n + 1}, u_idx:{u_idx}");
            Assert.AreEqual(0, v2, $"i:{n + 1}, u_idx:{u_idx}");

            v1 = CalcNiByUIdx(n + 2, u_idx);
            v2 = CalcNiByUValue(n + 2, u[u_idx]);
            Assert.AreEqual(1, v1, $"i:{n + 2}, u_idx:{u_idx}");
            Assert.AreEqual(1, v2, $"i:{n + 2}, u_idx:{u_idx}");
        }

    }
}
