using System;

namespace WindowsFormsSearching
{
    /*
     4.	Дано
    const
        MaxN = 30;
    type
         ВещТип = record
             знак : boolean;
             мантисса, порядок : real;
         end;
    список = array[1..MaxN] of ВещТип;

    Описать:
    4.1 функцию MaxNeg(C) для нахождения минимального отрицательного числа из списка чисел С;
    4.2 функцию MaxDi(C) для нахождения максимального порядка числа из списка вещественных чисел С;

     */
    class ClassSearch

    {
        public static RealNumber[] Generate(int n)
        {
            int k;
            RealNumber[] a = new RealNumber[n];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                k = rnd.Next(1, 3);
                a[i] = new RealNumber();
                if (k % 2 != 0)
                {
                    a[i].a = true;
                }
                else
                {
                    a[i].a = false;
                }
                a[i].mantissa = Convert.ToDouble(rnd.Next(100)) / 100;
                a[i].order = rnd.Next(1, 5);
            }
            return a;
        }

        public static RealNumber SearchMax(RealNumber[] a)
        {
            RealNumber ans = null;
            int i = 0;
            while (i < a.Length && (a[i].a == false /* !a[i].a*/))
                i++;
            if (i >= a.Length)
                return ans;
            ans = a[i];
            for (int j = i+1; j < a.Length; j++)
                if (a[j].a)
                /* (a[j].a && (a[j].order < ans.order || (a[j].order == ans.order && a[j].mantissa < ans.mantissa))) */
                {
                    if (a[j].order < ans.order)
                        ans = a[j];
                    else if (a[j].order == ans.order && a[j].mantissa < ans.mantissa)
                        ans = a[j];
                }
            return ans;
        }
        public static RealNumber SearchMin(RealNumber[] a)
        {
            RealNumber ans = null;
            int i = 0;
            while (i < a.Length && (a[i].a == false /* !a[i].a*/))
                i++;
            if (i >= a.Length)
                return ans;
            ans = a[i];
            for (int j = i + 1; j < a.Length; j++)
                if (a[j].a)
                /* (a[j].a && (a[j].order < ans.order || (a[j].order == ans.order && a[j].mantissa < ans.mantissa))) */
                {
                    if (a[j].order > ans.order)
                        ans = a[j];
                    else if (a[j].order == ans.order && a[j].mantissa > ans.mantissa)
                        ans = a[j];
                }
            return ans;
        }
        public static double Search(RealNumber[] a, int k)
        {
            double t;
            double number = 0;
            double number1 = 0;
            double j = 0;
            double w = 0;
            for (int o = 0; o < a.Length; o++)
            {
                if (a[o].a)
                {
                    number1 = Math.Pow(k, a[o].order);
                    if (number1 > number)
                    {
                        t = number1;
                        number1 = number;
                        number = t;
                        j = a[o].mantissa;
                    }
                    if (number1 == number)
                    {
                        w = a[o].mantissa;
                        if (w > j)
                        {
                            t = number1;
                            number1 = number;
                            number = t;
                            j = a[o].mantissa;
                        }

                    }
                    //else
                    //{
                    //    //number = number * a[o].b;
                    //    //number1 = number1 * a[o].b;
                    //    if (a[o].b>a[o+1].b)
                    //    {
                    //        //t = number1;
                    //        //number1 = number;
                    //        //number = t;
                    //        number = 49494;
                    //    }
                    //}
                }
            }
            // минимальное отрицательное - самое большое среди положительных
            // сравниваем порядки, в случае равенства сравниваем порядки чисел
            // максимальное отрицательное - наименьшее по модулю
            // минимальное отрицательное - наибольшее по модулю

            return number * j;
        }
        public static double Search2(RealNumber[] a, int k)
        {
            double t;
            double number = 0;
            double number1 = 0;
            double j = 0;
            double w = 0;
            for (int o = 0; o < a.Length; o++)
            {
                if (a[o].a.ToString() != "Positive")
                {
                    number1 = Math.Pow(k, a[o].order);
                    if (number1 > number)
                    {
                        t = number1;
                        number1 = number;
                        number = t;
                        j = a[o].mantissa;
                    }
                    if (number1 == number)
                    {
                        w = a[o].mantissa;
                        if (w < j)
                        {
                            t = number1;
                            number1 = number;
                            number = t;
                            j = a[o].mantissa;
                        }

                    }
                }
            }

            return number * j;
        }

        public static int SearchMaximumOrder(RealNumber [] a)
        {
            int k = a[0].order;
            for (int o = 1; o < a.Length; o++)
            {
                if (a[o].order>k)
                {
                   k= a[o].order;
                }

            }
            return k;
        }
































































    }
    }
