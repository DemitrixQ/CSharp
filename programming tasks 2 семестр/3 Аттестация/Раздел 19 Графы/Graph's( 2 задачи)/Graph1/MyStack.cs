using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    class MyStack
    {
       // MyNode tail;
        MyNode top;
        private int count = 0;

        public int GetCount()
        {
            return count;
        }

        public MyStack()                  
        {
            top = null;
            //tail = null;
        }

        public void Push(string inf)    
        {
            top = new MyNode(top, inf);
            count++;
            //if (top.next == null)
               //tail = top;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public int getCount()
        {
            return count;
        }
    }
}
