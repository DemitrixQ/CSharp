using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tree._18._3
{
    public class Node
    {
        public int inf;
        public Node right; 
        public Node left;
        public bool visit = false;
        public Node(int value, Node left1, Node right1)
        {
            inf = value;
            right = right1;
            left = left1;
        }
    }
    public class Tree 
    {
        private Node Top;
        Pen MyPen;
        SolidBrush MyBrush;
        public Bitmap bmp;
        Font MyFont;
        Graphics g;
        const int R = 12, step = 40;
        List<string> outStrings = new List<string>();
        public Tree(int width, int height)
        {
            Top = null;
            bmp = new Bitmap(width, height);
            MyFont = new Font("Arial", 14);
            MyBrush = new SolidBrush(Color.Black);
            g = Graphics.FromImage(bmp);
            MyPen = new Pen(Color.Black);
        }

        public Tree(int Levels)
        {
            GenerateTree(Levels);
        }

        public void GenerateTree(int N)
        {
            if ((N <= 0) || (N % 2 != 0))
                throw new Exception("Неверные введенные данные");
            Top = new Node(0, null, null);
            AddNode(ref Top, N - 1);
        }

        private void AddNode(ref Node t, int Levels)  
        {
            if (t.left == null)
                t.left = new Node(-1, null, null);
            if (t.right == null)
                t.right = new Node(1, null, null);
            if (Levels != 0)
            {
                AddNode(ref t.left, Levels - 1);
                AddNode(ref t.right, Levels - 1);
            }
            else
                return;
        }
        

        public string[] Obhod()
        {
            outStrings = new List<string>();
            Obhod(Top, new int[0]);
            return outStrings.ToArray();
        }

        private void Obhod(Node p, int[] path)
        {
            path = path.Concat(new int[] { p.inf }).ToArray();
            if (p.left == null && p.right == null)
            {
                if (path.Sum() == 0)
                {                    
                    outStrings.Add(path.Select(n => n.ToString()).Aggregate((ar, el) => ar + " " + el));
                }
            }
            else
            {
                Obhod(p.left,path);
                Obhod(p.right,path);
            }
        }

        private void DrawNode(Node p, int l, int r, int y, int ystep)
        {
            int x = (l + r) / 2;
            if (p.left != null)
                g.DrawLine(MyPen, x, y, (x + l) / 2, y + ystep);
            if (p.right != null)
                g.DrawLine(MyPen, x, y, (x + r) / 2, y + ystep);
            g.FillEllipse(Brushes.White, x - R, y - R, 2 * R, 2 * R);
            g.DrawEllipse(MyPen, x - R, y - R, 2 * R, 2 * R);
            g.DrawString(p.inf.ToString(), MyFont, Brushes.Black,
            x - g.MeasureString(Convert.ToString(p.inf), MyFont).Width / 2, y - g.MeasureString(Convert.ToString(p.inf), MyFont).Height / 2);
            if (p.left != null)
                DrawNode(p.left, l, x, y + ystep, ystep);
            if (p.right != null)
                DrawNode(p.right, x, r, y + ystep, ystep);
        }

        public void DrawTree(int l, int r, int y0, int ystep)
        {
            using (g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                if (Top != null)
                    DrawNode(Top, l, r, y0, ystep);
            }
        }
    }
}
