using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurveLib
{
    public class CubicPolynomial
    {
        public readonly string TargetExpression; // x(u) or y(u)

        public List<(double, double)> SamplePoints = new List<(double, double)>();

        public List<double> Coefficients = new List<double>();

        public double RMSE1 = 0; // Root Mean Squared Error of sample points
        public double RMSE2 = 0; // RMSE of all points. Usually 1001 points

        public CubicPolynomial(string targetExpression)
        {
            TargetExpression = targetExpression;
        }

        public void Reset()
        {
            SamplePoints.Clear();
            Coefficients.Clear();
            RMSE1 = 0;
            RMSE2 = 0;
        }

        /** Calculate RMSE by point list
         */
        public double CalcRmse(List<CurveCanvasPoint>? pList)
        {
            if (pList == null || pList.Count == 0)
                return 0;

            double se = 0; // squared error
            var c = Coefficients;
            int pCnt = pList.Count;
            for (int i = 0; i < pCnt; i++)
            {
                var u = pList[i].X;
                var fu = pList[i].Y;
                var yu = c[0] + c[1] * u + c[2] * u * u + c[3] * u * u * u;
                se += (fu - yu) * (fu - yu);
            }
            var res = Math.Sqrt(se / pCnt);
            return res;
        }

        public void CopyFrom(CubicPolynomial cp)
        {
            SamplePoints.Clear();
            foreach (var kvp in cp.SamplePoints)
            {
                SamplePoints.Add((kvp.Item1, kvp.Item2));
            }

            Coefficients.Clear();
            foreach (var x in cp.Coefficients)
            {
                Coefficients.Add(x);
            }

            RMSE1 = cp.RMSE1;
            RMSE2 = cp.RMSE2;
        }

        public bool Load(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            bool found_coef = false; // found coefficients
            SamplePoints.Clear();
            Coefficients.Clear();
            foreach (string _line in lines)
            {
                string line = _line.Trim();
                if (line.Length == 0 || line.StartsWith("#"))
                    continue;
                if (line.StartsWith($"{TargetExpression}.Coefficients:"))
                {
                    string str = line.Split(":")[1].Trim();
                    if (str != String.Empty)
                    {
                        found_coef = true;
                        string[] strArr = str.Split();
                        Coefficients = Array.ConvertAll(strArr, Double.Parse).ToList();
                    }
                }
                else if (line.StartsWith($"{TargetExpression}.RMSE1:"))
                {
                    RMSE1 = double.Parse(line.Split(":")[1].Trim());
                }
                else if (line.StartsWith($"{TargetExpression}.RMSE2:"))
                {
                    RMSE2 = double.Parse(line.Split(":")[1].Trim());
                }
                else if (line.StartsWith($"{TargetExpression}.SamplePoints:"))
                {
                    // SamplePoints: (0.1, 0.111) (0.2, 0.222)
                    string str1 = line.Split(":")[1].Trim();
                    str1 = str1.Replace("(", "");
                    string[] str2Arr = str1.Split(")", StringSplitOptions.RemoveEmptyEntries|StringSplitOptions.TrimEntries);
                    foreach (var s2 in str2Arr) // for each "0.1, 0.111"
                    {
                        if (s2.Trim() == String.Empty)
                            continue;
                        var sArr = s2.Split(",", StringSplitOptions.TrimEntries); // ["0.1", "0.111"]
                        var dArr = Array.ConvertAll(sArr, Double.Parse);          // [0.1, 0.111]
                        SamplePoints.Add((dArr[0], dArr[1]));
                    }
                }
            }//foreach
            return found_coef;
        }

        public void Save(string filepath, bool append = false)
        {
            using (StreamWriter sw = new StreamWriter(filepath, append))
            {
                if (append)
                {
                    sw.WriteLine();
                    sw.WriteLine();
                }
                sw.WriteLine($"# {TargetExpression}");
                sw.Write($"{TargetExpression}.Coefficients:");
                foreach (var x in Coefficients)
                {
                    sw.Write($" {x:N3}");
                }
                sw.WriteLine();
                sw.WriteLine($"{TargetExpression}.RMSE1: {RMSE1}");
                sw.WriteLine($"{TargetExpression}.RMSE2: {RMSE2}");
                sw.Write($"{TargetExpression}.SamplePoints:");
                for (int i = 0; i < SamplePoints.Count; i++)
                {
                    var p = SamplePoints[i];
                    sw.Write($" ({p.Item1,6:N3}, {p.Item2,6:N3})");
                    var c = i + 1;
                    if (c % 10 == 0 && c < SamplePoints.Count)
                    {
                        // one line has 10 points
                        sw.WriteLine();
                        sw.Write($"{TargetExpression}.SamplePoints:");
                    }
                }
                sw.WriteLine();
            } // using

        }

    }
}
