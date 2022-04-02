using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CurveLib
{
    public class Utils
    {
        public static string RemoveTrailingZeros(string str)
        {
            str = Regex.Replace(str, @"\.000$", "");
            str = Regex.Replace(str, @"\.00$", "");
            str = Regex.Replace(str, @"\.0$", "");
            return str;
        }

        public static string GenCubicExpr(double[]? arr)
        {
            if (arr == null)
                return String.Empty;

            string str = Utils.RemoveTrailingZeros($"{arr[0]:N2}");
            for (int i = 1; i < arr.Length; i++)
            {
                str += " ";
                if (arr[i] >= 0)
                    str += "+ ";
                str += Utils.RemoveTrailingZeros($"{arr[i]:N2}");
                str += $"u";
                if (i > 1)
                    str += $"^{i}";
            }
            return str;
        }
    }
}
