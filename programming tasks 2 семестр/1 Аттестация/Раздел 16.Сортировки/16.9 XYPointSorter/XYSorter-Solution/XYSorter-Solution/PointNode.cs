using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYSorter_Solution
{
    class PointNode
    {
        public string name;
        public int x, y;
        public static int Compare(PointNode p1, PointNode p2)
        {
            if ((p1.x == p2.x) && (p1.y == p2.y))  // точки равны
            return 0;
            if ((p2.x > p1.x) || ((p1.x==p2.x) && (p2.y>p1.y))) // точка 2 больше точки 1
            return -1; //  true
            return 1; // точка 1 больше точки 2
        }
    }
}
