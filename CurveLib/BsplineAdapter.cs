using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurveLib
{
    public class BsplineAdapter: BsplineEngine
    {
        public int ExpressionIndexX = 0; // comboBoxExpressionX selected index

        public int ExpressionIndexY = 0; // comboBoxExpressionY selected index

        public void SaveTargetPoints(string filepath)
        {
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine($"ExpressionIndexX: {ExpressionIndexX}");
                sw.WriteLine($"ExpressionIndexY: {ExpressionIndexY}");
                sw.WriteLine();
                sw.Write("TargetPoints:");
                for (int i = 0; i < TargetPoints.Count; i++)
                {
                    var p = TargetPoints[i];
                    sw.Write($" ({p.Item1,6:N3}, {p.Item2,6:N3})");
                    var c = i + 1;
                    if (c % 10 == 0 && c < TargetPoints.Count)
                    {
                        // one line has 10 points
                        sw.WriteLine();
                        sw.Write("TargetPoints:");
                    }
                }
                sw.WriteLine();
            }
        }

        public void Save(string filepath)
        {
            SaveTargetPoints(filepath);

            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                sw.WriteLine();
                sw.Write("ControlPoints:");
                for (int i = 0; i < ControlPoints.Count; i++)
                {
                    var p = ControlPoints[i];
                    sw.Write($" ({p.Item1,6:N3}, {p.Item2,6:N3})");
                    var c = i + 1;
                    if (c % 10 == 0 && c < ControlPoints.Count)
                    {
                        // one line has 10 points
                        sw.WriteLine();
                        sw.Write("ControlPoints:");
                    }
                }
                sw.WriteLine();
                sw.WriteLine();
                sw.Write("KnotValues:");
                for (int i = 0; i < KnotValues.Count; i++)
                {
                    var p = KnotValues[i];
                    sw.Write($" {p,6:N3}");
                    var c = i + 1;
                    if (c % 10 == 0 && c < KnotValues.Count)
                    {
                        // one line has 10 points
                        sw.WriteLine();
                        sw.Write("KnotValues:");
                    }
                }
                sw.WriteLine();
            }
        }

        public void LoadTargetPoints(string filepath)
        {
            TargetPoints.Clear ();
            string[] lines = File.ReadAllLines(filepath);
            foreach (string _line in lines)
            {
                var line = _line.Trim();
                if (line == String.Empty || line.StartsWith("#"))
                    continue;
                if (line.StartsWith("ExpressionIndexX:"))
                {
                    string str = line.Split(":")[1].Trim();
                    ExpressionIndexX = int.Parse(str);
                }
                else if (line.StartsWith("ExpressionIndexY:"))
                {
                    string str = line.Split(":")[1].Trim();
                    ExpressionIndexY = int.Parse(str);
                }
                else if (line.StartsWith("TargetPoints:"))
                {
                    // TargetPoints: (0.1, 0.111) (0.2, 0.222)
                    string str = line.Split(':')[1].Trim();
                    if (str == String.Empty)
                        continue;
                    str = str.Replace("(", "");
                    string[] arr = str.Split(")", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                    foreach (var s in arr) // for each "0.1, 0.111"
                    {
                        if (s.Trim() == String.Empty)
                            continue;
                        var sArr = s.Split(",", StringSplitOptions.TrimEntries); // ["0.1", "0.111"]
                        var dArr = Array.ConvertAll(sArr, Double.Parse);         // [0.1, 0.111]
                        TargetPoints.Add((dArr[0], dArr[1]));
                    }
                }
            }// foreach
        }// LoadTargetPoints()
    }
}
