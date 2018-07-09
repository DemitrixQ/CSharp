using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYSorter_Solution
{
    class LineUtill
    {
        public static Number[] Generate(int n)
        {
            Number[] a = new Number[n];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Number();
                a[i].ch = ' ';
                a[i].key = rnd.Next(99);
            }
            return a;
        }
    }
}
