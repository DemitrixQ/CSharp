using System;
using System.Collections.Generic;
using System.Linq;

namespace LotTask
{
    /*
     10.1 Даны три множества Х1, Х2, Х3, содержащие целые числа из диапазона 1..100. Известно, что мощность каждого из этих множеств равна 10. 
          Сформировать новое множество Y=(Х1 U Х2) (Х2\ Х3), из которого выделить подмножество нечетных чисел.
          На экран вывести исходные и полученное множества. 
          Значения элементов исходных множеств ввести с клавиатуры.
     */
    class ClassFormer
    {
        public static HashSet<int> FillRandom() // заполняем строку значениями
        {
            HashSet<int> standart = new HashSet<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    int x = random.Next(1, 101);
                    if (!standart.Contains(x))
                    {
                        standart.Add(x);
                        break;
                    }
                }
            }
            return standart;
        }

        public static string Print(HashSet<int> x) // выводим в текст-боксы
        {
            string result = "";
            foreach (var z in x)
            {
                result += z.ToString() + " ";
            }
            return result;
        }
        public static HashSet<int> Get(string x) //получаем строку значений для последующей обработки
        {
            HashSet<int> fromstring = new HashSet<int>();
            string[] standart = x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var i in standart)
            {
                fromstring.Add(Convert.ToInt32(i));
            }
            return fromstring;
        }
        public static HashSet<int> FormLot(HashSet<int> X11, HashSet<int> X21, HashSet<int> X31) //обрабатываем множества
        {
            HashSet<int> x1 = new HashSet<int>(X11);
            HashSet<int> x2 = new HashSet<int>(X21);
            HashSet<int> x3 = new HashSet<int>(X31);
            x1.Concat(x2);
            x2.IntersectWith(x3);
            x1.IntersectWith(x3);
            return x1;
        }
        public static HashSet<int> FormOddNumbersLot(HashSet<int> X11)
        {
            HashSet<int> x1 = new HashSet<int>(X11);
            HashSet<int> x2 = new HashSet<int>();
            foreach (int z in x1)
            {
                if (z%2!=0)
                {
                x2.Add(z);
                }
            }
            return x2;
        }

    }
}
