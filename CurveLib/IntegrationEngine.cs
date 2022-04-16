using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurveLib
{
    public class IntegrationEngine
    {
        public delegate double CalcValue(double x);

        public IntegrationEngine()
        {

        }

        public double ByCompositeTrapezoid(List<(double X, double Y)> points)
        {
            int pCnt = points.Count;
            int m = pCnt - 1;
            double xRange = points[m].X - points[0].X;
            double h = xRange / m;
            double midSum = 0;
            for (int i = 1; i < m - 1; i++)
            {
                midSum += points[i].Y;
            }
            double fa = points[0].Y;
            double fb = points[m].Y;
            double result = h * (fa + fb + 2 * midSum) / 2;

            return result;
        }

        public double ByCompositeSimpson(List<(double X, double Y)> points)
        {
            int pCnt = points.Count;
            int m = (pCnt - 1) / 2;
            // it should be odd-number points, such as 9.
            // So m will be 4. And the points will be:
            // x_0, x_1, , , x_2m
            double xRange = points[pCnt - 1].X - points[0].X;
            double h = xRange / (2 * m);
            double innerOddSum = 0;
            double innerEvenSum = 0;
            for (int i = 1; i <= m; i++)
                innerOddSum += points[2 * i - 1].Y;
            for (int i = 1; i <= m - 1; i++)
                innerEvenSum += points[2 * i].Y;

            double fa = points[0].Y;
            double fb = points[pCnt - 1].Y;
            double res = h * (fa + fb + 4 * innerOddSum + 2 * innerEvenSum) / 3;

            return res;
        }

        public double ByGaussianQuadrature(GaussianQuadratureCoef gqCoef, CalcValue calcFn,
            out List<(double x, double y, double weight)> weightList,
            double minX = 0, double maxX = 1)
        {
            weightList = new List<(double x, double y, double weight)>();
            double xDifHalf = (maxX - minX) / 2; // this is (b - a)/2 in the formula
            double xSumHalf = (maxX + minX) / 2; // this is (b + a)/2
            double result = 0;
            // please note, weight sum is 2. so when mapping to [minX, maxX],
            // the weight will be: weight / 2 * (maxX - minX)
            // and it is just the: weight * xDifHalf.
            // So, in the weightList, the weight sum is just the X range: maxX - minX
            foreach (var (u, weight) in gqCoef.CoList)
            {
                double x = u * xDifHalf + xSumHalf;
                double y = calcFn(x);
                var yVal = xDifHalf * y;
                weightList.Add((x, y, weight * xDifHalf));
                result += weight * yVal;
            }
            return result;
        }

        /**
         * Force integration. Just integration each point one by one.
         */
        public static double ForceIntegration(List<(double X, double Y)> points)
        {
            double res = 0;
            for (int i = 1; i < points.Count; i++)
            {
                res += (points[i].X - points[i - 1].X) * points[i].Y;
            }
            return res;
        }

        public static double LagrangeValueOrder2(double t,
            (double X, double Y) P0,
            (double X, double Y) P1,
            (double X, double Y) P2)
        {
            double t0 = P0.X, t1 = P1.X, t2 = P2.X;
            double res = 0;
            res += (t - t1) * (t - t2) / ((t0 - t1) * (t0 - t2)) * P0.Y;
            res += (t - t0) * (t - t2) / ((t1 - t0) * (t1 - t2)) * P1.Y;
            res += (t - t0) * (t - t1) / ((t2 - t0) * (t2 - t1)) * P2.Y;
            return res;
        }
    }
}
