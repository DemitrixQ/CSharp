using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace XYSorter_Solution
{
    class NodePrinter
    {
        public static string [] Print(Number [] b) 
        {
            string[] p = new string[b.Length];
            for (int i=0; i<b.Length;i++)
            {
                p[i] = b[i].ch.ToString() + "." + b[i].key.ToString();
            }
            return p;
        }
    }
}
