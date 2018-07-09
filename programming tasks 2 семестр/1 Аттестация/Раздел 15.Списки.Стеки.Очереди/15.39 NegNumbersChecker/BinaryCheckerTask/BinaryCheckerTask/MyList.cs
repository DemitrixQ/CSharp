using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryCheckerTask
{
    class MyList            // очередь
    {
        private MyNode head;
        private MyNode tail;
        private int count;
        private int negcount;

        public int Count
        {
            get { return count; }
        }
        public int NegCount
        {
            get { return negcount; }
        }

        public void Enqueue(int number)         //положим в очередь
        {
            MyNode p = new MyNode(number);
            if (tail == null && head == null)
            {
                head = p;        //не знаю можно ли вынести tail = p (повтор в if/else)
            }
            else
            {
                tail.next = p;
            }
            tail = p;
            if (number <= 0)
            {
                negcount++;
            }
            count++;
        }
        

    public int[] GetNeg()                  //получааем массив чисел (количество следующих отрицательных)
        {
            int k = count;
            int n = negcount;
            int[] f = new int[k];
            MyNode z = head;
            if (z.number <= 0)
            {
                n--;
            }
            f[0] = n;
            z = z.next;
            for (int i = 1; i <k; i++)
            {
                if (z.number <= 0)
                {
                    n--;
                }
                f[i] = n;
                z = z.next;
            }
            return f;
        }

        public string[] SuperPrinter(int[] b)  //выводим комбо
        {
            MyNode p = new MyNode(0);
            string[] result = new string[count];
            p = head;
            for (int i = 0; i < count; i++)
            {
                result[i] = p.number.ToString() + " :: " + b[i].ToString();
                p = p.next;
            }
            return result;
        }
        //public string GetNegString()   // печатаем
        //{
        //    string o = Convert.ToInt32(negcount) + " : ";
        //    int k = count;
        //    int n = negcount;
        //    int[] f = new int[k];
        //    int z = head.number;
        //    if (z <= 0)
        //    {
        //        n--;
        //    }
        //        f[0] = n;
        //        o += f[0] + " ";
        //    head = head.next;
        //    for (int i = 1; i < k; i++)
        //    {
        //        z = head.number;
        //        if (z <= 0)
        //        {
        //            n--;
        //        }
        //        f[i] = n;
        //        o += f[i] + " ";
        //        head = head.next;
        //    }
        //    return o;
        //}
        //public int Dequeue()  //заберем из очереди
        //{
        //    MyNode p = head;
        //    if (head == null)
        //        throw new Exception("Queue is empty");
        //    else
        //    {
        //        if (count == 1)
        //        {
        //            tail = null;
        //        }
        //        head = head.next;
        //        count--;
        //    }
        //    return p.number;
        //}

    }

}
