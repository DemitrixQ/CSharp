using System;

namespace Task_1._9
{
    /*9.Розничная цена мужского костюма составляет R рублей. 
    Наценка магазина составляет T% от оптовой цены. 
        Составить программу определения оптовой цены костюма.*/
    class Program
    {
        static void Main(string[] args)
        {
            double s, t, r;
            Console.WriteLine("Введите розничную стоимость костюма");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент");
            t = double.Parse(Console.ReadLine());
            s = r / (1 + t * 0.01);
            Console.WriteLine("Оптовая стоимость костюма {0}", s);
            Console.ReadKey();
        }
    }
}
