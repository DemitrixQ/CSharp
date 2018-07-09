using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTasks
{
    class Node
    {
        public int key;// значение 
        public Node left;  // ссылка на левое поддерево
        public Node right; // ссылка на правое поддерево
        public int x;
        public int y;
        public bool visit; // посещали ли
        public int count; // счетчик
        public int level; // уровень
       // public bool leaf; // является ли листиком дерева           
        
        
        //конструктор узелочка
        public Node(Node left, Node right, int key, int x, int y, int level)
        {
            this.left = left;
            this.right = right;
            this.key = key;
            this.x = x;
            this.y = y;
            this.level = level;
            this.visit = false;
            this.count = 1;
        }

        public bool isLeaf
        {
            get { return (left == null) && (right == null); }
        }

    }
}
