using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricCurve
{
    public class ListBoxRich: ListBox
    {
        public List<(double X, double Y)> Points = new List<(double X, double Y)>();

        public delegate void OnListChangedDelegate();

        public event OnListChangedDelegate? OnListChanged;

        public void Clear()
        {
            base.Items.Clear();
            Points.Clear();
            if (OnListChanged != null)
            {
                OnListChanged();
            }
        }

        public void RemoveAt(int idx)
        {
            base.Items.RemoveAt(idx);
            Points.RemoveAt(idx);
            if (OnListChanged != null)
            {
                OnListChanged();
            }
        }

        public void Add((double, double) p)
        {
            base.Items.Add($"{p.Item1,5:N3}:  {p.Item2,5:N3}");
            Points.Add(p);
            if (OnListChanged != null)
            {
                OnListChanged();
            }
        }

        public void Add(double x, double y)
        {
            Add((x, y));
        }
    }
}
