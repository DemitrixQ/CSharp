using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph1
{
    public class MyNode
    {
            public MyNode next;
            public string inf;
            public MyNode(MyNode next, string inf)
            {
                this.next = next;
                this.inf = inf;
            }
    }
}
