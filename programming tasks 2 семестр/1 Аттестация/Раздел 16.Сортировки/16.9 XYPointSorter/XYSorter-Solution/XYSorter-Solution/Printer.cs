using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYSorter_Solution
{
    class Printer
    {
        public static string [] Print(PointNode [] b) 
        {
            string[] p = new string[b.Length];
            for (int i=0; i<b.Length;i++)
            {
                p[i]= b[i].name + "(" + b[i].x.ToString() + " : " + b[i].y.ToString() + ")";
            }
            return p;
        }
    }
}
