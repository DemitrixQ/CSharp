using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTasks
{
    class CheckLevel
    {
        public static int Check(int [] levelmassive)
        {
            int max = levelmassive[0];
            for (int i = 1; i < levelmassive.Length; i++)
            {
                if (levelmassive[i] > max)
                {
                    max = levelmassive[i];
                }
            }
            return max;
        }
    }
}
