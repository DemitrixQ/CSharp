using System;

namespace Task_5._9
{
    /*9.Вводится последовательность целых чисел, оканчивающаяся нулём, и состоящая более чем из одного ненулевого элемента.
    Определить, являются ли вводимые числа числами Фибоначчи.*/

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите числа последовательности, которая оканчивается нулём");
            int last, previous1, previous2;
            previous1 = 0;
            previous2 = 0;
            do
            {
                last = int.Parse(Console.ReadLine());
                if (last != 0)
                {
                    previous2 = previous1;
                    previous1 = last;

                }
                else
                { Console.WriteLine("Обработка завершена"); }
            }
            while (last != 0);
             if ((previous1 + previous2 == last) && (previous1 != 0) && (previous2 != 0))
                {
                    Console.WriteLine("Последние 3 числа - являются числами Фибоначчи");
                }
            else
                {
                    Console.WriteLine("Последние 3 числа - не являются числами Фибоначчи");
                }

            Console.ReadKey();
        }
    }
}
