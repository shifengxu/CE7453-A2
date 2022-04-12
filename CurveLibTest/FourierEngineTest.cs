using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurveLib;
using System.Collections.Generic;

namespace CurveLibTest
{
    [TestClass]
    public class FourierEngineTest
    {
        [TestMethod]
        public void CalcCoefficientsTest()
        {
            List<double> points = new List<double>() { 0, 1, 0, 1 };
            FourierEngine fe = new FourierEngine(points);
            fe.CalcCoefficients();
            double x0 = fe.CalcValue(0.0);
            double x1 = fe.CalcValue(0.25);
            double x2 = fe.CalcValue(0.5);
            double x3 = fe.CalcValue(0.75);
            Assert.AreEqual(0, x0);
            Assert.AreEqual(1, x1);
            Assert.AreEqual(0, x2);
            Assert.AreEqual(1, x3);

            Assert.AreEqual(1, fe.a[0]);
            Assert.AreEqual(0, fe.a[1]);
            Assert.AreEqual(-1, fe.a[2]);
            Assert.AreEqual(0, fe.b[1]);
        }
    }
}
