using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._39
{
    class Program
    {
        static void Main(string[] args)
        {
            /*39.Ввести три числа. 
              Если они могут быть длинами сторон равнобедренного остроугольного треугольника, 
              вычислить его площадь, вывести длины сторон и площадь в порядке возрастания.*/
            double x, y, z, t, s;
            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите  значение y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение z");
            z = double.Parse(Console.ReadLine());
            if (x > y)
                {
                    t = x;
                    x = y;
                    y = t;
                }
            if (x > z)
                {
                    t = x;
                    x = z;
                    z = t;
                }
            if (y > z)
                {
                    t = y;
                    y = z;
                    z = t;
                }
            if (x + y > z)
                 {
                    if (y == z)
                     {
                        if (x * x < y * y + z * z)
                        {
                            s = (x / 2) * Math.Sqrt(z * z - (x * x) / 4);
                            Console.WriteLine("Значения по порядку : {0}, {1}, {2}", x, y, z);
                            Console.WriteLine("Площадь треугольника= {0}", s);

                        }
                        else
                        {
                            Console.WriteLine("Это не остроугольный равнобедренный треугольник, введите другое значение");
                        }
    
                    }
                    else
                    {

                        Console.WriteLine("Это неравнобедренный треугольник, введите другое значение");
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

