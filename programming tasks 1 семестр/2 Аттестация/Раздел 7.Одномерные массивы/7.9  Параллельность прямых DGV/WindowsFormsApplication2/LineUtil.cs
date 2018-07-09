using System;

namespace WindowsFormsApplication2
{
    /* 9.Прямая на плоскости может быть задана уравнением ax + by = c, где a, b одновременно не равны нулю, a, b, c — целые. 
     Пусть даны коэффициенты нескольких прямых a1, b1, c1, a2, b2, c2, ..., an, bn, cn. 
     Определить, имеются ли среди этих прямых совпадающие или параллельные.
     */
    class LineUtil
    {
        public static Line[] Generate(int n)
        {
            Line[] a = new Line[n];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Line();
                a[i].a = rnd.Next(100);
                a[i].b = rnd.Next(100);
                a[i].c = rnd.Next(100);
            }
            return a;
        }
        public static bool ParallelCheck (Line[] a)
        {
            for (int o = 0; o< a.Length;o++)
                for (int j = o + 1; j < a.Length; j++)
                {
                    if (a[o].a*a[j].b == a[j].a*a[o].b)
                    {
                        return true;
                    }
                }


            return false;     
        }
    }
}
