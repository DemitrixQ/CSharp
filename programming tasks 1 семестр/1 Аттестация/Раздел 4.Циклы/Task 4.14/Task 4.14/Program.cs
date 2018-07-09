using System;

namespace Task_4._14
{
    /*14.При некоторых заданных x, N и E, определяемых вводом, вычислить:
              a) сумму N слагаемых заданного вида;
              b) сумму тех слагаемых, которые по абсолютной величине больше Е.
         Для случая b выполнить суммирование для двух значений Е, отличающихся на порядок, и при этом определить количество слагаемых, включенных в сумму. 
         Сравнить результаты с точным значением функции, для которой данная сумма определяет приближенное значение при x, лежащем в интервале (-R, R) */
    class Program
    {
        static void Main(string[] args)
        {
            double x, N, E, e, summA, summB, summC, aimed, difference, difference1, difference2, p, general, general2;
            int i, z, w;
            Console.WriteLine("Введите значение переменной x");
            x = double.Parse(Console.ReadLine());
            if ((x < 1) && (x > -1))
            {
                Console.WriteLine("Введите значение переменной N");
                N = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение переменной E");
                E = double.Parse(Console.ReadLine());
                if (E < 1)
                {
                    e = E / 10;
                    z = 0;
                    w = 0;
                    p = -x;
                    double slagaemoe = 1;
                    summA = 1;
                    for (i = 2; i <= N; i++)
                        {
                            slagaemoe = slagaemoe * (-x);
                            summA = summA + slagaemoe * (i * (i + 1) * 0.5);
                        }
                    aimed = 1 / ((1 + x) * (1 + x) * (1 + x));
                    difference = aimed - summA;
                    double slagaemoe2 = 1;
                    summB = 1;
                    int k = 2;
                    general = Math.Abs((k * (k + 1) * x * p) / 2);
                    while (Math.Abs(general) > E)
                         {
                            slagaemoe2 = slagaemoe2 * (-x);
                            general = slagaemoe2 * ((k * (k + 1)) / 2);
                            summB = summB + general;
                            k = k + 1;
                            z = z + 1;
                         }
                    double slagaemoe3 = 1;
                    summC = 1;
                    int u = 2;
                    general2 = Math.Abs((u * (u + 1) * x * p) / 2);
                    while (Math.Abs(general2) > e)
                        {
                            slagaemoe3 = slagaemoe3 * (-x);
                            general2 = slagaemoe3 * ((u * (u + 1)) / 2);
                            summC = summC + general2;
                            u = u + 1;
                            w = w + 1;
                        }
                    difference1 = aimed - summB;
                    difference2 = aimed - summC;
                    Console.WriteLine();
                    Console.WriteLine("А)Сумма N слагаемых = {0}", summA);
                    Console.WriteLine();
                    Console.WriteLine("  Точное значение = {0}", aimed);
                    Console.WriteLine();
                    Console.WriteLine("  Разница между точным и полученным значением = {0}", difference);
                    Console.WriteLine();
                    Console.WriteLine("Б)Сумма слагаемых, которые по величине больше E = {0}", summB);
                    Console.WriteLine();
                    Console.WriteLine("  Разница между точным и полученным значением при E = {0}", difference1);
                    Console.WriteLine();
                    Console.WriteLine("  Сумма слагаемых, которые по величине больше e = {0}", summC);
                    Console.WriteLine();
                    Console.WriteLine("  Разница между точным и полученным значением при e = {0}", difference2);
                    Console.WriteLine();
                    Console.WriteLine("  Количество слагаемых, включенных в сумму значений больше E = {0}", z);
                    Console.WriteLine();
                    Console.WriteLine("  Количество слагаемых, включенных в сумму значений больше e = {0}", w);
                    Console.ReadKey();
                }

                else
                {
                    Console.WriteLine("Введенная E-окрестность слишком велика. Выберите число меньше 1");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Введите значение переменной x в интервале (-1;1)");
                Console.ReadKey();
            }
        }
    }
    }

