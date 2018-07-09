using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyrecursion
{
    //14.1.Описать рекурсивную функцию для подсчёта количества запятых  в  данном текстовом файле.
    class ClassSearch
    {
        //public static int Recursion(string s) Без рекурсии
        //    {
        //    int f = s.Length;
        //    s.ToCharArray();
        //    int result=0;
        //    for (int i = 0; i < f; i++)
        //    {
        //        if (s[i] ==',')
        //        {
        //            result++;
        //        }

        //    }
        //    return result;
        //    }
        public static int Recursion(char[] s, int f) // подсчёт с рекурсией
        {
            int result=0;
            int k = f-1;
            if (k==0)
            {
                if (s[0]==',')
                {
                    result++;
                }
                
            }
            else
            {
                if (s[k]==',')
                {
                    result++;
                }
                result = result+Recursion(s, f - 1);
            }
            return result;
        }
    }
}
