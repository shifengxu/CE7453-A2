using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CurveLib
{
    public class LeastSquaresByLU
    {
        /**
         * param uList: u value list, sample [0.2, 0.4, 0.6, 0.8]
         * param fList: f(u) value list, sample [0.23, 0.57, -0.33, 0.18]
         * Return [c0, c1, c2, c3]
         * f(u) = c0 + c1*u + c2*u^2 + c3*u^3
         */
        public double[] GetCubicPolynomial(List<double> uList, List<double> fList, out double rmse)
        {
            // get normal equations
            var uCount = uList.Count;
            double[,] A = new double[uCount, 4];
            double[] b = new double[uCount];
            for (int i = 0; i < uCount; i++)
            {
                var u = uList[i];
                A[i, 0] = 1;
                A[i, 1] = u;
                A[i, 2] = u * u;
                A[i, 3] = u * u * u;
                b[i] = fList[i];
            }

            return MinimizeLoss(A, b, out rmse);
        }

        public double[] MinimizeLoss(double[,] A, double[] b, out double rmse)
        {
            double[,] A_T = Transpose(A);
            double[,] A_T_A = Multiple(A_T, A);
            double[] A_T_b = Multiple(A_T, b);

            // resolve normal equations
            double[] x = ResolveNormalEqsByLUFact(A_T_A, A_T_b);
            double[] b2 = Multiple(A, x);
            double l = 0;
            for (int i = 0; i < b2.Length; i++)
            {
                l += Math.Pow(b2[i] - b[i], 2);
            }
            rmse = Math.Sqrt(l / b2.Length);
            return x;
        }

        /**
         * Resolve Normal equations by LU factorizations.
         * input is matrix A, and result vector b.
         * PA = LU
         */
        public double[] ResolveNormalEqsByLUFact(double[,] normalEquations, double[] b, string? outputFile = null)
        {
            int dim1 = normalEquations.GetLength(0);
            int dim2 = normalEquations.GetLength(1);
            if (dim1 != dim2)
            {
                throw new ArgumentException($"normalEquations dimension mismatch: {dim1}, {dim2}");
            }
            int dimb = b.GetLength(0);
            if (dim1 != dimb)
            {
                throw new ArgumentException($"normalEquations and b dimension mismatch: {dim1}, {dimb}");
            }

            int[,] P = new int[dim1, dim1]; // P for permutation
            for (int i = 0; i < dim1; i++)
                P[i, i] = 1;

            double[,] PA = new double[dim1, dim1];  // PA, also LU
            for (int i = 0; i < dim1; i++)
                for (int j = 0; j < dim1; j++)
                    PA[i, j] = normalEquations[i, j];

            double[,] U = new double[dim1, dim1]; // Upper part
            for (int i = 0; i < dim1; i++)
                for (int j = 0; j < dim2; j++)
                    U[i, j] = normalEquations[i, j];
            
            double[,] L = new double[dim1, dim1]; // Lower part
            for (int i = 0; i < dim1; i++)
                L[i, i] = 1;

            // start to find L and U, given PA=LU.
            for (int rIdx = 0; rIdx < dim1 - 1; rIdx++)
            {
                var maxRowIdx = FindMaxMagnitudeRowByColumn(PA, rIdx);
                if (maxRowIdx != rIdx)
                {
                    SwitchRows(PA, maxRowIdx, rIdx);
                    SwitchRows(P, maxRowIdx, rIdx);
                    SwitchRows(U, maxRowIdx, rIdx);
                    SwitchRowsLeftHalf(L, maxRowIdx, rIdx);
                }
                for (int r2 = rIdx + 1; r2 < dim1; r2++)
                {
                    if (U[r2, rIdx] == 0)
                        continue;
                    double k = U[r2, rIdx] / U[rIdx, rIdx];
                    U[r2, rIdx] = 0;
                    for (int cIdx = rIdx + 1; cIdx < dim1; cIdx++)
                    {
                        U[r2, cIdx] -= k * U[rIdx, cIdx];
                    }
                    L[r2, rIdx] = k;
                }
            } // for
            if (outputFile != null)
            {
                using (StreamWriter sw = new StreamWriter(outputFile))
                {
                    OutputMatrix(P, sw, "P");
                    OutputMatrix(normalEquations, sw, "A");
                    OutputMatrix(PA, sw, "PA");
                    OutputMatrix(L, sw, "L");
                    OutputMatrix(U, sw, "U");
                }
            }

            // Ax = b; PAx=Pb; LUx=Pb
            //   (1): solve Lc = Pb for c
            //   (2): solve Ux = c for x
            double[] Pb = Multiple(P, b);
            double[] c = ResolveByLower(L, Pb);
            if (outputFile != null)
            {
                using (StreamWriter sw = new StreamWriter(outputFile, true))
                {
                    OutputVector(c, sw, "c");
                }
            }

            double[] x = ResolveByUpper(U, c);
            if (outputFile != null)
            {
                using (StreamWriter sw = new StreamWriter(outputFile, true))
                {
                    OutputVector(x, sw, "x");
                }
            }

            return x;
        }

        private T[,] Transpose<T>(T[,] m)
        {
            int dim0 = m.GetLength(0);
            int dim1 = m.GetLength(1);
            T[,] res = new T[dim1, dim0];
            for (int i = 0; i < dim0; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    res[j, i] = m[i, j];
                }
            }
            return res;
        }

        private double[] ResolveByUpper(double[,] upper, double[] c)
        {
            int dim = upper.GetLength(0);
            double[] res = new double[dim];
            for (int i = dim - 1; i >= 0; i--)
            {
                var k = upper[i, i];
                upper[i, i] = 1;
                c[i] /= k;
                res[i] = c[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    k = upper[j, i];
                    upper[j, i] = 0;
                    c[j] -= k * c[i];
                }
            }
            return res;
        }

        private double[] ResolveByLower(double[,] lower, double[] pb)
        {
            int dim = lower.GetLength(0);
            double[] res = new double[dim];
            for (int i = 0; i < dim; i++)
            {
                res[i] = pb[i];
                for (int j = i + 1; j < dim; j++)
                {
                    var k = lower[j, i];
                    lower[j, i] = 0;
                    pb[j] -= k * pb[i];
                }
            }
            return res;
        }

        private double[,] Multiple(double[,] m1, double[,] m2)
        {
            int dim0 = m1.GetLength(0);
            int dim1 = m1.GetLength(1);
            int dim2 = m2.GetLength(1);
            double[,] res = new double[dim0, dim2];
            for (int r = 0; r < dim0; r++)
            {
                for (int c = 0; c < dim2; c++)
                {
                    double s = 0;
                    for (int j = 0; j < dim1; j++)
                    {
                        s += m1[r, j] * m2[j, c];
                    }
                    res[r, c] = s;
                }
            }
            return res;
        }

        private double[] Multiple(double[,] m, double[] b)
        {
            int dim0 = m.GetLength(0);
            int dim1 = m.GetLength(1);
            double[] res = new double[dim0];
            for (int i = 0; i < dim0; i++)
            {
                double s = 0;
                for (int j = 0; j < dim1; j++)
                {
                    s += m[i, j] * b[j];
                }
                res[i] = s;
            }
            return res;
        }

        private double[] Multiple(int[,] m, double[] b)
        {
            int dim0 = m.GetLength(0);
            int dim1 = m.GetLength(1);
            double[] res = new double[dim0];
            for (int i = 0; i < dim0; i++)
            {
                double s = 0;
                for (int j = 0; j < dim1; j++)
                {
                    s += m[i, j] * b[j];
                }
                res[i] = s;
            }
            return res;
        }

        private void OutputMatrix<T>(T[,] a, StreamWriter sw, string? info = null)
        {
            if (info != null)
                sw.WriteLine($"----- {info} -----");
            int dim0 = a.GetLength(0);
            int dim1 = a.GetLength(1);
            for (int i = 0; i < dim0; i++)
            {
                for (int j = 0; j < dim1; j++)
                {
                    var str = $"{a[i, j],6:N3}";
                    str = Regex.Replace(str, @".000$", "    ");
                    str = Regex.Replace(str, @"00$", "  ");
                    str = Regex.Replace(str, @"0$", " ");
                    sw.Write($"{str}  ");
                }
                sw.WriteLine();
            }
            sw.WriteLine();
        }

        private void OutputVector<T>(T[] a, StreamWriter sw, string? info = null)
        {
            if (info != null)
                sw.WriteLine($"----- {info} -----");
            int dim0 = a.GetLength(0);
            for (int i = 0; i < dim0; i++)
            {
                var str = $"{a[i],6:N3}";
                str = Regex.Replace(str, @".000$", "    ");
                str = Regex.Replace(str, @"00$", "  ");
                str = Regex.Replace(str, @"0$", " ");
                sw.Write($"{str}  ");
                sw.WriteLine();
            }
            sw.WriteLine();
        }

        private void SwitchRows<T>(T[,] a, int r1, int r2)
        {
            int dim = a.GetLength(0);
            for (int i = 0; i < dim; i++)
            {
                var temp = a[r1, i];
                a[r1, i] = a[r2, i];
                a[r2, i] = temp;
            }
        }

        private void SwitchRowsLeftHalf<T>(T[,] a, int r1, int r2)
        {
            int min = Math.Min(r1, r2);
            for (int i = 0; i < min; i++)
            {
                var temp = a[r1, i];
                a[r1, i] = a[r2, i];
                a[r2, i] = temp;
            }
        }

        private int FindMaxMagnitudeRowByColumn(double[,] a, int cIdx)
        {
            int dim = a.GetLength(0);
            int rIdx = cIdx;
            double max = Math.Abs(a[rIdx, cIdx]);
            for (int i = rIdx + 1; i < dim; i++)
            {
                var tmp = Math.Abs(a[i, cIdx]);
                if (max < tmp)
                {
                    max = tmp;
                    rIdx = i;
                }
            }
            return rIdx;
        }
    } // class
}
