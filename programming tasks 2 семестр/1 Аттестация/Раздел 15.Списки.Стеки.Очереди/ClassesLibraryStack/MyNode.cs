using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibraryStack
{
     public class MyNode
    {

        public int inf;
        public MyNode next;
        public MyNode(int inf, MyNode next)
        {
            this.inf = inf;
            this.next = next;

        }
    }
}
