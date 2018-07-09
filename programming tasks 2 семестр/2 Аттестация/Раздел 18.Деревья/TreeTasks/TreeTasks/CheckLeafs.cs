using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTasks
{
    class CheckLeafs
    {
        public static int GetMinimalLeaf(int[] leafsmassive)
        {

            int min = leafsmassive[0];
            for (int i = 1; i < leafsmassive.Length; i++)
            {
                if (leafsmassive[i] < min)
                {
                    min = leafsmassive[i];
                }
            }
            return min;
        }
    }
}
