using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurveLib
{
    public class FourierEngine
    {
        private static LeastSquaresByLU lsq = new LeastSquaresByLU();

        private List<(double X, double Y)> Points;
        public List<double> a = new List<double>();
        public List<double> b = new List<double>();

        private int n;
        private int nHalf;
        private bool isEven;
        private double restn;

        public FourierEngine()
        {
            Points = new List<(double X, double Y)>();
        }

        public FourierEngine(List<(double X, double Y)> points)
        {
            this.Points = points;
        }

        public void SetPoints(IEnumerable<(double X, double Y)> points)
        {
            Points.Clear();
            Points.AddRange(points);
        }

        public void CopyFrom(FourierEngine fe)
        {
            n = fe.n;
            nHalf = fe.nHalf;
            restn = fe.restn;
            isEven = fe.isEven;
            a.Clear();
            a.AddRange(fe.a);
            b.Clear();
            b.AddRange(fe.b);
            Points.Clear();
            Points.AddRange(fe.Points);
        }

        public string GetStringOfA()
        {
            string res = $"a[0-{a.Count - 1}]: ";
            res += String.Join(", ", a.Select(x => x.ToString("N3")));
            return res;
        }

        public string GetStringOfB()
        {
            string res = $"b[1-{b.Count - 1}]: ";
            List<string> sList = new List<string>();
            for (int i = 1; i < b.Count; i++)
            {
                sList.Add(b[i].ToString("N3"));
            }
            res += String.Join(", ", sList);
            return res;
        }

        public string GetStringOfAB()
        {
            return $"{GetStringOfA()}; {GetStringOfB()}";
        }

        public void CalcCoefficients()
        {
            n = Points.Count;
            nHalf = n / 2;
            isEven = n % 2 == 0;
            restn = 1.0 / Math.Sqrt(n); // reciprocal of sqrt(n)
            int aCnt = n / 2 + 1;
            double[] thetaArr = new double[n];
            for (int i = 0; i < n; i++)
                thetaArr[i] = 2 * Math.PI * Points[i].X;

            // unknown coefficient order is, first a, then b. For example:
            //      a0, a1, a2, a3, a4, b1, b2, b3
            double[,] matrix = new double[n, n];
            int kMax = isEven ? nHalf - 1 : nHalf;
            for (int rIdx = 0; rIdx < n; rIdx++)
            {
                var theta = thetaArr[rIdx];
                matrix[rIdx, 0] = restn;    // a_0
                if (isEven)                 // a_n/2
                    matrix[rIdx, nHalf] = restn * Math.Cos(theta * nHalf);
                for (int k = 1; k <= kMax; k++)
                {
                    matrix[rIdx, k] = 2 * restn * Math.Cos(theta * k);          // a_k
                    matrix[rIdx, nHalf + k] = -2 * restn * Math.Sin(theta * k); // b_k
                }
            }
            //string fpath = @"C:\D\Coding\CE7453-A2\sample-input-output\Fourier-Matrix.txt";
            var bArr = Points.Select(p => p.Y).ToArray();
            double[] ab = lsq.ResolveNormalEqsByLUFact(matrix, bArr);
            a.Clear();
            b.Clear();
            int idx = 0;
            for (; idx < aCnt; idx++)
                a.Add(ab[idx]);
            b.Add(0); // ignore b_0
            for (; idx < ab.Length; idx++)
                b.Add(ab[idx]);
        }//CalcCoefficients()

        public double CalcValue(double t) // t should be in [0, 1]
        {
            double sum = 0;
            sum += a[0];
            double theta = 2 * Math.PI * t;
            if (isEven)
                sum += a[nHalf] * Math.Cos(theta * nHalf);
            int kMax = isEven ? nHalf - 1 : nHalf;
            for (int k = 1; k <= kMax; k++)
            {
                sum += 2 * a[k] * Math.Cos(theta * k);
                sum -= 2 * b[k] * Math.Sin(theta * k);
            }
            sum *= restn;
            return sum;
        }
    }
}
