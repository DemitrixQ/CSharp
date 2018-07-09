using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._24
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 24.	Даны три переменные: X, Y, Z.
              Если их значения упорядочены по убыванию, то удвоить их; 
              в противном случае заменить значение каждой переменной на противоположное*/;
            int X, Y, Z;
            Console.WriteLine("Введите значение X");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Z");
            Z = int.Parse(Console.ReadLine());
            if ((Y > Z) && (X > Y))
                {
                    X *= 2;
                    Y *= 2;
                    Z *= 2;
                 }
            else
                {
                    X = -X;
                    Y = -Y;
                    Z = -Z;
                }

            Console.WriteLine("Новое значение x={0}", X);
            Console.WriteLine("Новое значение y={0}", Y);
            Console.WriteLine("Новое значение z={0}", Z);

            Console.ReadKey();
        }
    }
}
