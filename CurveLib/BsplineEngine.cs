using System.Text.RegularExpressions;

namespace CurveLib
{
    public class BsplineEngine
    {
        public List<(double X, double Y)> TargetPoints = new List<(double, double)>();
        public List<double> KnotValues = new List<double>();
        public List<(double X, double Y)> ControlPoints = new List<(double, double)>();

        public readonly int degree = 3;

        public List<(double X, double Y)> LoadTargetPointsFromFile(string filepath)
        {
            this.TargetPoints.Clear();
            this.ControlPoints.Clear();
            this.KnotValues.Clear();
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                string l = line.Trim();
                if (string.IsNullOrWhiteSpace(l) || l.StartsWith('#'))
                    continue;
                string[] arr = Regex.Split(l, @"\s+");
                double x = Double.Parse(arr[0]);
                double y = Double.Parse(arr[1]);
                TargetPoints.Add((x, y));

            }
            return TargetPoints;
        }

        public void Run()
        {
            CalcKnotValues();
            CalcControlPoints();
        }

        public void Run(List<(double X, double Y)> pList)
        {
            TargetPoints.Clear();
            TargetPoints.AddRange(pList);
            Run();
        }

        public (double X, double Y) GetXYByUValue(double u_value)
        {
            double n1, n2, n3, n4, x, y;
            var P = ControlPoints;
            int u_idx = this.GetUIndexByValue(u_value);
            n1 = this.CalcNiByUValueIdx(u_idx - 3, u_value, u_idx);
            n2 = this.CalcNiByUValueIdx(u_idx - 2, u_value, u_idx);
            n3 = this.CalcNiByUValueIdx(u_idx - 1, u_value, u_idx);
            n4 = this.CalcNiByUValueIdx(u_idx, u_value, u_idx);
            x = n1 * P[u_idx - 3].X;
            x += n2 * P[u_idx - 2].X;
            x += n3 * P[u_idx - 1].X;
            x += n4 * P[u_idx].X;
            y = n1 * P[u_idx - 3].Y;
            y += n2 * P[u_idx - 2].Y;
            y += n3 * P[u_idx - 1].Y;
            y += n4 * P[u_idx].Y;
            return (x, y);
        }

        protected List<double> CalcKnotValues()
        {
            this.KnotValues.Clear();
            for (int i = 0; i <= degree; i++)    // the first degree points, and t0
            {
                this.KnotValues.Add(0.0);
            }
            // So far, t0 = 0 is already added.
            // Now, calcuate t1, t2, , , , t(n-1)
            var tps = this.TargetPoints;
            double[] distArr = new double[tps.Count]; // distance array
            distArr[0] = 0;
            for (int i = 1; i < tps.Count; i++)
            {
                var p0 = tps[i - 1];
                var p1 = tps[i];
                var dist = Math.Sqrt(Math.Pow(p0.X - p1.X, 2) + Math.Pow(p0.Y - p1.Y, 2));
                distArr[i] = distArr[i - 1] + dist;
            }

            var totalDist = distArr[distArr.Length - 1];
            for (int i = 1; i < tps.Count - 1; i++)
            {
                this.KnotValues.Add(distArr[i] / totalDist);
            }

            for (int i = 0; i <= degree; i++)    // tn, and the last degree points
            {
                this.KnotValues.Add(1.0);
            }
            return this.KnotValues;
        }

