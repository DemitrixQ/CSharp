using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYSorter_Solution
{
    class Sorter
    {
        public static PointNode[] IncreaseSort(PointNode[] a, bool incranswer)
        {
            int left = 1;
            int right = a.Length - 1;
            int last = right;
            do
            {
                for (int j = right; j >= left; j--)
                {
                   if ((incranswer && PointNode.Compare(a[j-1], a[j]) > 0) || (!incranswer && PointNode.Compare(a[j-1], a[j]) < 0))
                    {
                        PointNode z = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = z;
                        last = j;
                    }
                }
                left = last;
                for (int j = left; j <= right; j++)
                {
                    if ((incranswer && PointNode.Compare(a[j - 1], a[j]) > 0) || (!incranswer && PointNode.Compare(a[j - 1], a[j]) < 0))
                    {
                        PointNode z = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = z;
                        last = j;
                    }
                }
                right = last - 1;
            }
            while (left<right);
            return a;
        }
        //public static PointNode[] DecreaseSort(PointNode [] a)  
        //{
        //    int left = 1;
        //    int right = a.Length - 1;
        //    int last = right;
        //    do
        //    {
        //        for (int j = right; j >= left; j--)
        //        {
        //            if ((a[j - 1].x < a[j].x) || ((a[j - 1].x == a[j].x) && (a[j - 1].y < a[j].y)))
        //            {
        //                string s = a[j - 1].name;
        //                int t = a[j - 1].x;
        //                int k = a[j - 1].y;
        //                a[j - 1].name = a[j].name;
        //                a[j - 1].x = a[j].x;
        //                a[j - 1].y = a[j].y;
        //                a[j].name = s;
        //                a[j].x = t;
        //                a[j].y = k;
        //                last = j;
        //            }
        //        }
        //        left = last;
        //        for (int j = left; j <= right; j++)
        //        {
        //            if ((a[j - 1].x < a[j].x) || ((a[j - 1].x == a[j].x) && (a[j - 1].y < a[j].y)))
        //            {
        //                string s = a[j - 1].name;
        //                int t = a[j - 1].x;
        //                int k = a[j - 1].y;
        //                a[j - 1].name = a[j].name;
        //                a[j - 1].x = a[j].x;
        //                a[j - 1].y = a[j].y;
        //                a[j].name = s;
        //                a[j].x = t;
        //                a[j].y = k;
        //                last = j;
        //            }
        //        }
        //        right = last - 1;
        //    }
        //    while (left < right);
        //    return a;
        }
    }
