using System;

namespace Task_1._24
{
    class Program
    {
        //24 Найти периметр и площадь прямоугольного треугольника, если даны длины его катетов a и b. 

        static void Main(string[] args)
        {

            double a, b, s, p;
            Console.WriteLine("Введите длинну участка");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину участка");
            b = double.Parse(Console.ReadLine());
            s = a * b;
            p = (a + b) * 2;
            Console.WriteLine("Площадь участка {0}", s);
            Console.WriteLine("Периметр участка {0}", p);
            Console.ReadKey();

        }
    }
}
