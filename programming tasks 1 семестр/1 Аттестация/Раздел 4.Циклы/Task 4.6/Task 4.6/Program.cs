using System;

namespace Task_4._6
{
    //6.Составить программу для нахождения и печати всех пифагоровых чисел, не превышающих 20
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Нажмите любую кнопку для получения пифагоровых чисел до 20");
            Console.ReadKey();
            int a, b, c;
            for (c = 1; c <= 20; c++)
                for (a = 1; a <= c; a++)
                    for (b = 1; b <= c; b++)
                    {
                        if ((c * c == a * a + b * b) && (b > a))
                        {
                            Console.WriteLine("Пифагоровы числа= {0}, {1}, {2}", a, b, c);
                        }
                    }
            Console.WriteLine("Программа завершена");
            Console.ReadKey();

        }


    }
}
