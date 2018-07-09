using System;

namespace Task_2._9
{
    /*
     9.	Проверить истинность высказывания: 
     «Сумма двух первых цифр данного четырехзначного числа равна сумме двух его последних цифр»
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n1, p1, p2, p3, p4, m1, m2;
            double s1, s2;
            Console.WriteLine("Введите четырехзначное число");
            n1 = int.Parse(Console.ReadLine());

            p1 = n1 / 1000;
            m1 = n1 % 1000;
            p2 = m1 / 100;
            m2 = m1 % 100;
            p3 = m2 / 10;
            p4 = m2 % 10;
            s1 = p1 + p2;
            s2 = p3 + p4;
            bool answer = (s1 == s2) && (n1 >= 1000) && (n1 <= 9999);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
