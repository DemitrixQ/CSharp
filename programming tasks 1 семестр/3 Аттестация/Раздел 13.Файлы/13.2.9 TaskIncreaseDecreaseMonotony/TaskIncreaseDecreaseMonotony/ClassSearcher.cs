using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskIncreaseDecreaseMonotony
{
    //13.2.9 Дан файл вещественных чисел. Найти количество его участков убывания1|возрастания2|монотонности
    class ClassSearcher
    {
        public static int Increase(string f)
        {
            string pcpath = f;
            using (BinaryReader file = new BinaryReader(new FileStream(pcpath, FileMode.Open)))
            {
                int ElementSize = sizeof(double);
                long s = file.BaseStream.Length;
                long k = s / ElementSize;
                int r = int.Parse(k.ToString());
                return r;
            }
        }
        public static int Decrease(string f)
        {
            string pcpath = f;
            using (BinaryReader file = new BinaryReader(new FileStream(pcpath, FileMode.Open)))
            {
                int ElementSize = sizeof(double);
                long s = file.BaseStream.Length;
                long k = s / ElementSize;
                int r = int.Parse(k.ToString());
                return r;
            }
        }
        public static int Quantity(string f)
        {
            string pcpath = f;
            using (BinaryReader file = new BinaryReader(new FileStream(pcpath, FileMode.Open)))
            {
                int ElementSize = sizeof(double);
                long s = file.BaseStream.Length;
                long k = s / ElementSize;
                int counter = int.Parse(k.ToString());
                return counter;
            }
        }
        //bool variable=true;
        //int hlpr1;
        //int hlpr2=0;
        //hlpr1 = Convert.ToInt32(f[0]);
        //for (int i=0;i<f.Length;i++)
        //{
        //    if (f[i] !=' ')                          - не то
        //    {
        //        hlpr2 = Convert.ToInt32(f[i]);
        //    }
        //    if ((variable) && (hlpr2>hlpr1) && (hlpr2!=0))
        //    {

        //    }

        //}
        //return hlpr1;

        //        int counter = 0;
        //        int k=0;
        //        int number = s[0];
        //        for (int i = 1; i<=s.Length-1;i++)
        //            {
        //            if (s[i]<number)
        //            {
        //            number=s[i];
        //            
        //              if (k>=1)                       - участок возрастания
        //                          {
        //                              counter++;
        //                              k=0;
        //                          }
        //            }
        //            else 
        //            {
        //              number=s[i];
        //              k++;
        //            }
        //            return counter;

        //        int counter = 0;
        //        int k=0;
        //        int number = s[0];
        //        for (int i = 1; i<=s.Length-1;i++)
        //            {
        //            if (s[i]>number)
        //            {
        //            number=s[i];
        //            
        //              if (k>=1)                    - участок убывания
        //                          {
        //                              counter++;
        //                              k=0;
        //                          }
        //            }
        //            else 
        //            {
        //              number=s[i];
        //              k++;
        //            }
        //            return counter;
    }
}
