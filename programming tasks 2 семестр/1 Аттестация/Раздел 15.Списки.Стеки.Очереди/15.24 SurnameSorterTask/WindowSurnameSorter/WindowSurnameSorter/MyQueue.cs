using System;

namespace WindowSurnameSorter
{

    public class MyQueue
    {
        private MyNode head;
        private MyNode tail;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public void Enqueue(string surname)  ///положим в очередь
        {
            MyNode p = new MyNode(surname);
            if (tail == null && head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
            }
            count++;
        }

        public string Dequeue()  //заберем из очереди
        {
            MyNode p = head;
            if (head == null)
                throw new Exception("Queue is empty");
            else
            {
                if (count == 1)
                {
                    tail = null;
                }
                head = head.next;
                count--;
            }
            return p.inf;
        }
        public void Clear() //очищаем очередь
        {
            head = null;
            tail = null;
            count = 0;
        }

        public string[] Printer() //печатаем
        {
            MyNode p = new MyNode("");
            string[] result = new string[count];
            p = head;
            result[0] = p.inf.ToString();
            for (int i = 1; i < count; i++)
            {
                p = p.next;
                result[i] = p.inf.ToString();
            }
            return result;
        }
    }

}
