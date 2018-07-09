using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TreeTasks
{
    class MyTree
    {
        public Node top;                 // вершина дерева
        public MyTree()
        {
            top = null;
        }
        int i = 0;
        public int GetNodes()
        {
            return i;
        }
        public int GetMaximumOnLevel(int l)
        {
            Node x = FindMaximumOnLevel(top, l);
            if (x == null)
                throw new Exception("No level");
            return x.key;
        }

        public int GetMinimalLeaf()
        {
            return FindMinimalLeaf(top);
        }

        int maximum = 0;
        bool answer2 = true;

        public void AddRandom(int val, int x, int y)
        {
            AddRandom(ref top, val, x, y);
        }
        private Random rnd = new Random();
        private void AddRandom(ref Node p, int val, int x, int y, int l = 1)
        {
            if (p == null)
            {
                p = new Node(null, null, val, x, y, l);
                return;
            }
            if (rnd.NextDouble() < 0.5)
                AddRandom(ref p.left, val, x - step, y + location * step, ++l);
            else
                AddRandom(ref p.right, val, x + step, y + location * step, ++l);
        }
        //public void Add(ref Node e, int key, int x, int y, int level = 1)
        //{
        //    if (e == null)
        //    {
        //        e = new Node(null, null, key, x, y, level);
        //    }
        //    else
        //    {
        //        if (key < Convert.ToInt32(e.key))
        //        {
        //            Add(ref e.left, key, e.x - step, e.y + location * step, ++level);
        //        }
        //        else
        //        {
        //            if (key > Convert.ToInt32(e.key))

        //            {
        //                Add(ref e.right, key, e.x + step, e.y + location * step,  ++level);
        //            }
        //            else
        //            {
        //                e.count++;  // одинаковые значения data = Convert.ToInt32(e.data)
        //            }
        //        }

        //    }
        //}

        /// /////////////////////////////////////////   начинаем рисование
        const int step = 30;
        const int location = 1;
        Pen a = new Pen(Color.Black, 2);
        SolidBrush myBrush = new SolidBrush(Color.Black);
        Font myFont = new Font("Courier New", 10, FontStyle.Bold);

        public void DrawTree(Graphics g, int l, int r, int y, int step)
        {
            DrawNode(top, g, l, r, y, step);
        }
        //public void DrawTree(Graphics g)
        //{
        //    if (top != null)
        //        DrawNode(top, g);
        //}
        void DrawNode(Node p, Graphics g, int l, int r, int y, int step)
        {
            int radius = 15;
            if (p == null)
                return;
            int x = (l + r) / 2;
            if (p.left != null)
                g.DrawLine(Pens.Black, x, y, (l + x) / 2, y + step);
            if (p.right != null)
                g.DrawLine(Pens.Black, x, y, (r + x) / 2, y + step);
            if (p.visit)
            {
                myBrush = (SolidBrush)Brushes.Red;
            }
            else
            {
                myBrush = (SolidBrush)Brushes.DarkSeaGreen;
            }
            g.FillEllipse(myBrush, x - radius, y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(a, x - radius, y - radius, 2 * radius, 2 * radius);  /////////////////
            string s = Convert.ToString(p.key);// + ":" + Convert.ToString(o.count);
            SizeF size = g.MeasureString(s, myFont);
            g.DrawString(s, myFont, Brushes.Black, x - size.Width / 2, y - size.Height / 2);
            DrawNode(p.left, g, l, x, y + step, step);
            DrawNode(p.right, g, x, r, y + step, step);
        }
        //void DrawNode(Node o, Graphics g)
        //{
        //    int radius = 15;
        //    if (o.left != null)
        //    { 
        //        g.DrawLine(a, o.x, o.y, o.left.x, o.left.y); ///////
        //    }
        //    if (o.right != null)
        //    { 
        //        g.DrawLine(a, o.x, o.y, o.right.x, o.right.y); //////////
        //    }
        //    if (o.visit)
        //    {
        //        myBrush = (SolidBrush)Brushes.Red;
        //    }
        //    else
        //    {
        //        myBrush = (SolidBrush)Brushes.DarkSeaGreen;
        //    }
        //    g.FillEllipse(myBrush, o.x - radius, o.y - radius, 2 * radius, 2 * radius);
        //    g.DrawEllipse(a, o.x - radius, o.y - radius, 2 * radius, 2 * radius);  /////////////////
        //    string s = Convert.ToString(o.key);// + ":" + Convert.ToString(o.count);
        //    SizeF size = g.MeasureString(s, myFont);
        //    g.DrawString(s, myFont, Brushes.Black, o.x - size.Width / 2, o.y - size.Height / 2);
        //    if (o.left != null)
        //        DrawNode(o.left,g);
        //    if (o.right != null)
        //        DrawNode(o.right,g);
        //}

        public bool Obhod(Node k)                   // снятие признака посещения
        {
            if (k != null)
            {

                return true;
                Obhod(k.left);
                Obhod(k.right);
                return false;
            }
            return false;
        }
        public void Obhod3(Node k2)
        {

          
        }


        public void Moving(Node q)  // Сверху вниз
        {
            if (q != null)
            {
                Moving(q.left);
                Moving(q.right);
            }
        }

        private Node FindMaximumOnLevel(Node p, int level)

        {
            // bool sanswer = true;
            if (p == null)
                return null;
            if (p.level == level)
                return p;
            Node l;
            if (p.left != null)
                l = FindMaximumOnLevel(p.left, level);
            else
                return FindMaximumOnLevel(p.right, level);
            if (p.right != null)
            {
                Node r = FindMaximumOnLevel(p.right, level);
                if (l == null)
                    return r;
                else if (r == null)
                    return l;
                return (l.key > r.key) ? l : r;
            }
            else
                return l;
        }


        private int FindMinimalLeaf(Node p)
        {
            if (p.isLeaf)
                return p.key;
            int l;
            if (p.left != null)
                l = FindMinimalLeaf(p.left);
            else
                return FindMinimalLeaf(p.right);
            if (p.right != null)
            {
                int r = FindMinimalLeaf(p.right);
                return (l < r) ? l : r;
            }
            else
                return l;
        }

        public void Obhod2(Node k) // снятие признака посещения 
        {
            if ((k.left == null) && (k.right == null))
            {
                //Delete k;
                return;
            }
            Obhod2(k.left);
            Obhod2(k.right);
        }
    }
}
    /*if (p != null)
    {
        if (p.isLeaf)
        {
            if (answer)
            {
                minimal = p.key;
                answer = false;
            }
            else
            {
                if (p.key < minimal)
                    minimal = p.key;
            }
        }
        FindMinimalLeaf(p.left);
        FindMinimalLeaf(p.right);
    }
    return minimal;*/
    // }



    //private bool FIndMaximumOnLevel(Node p, int l, int level, out int max)
    //{
    //    max = 5;
    //    return false;
    //}

    //private int FindMaximumOnLevel(Node top, int l)
    //{
    //    if (top != null)
    //    {
    //        if (top.level == l)
    //        {
    //            if (answer2)
    //            {
    //                maximum = top.key;
    //                answer2 = false;
    //            }
    //            else
    //            {
    //                if (top.key > maximum)
    //                    maximum = top.key;
    //            }
    //        }
    //        FindMaximumOnLevel(top.left, l);
    //        FindMaximumOnLevel(top.right, l);
    //    }
    //    return maximum;
    //}





































    //    public void Search(int val)  // поиск и вставка
    //public Node FindNode(int x, int y)  //// поиск по координатам
    //Node FindNodeVal(int val)//поиск по значению
    //public void Insert(object data, int x, int y) // вставка
    //void DeSelect() //снятие признака посещения
    //public void Delta(Node p, int dx, int dy)
    //// смещение поддерева
    //public void Delete(Node p)   // удаление узла
    //public void Draw()
    
//public int GetMinimalLeaf()
//{

//    return FindMinimalLeaf(top);
//}

//private void FindMinimalLeaf(Node top)
//{
//    int minimal = 0;
//    if (top != null)
//    {
//        if (top.leaf == true)      /// =
//        {
//            Array.Resize(ref leafsmassive, ++i);
//            leafsmassive[i - 1] = top.key;
//            s += top.key + " ";
//        }
//        FindMinimalLeaf(top.left);
//        FindMinimalLeaf(top.right);
//}




//public int GetMinimalLeaf(int[] leafmassive)
//{

//    int min = leafsmassive[0];
//    for (int i = 1; i < leafsmassive.Length; i++)
//    {
//        if (leafsmassive[i]>min)
//        {
//            min = leafsmassive[i];
//        }
//    }
//    return min;
//}
//public void GetLevelMassive(Node k, int o)//////////////////////////////////////////
//{
//    if (k != null)
//    {
//        if (k.level == o)      // 
//        {
//            Array.Resize(ref levelmassive, ++il);
//            levelmassive[il - 1] = k.key;
//            sl += k.key + " ";
//        }
//        GetLevelMassive(k.left, o);
//        GetLevelMassive(k.right, o);
//    }
//}


//public void GetLeafsMassive(Node k)
//{
//    if (k != null)
//    {
//        if (k.leaf == true)      /// =
//        {
//            Array.Resize(ref leafsmassive, ++i);
//            leafsmassive[i-1] = k.key;
//            s += k.key + " ";
//        }
//    GetLeafsMassive(k.left);
//    GetLeafsMassive(k.right);
//    }
//}
//public string Leafs
//{
//    get { return s; }
//}
//public string LevelElemets
//{
//    get { return sl; }
//}
//private int FindMaximumOnLevel(Node top,int l)
//{
//    if (top != null)
//    {
//        if (top.level == l)
//        {
//            maximum = top.key;
//        }
//        FindMaximumOnLevel(top.left,l);
//        FindMaximumOnLevel(top.right,l);
//    }
//    return maximum;
//}