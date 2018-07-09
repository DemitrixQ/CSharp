using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibraryStack
{
     public class MyList
    {
        public MyNode head;         // голова этого списка
        public int count;           // число элементов в этом списке
        public MyList()
        {
            head = null;
            count = 0;
        }
        public void Add(int inf)           // Добавить в список
        {
            MyNode p = new MyNode(inf, head);
            head = p;
            count++;
        }
        public string[] Printer()                 // Вывод списка
        {
            string[] st = new string[0];
            int L = 0;
            MyNode p = head;
            if (p != null)
                do
                {
                    Array.Resize<string>(ref st, ++L);
                    st[L - 1] = p.inf.ToString();
                    p = p.next;
                }
                while (p != null);
            return st;
        }
        public MyNode FindNode(int val)             // Поиск узла
        {
            MyNode p = head;
            bool ok = false;
            while ((p != null) && !ok)
            {
                ok = p.inf == val;
                if (!ok)
                    p = p.next;
            }
            return p;
        }

        public void Delete(int index)                // Удалить по индексу
        {
            if (index != 0)
            {
                MyNode p = head;
                for (int i = 0; i < index - 1; i++)
                    p = p.next;
                if (p.next != null)
                    p.next = p.next.next;
            }
            else
                head = head.next;
            count--;
        }
        public void Insert(int index, int val)              // Вставить по индексу
        {
            if (index != 0)
            {
                MyNode p = head;
                for (int i = 0; i < index; i++)
                    p = p.next;
                MyNode q = new MyNode(val, p.next);
                p.next = q;
            }
            else
            {
                MyNode q = new MyNode(val, head);
                head = q;
            }
            count++;
        }

    }
}