        protected List<(double X, double Y)> CalcControlPoints(string outputFilepath = "")
        {
            /* If degree is 3, target points count is 5: D0, D1, D2, D3, D4.
             * Then the parameters will be t0, t1, t2, t3, t4; 
             * And knot will be: t0 t0 t0 t0 t1 t2 t3 t4 t4 t4 t4.
             * So knot count will be 5 + 3 + 3 = 11
             * So control point count will be 11 - 1 - 3 = 7
             */
            int cpCount = KnotValues.Count - 1 - degree; // control point count
            double[,] matrix = new double[cpCount, cpCount];
            (double X, double Y)[] b = new (double X, double Y)[cpCount];
            /* matrix operation: M x P = B
             * M: matrix
             * P: ctrPoints
             * B: b
             */
            (double X, double Y) tp;
            int n = TargetPoints.Count - 1; // also cpCount - 3
            // ------------------------------------------------------ row 0
            matrix[0, 0] = 1;
            tp = TargetPoints[0];
            b[0] = (tp.X, tp.Y);
            // ------------------------------------------------------ row n+2
            matrix[n + 2, n + 2] = 1;
            tp = TargetPoints[n];
            b[n + 2] = (tp.X, tp.Y);
            // ------------------------------------------------------ row 1
            matrix[1, 0] = CalcNiDerivative2(0, 3);
            matrix[1, 1] = CalcNiDerivative2(1, 3);
            matrix[1, 2] = CalcNiDerivative2(2, 3);
            b[1] = (0, 0);
            // ------------------------------------------------------ row n+1
            matrix[n + 1, n] = CalcNiDerivative2(n, n + 3);
            matrix[n + 1, n + 1] = CalcNiDerivative2(n + 1, n + 3);
            matrix[n + 1, n + 2] = CalcNiDerivative2(n + 2, n + 3);
            b[n + 1] = (0, 0);
            // ------------------------------------------------------ row 2 ~ n
            for (int rIdx = 2; rIdx <= n; rIdx++)
            {
                for (int cIdx = rIdx - 1; cIdx <= rIdx + 1; cIdx++)
                {
                    int n_idx = rIdx - 1;
                    matrix[rIdx, cIdx] = CalcNiByUIdx(cIdx, n_idx + 3);
                }
                tp = TargetPoints[rIdx - 1];
                b[rIdx] = (tp.X, tp.Y);
            }

            var ctrPoints = new (double, double)[cpCount];
            ResolveEquation(matrix, ctrPoints, b, outputFilepath);
            this.ControlPoints.Clear();
            this.ControlPoints.AddRange(ctrPoints);
            return this.ControlPoints;
        }

        protected void ResolveEquation(double[,] matrix, (double X, double Y)[] ctrPoints,
            (double X, double Y)[] b, string outputFilepath = "")
        {
            if (outputFilepath != null && outputFilepath != string.Empty)
                PrintEquation(matrix, b, outputFilepath, false);

            double k = matrix[0, 0];
            if (k != 1)
            {
                matrix[0, 0] = 1;
                matrix[0, 1] /= k;
                b[0].X /= k;
                b[0].Y /= k;
            }

            int len = matrix.GetLength(0);
            for (int r = 1; r < len; r++)
            {
                if (matrix[r, r - 1] != 0)
                {
                    k = matrix[r, r - 1];
                    matrix[r, r - 1] = 0;
                    matrix[r, r] -= k * matrix[r - 1, r];
                    if (r + 1 < len) matrix[r, r + 1] -= k * matrix[r - 1, r + 1];
                    b[r].X -= k * b[r - 1].X;
                    b[r].Y -= k * b[r - 1].Y;
                }
                if (matrix[r, r] != 1)
                {
                    double q = matrix[r, r];
                    if (q == 0)
                    {
                        if (outputFilepath != null && outputFilepath != string.Empty)
                            PrintEquation(matrix, b, outputFilepath, true);
                        string msg = $"Matrix[{r},{r}] is 0 when resolving equations. ";
                        msg += "Possible reason is target points have overlapping.";
                        throw new DivideByZeroException(msg);
                    }
                    matrix[r, r] = 1;
                    if (r + 1 < len) matrix[r, r + 1] /= q;
                    b[r].X /= q;
                    b[r].Y /= q;
                }
            }
            if (outputFilepath != null && outputFilepath != string.Empty)
                PrintEquation(matrix, b, outputFilepath, true);

            for (int i = len - 1; i > 0; i--)
            {
                ctrPoints[i] = (b[i].X, b[i].Y);
                k = matrix[i - 1, i];
                matrix[i - 1, i] = 0;
                b[i - 1].X -= k * b[i].X;
                b[i - 1].Y -= k * b[i].Y;
            }
            ctrPoints[0] = (b[0].X, b[0].Y);

            if (outputFilepath != null && outputFilepath != string.Empty)
                PrintEquation(matrix, b, outputFilepath, true);
        }

