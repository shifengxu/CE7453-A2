using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurveLib;

namespace CurveLibTest
{
    [TestClass]
    public class LeastSquaresTest
    {
        [TestMethod]
        public void ResolveNormalEqsByLUFactTest()
        {
            var lsq = new LeastSquaresByLU();
            double[,] A = new double[,] {
                { 2, 1, 5, },
                { 4, 4, -4, },
                { 1, 3, 1, },
            };
            double[] b = new double[] { 5, 0, 6 };

            //var outputFile = @"C:\D\Coding\CE7453-A2\outputFile.txt";
            string? outputFile = null;
            var x = lsq.ResolveNormalEqsByLUFact(A, b, outputFile);
            Assert.IsNotNull(x);
            Assert.AreEqual(3, x.Length);
            Assert.AreEqual(-1, x[0]);
            Assert.AreEqual(2, x[1]);
            Assert.AreEqual(1, x[2]);
        }

        [TestMethod]
        public void MinimizeLossTest()
        {
            string s = $"{33,+5:N3}";
            var lsq = new LeastSquaresByLU();
            double[,] A = new double[,] {
                { 1, 1 },
                { 1, -1 },
                { 1, 1 },
            };
            double[] b = new double[] { 2, 1, 3 };
            double loss;
            var x = lsq.MinimizeLoss(A, b, out loss);
            Assert.AreEqual(2, x.Length);
            Assert.AreEqual(1.75, x[0]);
            Assert.AreEqual(0.75, x[1]);
            Assert.AreEqual(0.5, loss);
        }
    } // class
}