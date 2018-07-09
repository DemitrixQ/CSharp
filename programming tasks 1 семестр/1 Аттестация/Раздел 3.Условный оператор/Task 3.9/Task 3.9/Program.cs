using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._9
{
    /*9.Ввести три числа. 
    Если они могут быть длинами сторон разностороннего остроугольного треугольника,
    вывести их в порядке возрастания, вычислить площадь полученного треугольника*/
    class Program
    {
        static void Main(string[] args)
        {
          
            double a, b, c, p, s, t;
            Console.WriteLine("Введите длину первой стороны");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны");
            c = double.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                if ((a != b) && (b != c) && (c != a))
                {
                    if (a > b)
                    {
                        t = a;
                        a = b;
                        b = t;
                    }

                    if (a > c)
                    {
                        t = a;
                        a = c;
                        c = t;
                    }
                    if (b > c)
                    {
                        t = b;
                        b = c;
                        c = t;
                    }
                    if (c * c > a * a + b * b)
                    {
                        Console.WriteLine("Стороны остроугольного треугольника в порядке возрастания= {0},{1},{2}", a, b, c);
                        p = (a + b + c) / 2;
                        Console.WriteLine("Полупериметр остроугольного треугольника= {0}", p);
                        s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("Площадь остроугольного треугольника= {0}", s);
                    }
                    else { Console.WriteLine("Это не остроугольный треугольник, введите верные значения"); }
                }
                else
                {
                    Console.WriteLine("Это НЕРАЗНОСТОРОННИЙ треугольник, введите корректное значение");
                }
            }
            else
            {
                Console.WriteLine("Это не треугольник, введите корректные значения");
            }
            Console.ReadKey();

        }
    }
}
   