        private void PrintEquation(double[,] matrix, (double, double)[] b, string fpath, bool append)
        {
            using (StreamWriter sw = new StreamWriter(fpath, append))
            {
                if (append)
                {
                    sw.WriteLine();
                    sw.WriteLine("------------------------------------");
                    sw.WriteLine();
                }
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        string str = $"{matrix[i, j],7:N2}".Replace(".00", "   ");
                        sw.Write($"{str} ");
                    }
                    sw.WriteLine(b[i].ToString());
                }
            }
        }

        protected int GetUIndexByValue(double u_value)
        {
            /* Assume t0 ~ tn corresponds to target points D0 ~ Dn.
             * So knot vector is: t0, t0, t0, t0, t1, , tn, tn, tn, tn
             * for knot vector u: t0 is u3, and tn is u(n+3)
             * The domain range of u_value is: [t0, tn], namely:
             *      [u3, u(n+3)]
             * degree is 3.
             * So for u_idx, 
             *      start index is degree, 
             *      end index is u_len - 1 - degree.
             * 
             */
            var u = KnotValues;
            int u_len = this.KnotValues.Count;
            int endIdx = u_len - 1 - degree;
            for (int idx = degree; idx < endIdx; idx++)
            {
                if (u_value >= u[idx] && u_value < u[idx + 1])
                    return idx;
            }
            /* special case for u_value is tn.
             */
            if (u_value == u[endIdx])
                return endIdx;

            throw new ArgumentException($"Not found u_idx for input: u_value:{u_value}");
        }

        /**
         * Calculate Ni by u value
         */
        protected double CalcNiByUValue(int i_idx, double u_value)
        {
            var u_idx = GetUIndexByValue(u_value);
            return CalcNiByUValueIdx(i_idx, u_value, u_idx);
        }

        /**
         * Calculate Ni by u value and index. The value and index must match.
         */
        protected double CalcNiByUValueIdx(int i_idx, double u_value, int u_idx)
        {
            var u = KnotValues;
            int endIdx = u.Count - 1 - degree;
            if (u_idx == endIdx)
            {
                // handle special case when u_value is tn (usually is 1).
                return i_idx + 1 == u_idx ? 1 : 0;
            }
            int i = i_idx;
            double numerator, denominator;
            if (u_idx == i) // -------------------------------------- case 1 [Ui, Ui+1)
            {
                numerator = Math.Pow(u_value - u[i], 3);
                if (numerator == 0) return 0;
                denominator = (u[i + 1] - u[i]) * (u[i + 2] - u[i]) * (u[i + 3] - u[i]);
                if (denominator == 0) return 0;
                return numerator / denominator;
            }
            else if (u_idx == i + 1) // ----------------------------- case 2 [Ui+1, Ui+2)
            {
                double res = 0.0;
                numerator = (u_value - u[i]) * (u_value - u[i]) * (u[i + 2] - u_value);
                if (numerator != 0)
                {
                    denominator = (u[i + 2] - u[i + 1]) * (u[i + 3] - u[i]) * (u[i + 2] - u[i]);
                    if (denominator != 0) res += numerator / denominator;
                }
                numerator = (u[i + 3] - u_value) * (u_value - u[i]) * (u_value - u[i + 1]);
                if (numerator != 0)
                {
                    denominator = (u[i + 2] - u[i + 1]) * (u[i + 3] - u[i + 1]) * (u[i + 3] - u[i]);
                    if (denominator != 0) res += numerator / denominator;
                }
                numerator = (u[i + 4] - u_value) * (u_value - u[i + 1]) * (u_value - u[i + 1]);
                if (numerator != 0)
                {
                    denominator = (u[i + 2] - u[i + 1]) * (u[i + 4] - u[i + 1]) * (u[i + 3] - u[i + 1]);
                    if (denominator != 0) res += numerator / denominator;
                }
                return res;
            }
            else if (u_idx == i + 2) // ----------------------------- case 3 [Ui+2, Ui+3)
            {
                double res = 0.0;
                numerator = (u_value - u[i]) * (u[i + 3] - u_value) * (u[i + 3] - u_value);
                if (numerator != 0)
                {
                    denominator = (u[i + 3] - u[i + 2]) * (u[i + 3] - u[i + 1]) * (u[i + 3] - u[i]);
                    if (denominator != 0) res += numerator / denominator;
                }
                numerator = (u[i + 4] - u_value) * (u[i + 3] - u_value) * (u_value - u[i + 1]);
                if (numerator != 0)
                {
                    denominator = (u[i + 3] - u[i + 2]) * (u[i + 4] - u[i + 1]) * (u[i + 3] - u[i + 1]);
                    if (denominator != 0) res += numerator / denominator;
                }
                numerator = (u[i + 4] - u_value) * (u[i + 4] - u_value) * (u_value - u[i + 2]);
                if (numerator != 0)
                {
                    denominator = (u[i + 3] - u[i + 2]) * (u[i + 4] - u[i + 2]) * (u[i + 4] - u[i + 1]);
                    if (denominator != 0) res += numerator / denominator;
                }
                return res;
            }
            else if (u_idx == i + 3) // ----------------------------- case 4 [Ui+3, Ui+4)
            {
                numerator = Math.Pow(u[i + 4] - u_value, 3);
                if (numerator == 0) return 0;
                denominator = (u[i + 4] - u[i + 3]) * (u[i + 4] - u[i + 2]) * (u[i + 4] - u[i + 1]);
                if (denominator == 0) return 0;
                return numerator / denominator;
            }
            else
            {
                return 0;
            }
        }

        /**
         * Calculate Ni by u index
         */
        protected double CalcNiByUIdx(int i_idx, int u_idx)
        {
            var u = KnotValues;
            int i = i_idx;
            if (u_idx == i)
            {
                return 0;
            }
            else if (u_idx == i + 1)
            {
                double numerator = Math.Pow(u[i + 1] - u[i], 2);
                if (numerator == 0) return 0;
                double denominator = (u[i + 3] - u[i]) * (u[i + 2] - u[i]);
                if (denominator == 0) return 0;
                return numerator / denominator;
            }
            else if (u_idx == i + 2)
            {
                double numerator = (u[i + 2] - u[i]) * (u[i + 3] - u[i + 2]);
                double res = 0;
                if (numerator != 0)
                {
                    double denominator = (u[i + 3] - u[i + 1]) * (u[i + 3] - u[i]);
                    if (denominator != 0) res += numerator / denominator;
                }
                numerator = (u[i + 4] - u[i + 2]) * (u[i + 2] - u[i + 1]);
                if (numerator != 0)
                {
                    double denominator = (u[i + 4] - u[i + 1]) * (u[i + 3] - u[i + 1]);
                    if (denominator != 0) res += numerator / denominator;
                }
                return res;
            }
            else if (u_idx == i + 3)
            {
                double numerator = Math.Pow(u[i + 4] - u[i + 3], 2);
                if (numerator == 0) return 0;
                double denominator = (u[i + 4] - u[i + 2]) * (u[i + 4] - u[i + 1]);
                if (denominator == 0) return 0;
                return numerator / denominator;
            }
            else
            {
                throw new ArgumentException($"Unsupported argument. i_idx:{i_idx}, u_idx:{u_idx}");
            }
        }

        private double CalcNiDerivative2(int i_idx, int u_idx)
        {
            var u = KnotValues;
            int n = TargetPoints.Count - 1;
            double res;
            if (i_idx == 0 && u_idx == 3)
            {
                double numerator = 6;
                double denominator = Math.Pow(u[4] - u[3], 2);
                res = numerator / denominator;
            }
            else if (i_idx == 1 && u_idx == 3)
            {
                res = -4.0 / Math.Pow(u[4] - u[3], 2);
                res += (4 * u[3] - 2 * u[5] - 2 * u[4]) / (Math.Pow(u[4] - u[3], 2) * (u[5] - u[3]));
                res += -4.0 / ((u[4] - u[3]) * (u[5] - u[3]));
            }
            else if (i_idx == 2 && u_idx == 3)
            {
                res = 6.0 / ((u[4] - u[3]) * (u[5] - u[3]));
            }
            else if (i_idx == n && u_idx == n + 3)
            {
                res = 6.0 / ((u[n + 3] - u[n + 2]) * (u[n + 3] - u[n + 1]));
            }
            else if (i_idx == n + 1 && u_idx == n + 3)
            {
                res = -4.0 / ((u[n + 3] - u[n + 2]) * (u[n + 4] - u[n + 1]));
                res += (-4 * u[n + 3] + 2 * u[n + 2] + 2 * u[n + 1]) / (Math.Pow(u[n + 3] - u[n + 2], 2) * (u[n + 3] - u[n + 1]));
                res += -4 / Math.Pow(u[n + 3] - u[n + 2], 2);
            }
            else if (i_idx == n + 2 && u_idx == n + 3)
            {
                res = 6.0 / Math.Pow(u[n + 3] - u[n + 2], 2);
            }
            else
            {
                throw new ArgumentException($"Unsupported argument. i_idx:{i_idx}; u_idx: {u_idx}");
            }
            return res;
        }

    }

}
