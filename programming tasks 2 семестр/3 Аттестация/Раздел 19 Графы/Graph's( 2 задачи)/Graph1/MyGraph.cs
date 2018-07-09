using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing.Drawing2D;

namespace Graph1
{
    [Serializable]
    public class Graph         //граф
    {
        private List<GNode> Nodes = new List<GNode>(); // массив узлов

        private int r = 10; // для рисования
        private GNode selected = null; // для выделения

        //private int way = 0;
        //private int summ = 0;
        //private int helper = 0;

        [Serializable]
        public class GNode           //узелок графа
        {
            public int x;
            public int y;
            public string inf;   //информация
            public string name;  // имя узелка
            public List<GEdge> Edge = new List<GEdge>(); // массив ребер узелка
            public bool visit = false;   // признак посещенности
            public bool pereferia =false;
            //public int way = 0;     

            public GNode(int x, int y, string inf, string name)
            {
                this.x = x;
                this.y = y;
                this.name = name;
                this.inf = inf;
            }
        }

        [Serializable]
        public class GEdge           //ребро графа
        {
            public int weight;     //вес ребра
            public int number;      // номер ребра
            public GNode first;    // откуда вышло
            public GNode second;  // куда вошло
            public bool dual;
            //public bool visit = false;
            public GEdge(GNode first, GNode second)
            {
                this.first = first;
                this.second = second;
            }

        }

        public Graph OpenFile(string filename)  // открыть граф с файла
        {
            Graph g;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream filestream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                g = (Graph)formatter.Deserialize(filestream);
            }
            return g;
        }
        public void SaveFile(string filename, Graph a)  //сохранить граф в файл
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, a);
            }
        }

        public string ReturnNodesString()  // вернуть текущие существующие узлы графа
        {
            string result = null;
            for (int i = 0; i < Nodes.Count; i++)
                result += Nodes[i].name + " ";
            return result;
        }
        public string ReturnEdgesString()  //вернуть текущие ребра графа
        {
            string result = null;
            for (int i = 0; i < Nodes.Count; i++)
                for (int j = 0; j < Nodes[i].Edge.Count; j++)
                    result += "(" + Nodes[i].Edge[j].first.name.ToString() + ":" + Nodes[i].Edge[j].second.name.ToString() + ")[" + Nodes[i].Edge[j].weight.ToString() + "]";
            return result;
        }

        public void CleanSelected()
        {
            selected = null;
        }

        public void Draw(Graphics g, bool isEllipse)
        {
            Font a = new Font("Times New Roman", 12);
            Font b = new Font("Times New Roman", 8);
            Random rnd = new Random();
            for (int i = 0; i < Nodes.Count; i++)
            {
                for (int j = 0; j < Nodes[i].Edge.Count; j++)
                {
                    if (Nodes[i].Edge[j].first == Nodes[i].Edge[j].second)
                    {
                        g.DrawEllipse(Pens.Black, Nodes[i].x, Nodes[i].y, 30, 30); // петля
                    }
                    g.DrawLine(Pens.Black, Nodes[i].Edge[j].first.x, Nodes[i].Edge[j].first.y, Nodes[i].Edge[j].second.x, Nodes[i].Edge[j].second.y);
                    g.DrawString(Nodes[i].Edge[j].weight.ToString(), b, Brushes.Black, (Nodes[i].Edge[j].first.x + Nodes[i].Edge[j].second.x) / 2, (Nodes[i].Edge[j].first.y + Nodes[i].Edge[j].second.y) / 2);
                }

            }
            for (int i = 0; i < Nodes.Count; i++)
            {
                var p = GetXYByIndex(i);
                if (!isEllipse) // квадраты - узлы
                {
                    g.FillRectangle(((Nodes[i] == selected) || (Nodes[i].visit)) ? Brushes.Black : Brushes.IndianRed, p.X - r, p.Y - r, 2 * r, 2 * r);
                    g.DrawRectangle(Pens.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
                }
                else  // кружки - узлы
                {
                    g.FillEllipse((Nodes[i] == selected) ? Brushes.Black : Brushes.IndianRed, p.X - r, p.Y - r, 2 * r, 2 * r);
                    g.DrawEllipse(Pens.Black, p.X - r, p.Y - r, 2 * r, 2 * r);

                }
                if (Nodes[i].pereferia)
                    g.FillEllipse( Brushes.Blue, p.X - r, p.Y - r, 2 * r, 2 * r);
                g.DrawString(Nodes[i].name, a, Brushes.Beige, p.X - r, p.Y - r);
            }
        }


        public void AddNode(string name, string inf, int x, int y) // добавить узелок в массив узелков
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].name == name)
                    throw new Exception("Node with this name already exist");
                if ((x - 2 * r <= Nodes[i].x) && (Nodes[i].x <= x + 2 * r) && (y - 2 * r <= Nodes[i].y) && (Nodes[i].y <= y + 2 * r))// не наезжают друг на друга
                    throw new Exception("Node already exist at this location");
            }
            GNode n = new GNode(x, y, inf, name);
            Nodes.Add(n);
        }

        public void AddEdge(int f, int s, int val)  //добавить ребро через индексы узлов
        {
            GEdge e = new GEdge(Nodes[f], Nodes[s]);
            e.weight = val;
            Nodes[f].Edge.Add(e);
            //Nodes[s].Edge.Add(e);//ошибка при выводе,достаточно хранить в одной
        }
        public void AddEdgeClick(bool flag, int x, int y, int val)     //добавить ребро по клику 
        {
            GNode selected2 = GetGnodeByXY(x, y);
            if (selected2 == null)
                return;
            if (selected == null)
            {
                selected = selected2;
            }
            else
            {
                GEdge e = new GEdge(selected, selected2);
                e.weight = val;
                selected.Edge.Add(e);
                if (!flag)   // undirected - два пути туда обратно
                {
                    GEdge f = new GEdge(selected2, selected);  // двусторонняя дорога
                    f.weight = val;
                    //selected.Edge.Add(f);
                    selected2.Edge.Add(f);
                }
                selected = null;
            }
        }

        public void NodeDeleteByXY(int x, int y)                // удалить узелок по координатам
        {
            GNode a = GetGnodeByXY(x, y);
            if (a == null)
                return;
            else
            {
                for (int i = 0; i < Nodes.Count; i++)
                {
                    for (int j = 0; j < Nodes[i].Edge.Count; j++)
                    {
                        if ((Nodes[i].Edge[j].first == a) || (Nodes[i].Edge[j].second == a))
                        {
                            Nodes[i].Edge.Remove(Nodes[i].Edge[j]);
                            --j;
                        }
                    }

                }
                for (int o = 0; o < a.Edge.Count; o++)
                {
                    a.Edge.Remove(a.Edge[o]);
                    --o;
                }
                Nodes.Remove(a);
            }
        }

        public void EdgeDelete(int x, int y) //удалить ребра между двумя узлами
        {
            GNode a = GetGnodeByXY(x, y);
            if (a == null)
            {
                return;
            }
            if (selected == null)
            {
                selected = a;
                return;
            }
            else
            {
                for (int i = 0; i < selected.Edge.Count; i++)
                {
                    if ((selected.Edge[i].first == a) || (selected.Edge[i].second == a))
                    {
                        selected.Edge.Remove(selected.Edge[i]);
                        --i;
                    }
                }
                for (int j = 0; j < a.Edge.Count; j++)
                {
                    if ((a.Edge[j].first == selected) || (a.Edge[j].second == selected))
                    {
                        a.Edge.Remove(a.Edge[j]);
                        --j;
                    }
                }
            }
            selected = null;
        }

        public void NodeMoveByXY(int x, int y)   // передвинуть выделенный узелок на координаты
        {
            GNode a = GetGnodeByXY(x, y);
            if (a != null)
            {
                selected = a;
                return;
            }
            if (selected != null)
            {
                for (int i = 0; i < Nodes.Count; i++)
                {
                    if ((x - 2 * r <= Nodes[i].x) && (Nodes[i].x <= x + 2 * r) && (y - 2 * r <= Nodes[i].y) && (Nodes[i].y <= y + 2 * r))// не наезжают друг на друга
                        throw new Exception("Node already exist at this location");
                }
                selected.x = x;
                selected.y = y;
                selected = null;
            }
        }
        public void NodeExchange(int x, int y)  // обменяться внутренней информацией
        {
            GNode a = GetGnodeByXY(x, y);
            if (a == null)
            {
                return;
            }
            if (selected == null)
            {
                selected = a;
                return;
            }
            if (selected != null)
            {
                GNode b = new GNode(0, 0, null, null);
                b.x = selected.x;
                b.y = selected.y;
                b.inf = selected.inf;
                //b.name = selected.name;
                selected.x = a.x;
                selected.y = a.y;
                selected.inf = a.inf;
                //selected.name = a.name;
                a.x = b.x;
                a.y = b.y;
                a.inf = b.inf;
                //a.name = b.name;
                selected = null;
            }
        }


        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private GNode GetGnodeByXY(int x, int y)  //получить узел по координатам
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if ((x - r <= Nodes[i].x) && (Nodes[i].x <= x + r) && (y - r <= Nodes[i].y) && (Nodes[i].y <= y + r))
                    return Nodes[i];
            }
            return null;
        }

        public Point GetXYByName(string name)       //получить координаты(структура точка) узла по имени
        {
            GNode n = Nodes[GetNodeIndexByName(name)];
            return new Point(n.x, n.y);
        }

        public Point GetXYByIndex(int index)         //получить координаты(структура точка) узла по индексу
        {
            GNode n = Nodes[index];
            return new Point(n.x, n.y);
        }

        public string GetNodeInformationByIndex(int index)  //получить информацию узла по индексу
        {
            return (Nodes[index].inf);
        }

        public string GetNodeInformationByName(string name)     //получить информацию узла по имени
        {
            return (Nodes[GetNodeIndexByName(name)].inf);
        }

        public int GetNodeIndexByName(string name)      //получить индекс узла по имени
        {
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].name == name)
                    return i;
            }
            throw new Exception("No node");
        }

        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public List<List<GNode>> Result = new List<List<GNode>>();
        public List<GNode> Way = new List<GNode>();

        public void FindWay(int N)
        {
            Visiter();    // отметить все непосещёнными
            Obhod(Nodes[0]);   // обход с первого узелка, тк должно доходить из любой вершины
            for (int j = 0; j < Nodes.Count; j++)
            {
                if (!Nodes[j].visit)  // хотя бы где то не посещено
                {
                    throw new Exception("Cant find way from 1 node to other.");
                }
            }
            Visiter();
            Result = new List<List<GNode>>();
            FindWay(Nodes[0], null, 0, N);

        }

        private bool AllVisited()
        {
            bool answer = true;  // посещены ли все 
            for (int i = 0; i < Nodes.Count; i++)
            {
                if (Nodes[i].visit == false)
                    answer = false;
            }
            return answer;
        }
        private void FindWay(GNode a, GNode previous, int summ, int N)
        {
            a.visit = true;
            Way.Add(a);
            for (int i = 0; i < a.Edge.Count; i++)
            {
                if (a.Edge[i].second == previous)
                    continue;
                if (a.Edge[i].second == Way[0])
                {
                    if (AllVisited())
                    {
                        //a.visit = false;
                        //Way.Remove(a);
                        Result.Add(new List<GNode>(Way));
                        //Result.Add(Way);
                        //Way = new List<GNode>();
                    }

                }
                else
                {
                    if (!a.Edge[i].second.visit)
                    {
                        if ((summ + a.Edge[i].weight) <= N)
                            FindWay(a.Edge[i].second, a, summ + a.Edge[i].weight, N);
                    }
                }
            }
            a.visit = false;
            Way.Remove(a);
        }



        List<string> res = new List<string>();
        public string[] ReturnWaysResult()
        {
            if (Result.Count == 0)
                throw new Exception("No ways in this graph");
            string a = null;
            for (int i = 0; i < Result.Count; i++)
            {
                a += (i + 1).ToString() + " way : ";
                for (int j = 0; j < Result[i].Count; j++)
                {
                    //a += Result[i][j].name + "->";
                    if (j == Result[i].Count - 1)
                        a += Result[i][j].name + "->" + Result[i][0].name;
                    else
                        a += Result[i][j].name + "->";
                }
                a += "\r\n";
                res.Add(a);
                a = null;
            }
            return res.ToArray();

        }

        /// <summary>////	Задана система двусторонних дорог. N-периферией называется множество городов, расстояние от которых до выделенного города больше N. Определить N-периферию для заданного N.

        public void Pereferia(string name, int N)
        {
            Visiter();    // отметить все непосещёнными
            Obhod(Nodes[GetNodeIndexByName(name)]);   // обход с первого узелка, тк должно доходить из любой вершины
            for (int j = 0; j < Nodes.Count; j++)
            {
                if (!Nodes[j].visit)  // хотя бы где то не посещено
                {
                    throw new Exception("Cant find way from"+ Nodes[GetNodeIndexByName(name)].name + "node to other.");
                }
            }
            Visiter();
            Pereferia(Nodes[GetNodeIndexByName(name)], 0,N);
        }
        

         private void Pereferia(GNode a, int length,int N)
         {
            a.visit = true;
            if (length > N)
                a.pereferia = true;

            for (int i=0;i<a.Edge.Count;i++)
            {
                if ((!a.Edge[i].second.visit)&&(a.Edge[i].second!=a))
                    Pereferia(a.Edge[i].second, length + a.Edge[i].weight, N);
            }
         }









        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public int i;
        public GNode current = null;
        public int FindMinimalCycle()
        {
            i = -1;
            for (int i = 0; i < Nodes.Count; i++)
            {
                current = Nodes[i];
                FindMinimalCycle(Nodes[i],0);
            }
            if (i == -1)
                throw new Exception("No cycles here");
            return i;
        }

        private void FindMinimalCycle(GNode a, int length)
        {
            a.visit = true;
            for (int k = 0; k < a.Edge.Count; k++)
            {
                if (a.Edge[k].second == current)
                {
                    length += a.Edge[k].weight;
                    if ((i == -1)|| (length < i))
                        i = length;
                }
                else
                {
                    if (!a.Edge[k].second.visit)
                    {
                        FindMinimalCycle(a.Edge[k].second, length + a.Edge[k].weight);
                    }
                }
            }
            a.visit = false;
        }







        //if (a.Edge[i].second == Way[0])
        //{
        //    if ((i == -1) || (length < i))
        //        i = length;

        //}
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public bool isConnected()   //вернуть ответ - связанный ли граф
        {
            Visiter();    // отметить все непосещёнными
            bool answer = true;
            for (int o = 0; o < Nodes.Count; o++)
            {
                Obhod(Nodes[o]);   // обход с первого узелка, тк должно доходить из любой вершины
                for (int j = 0; j < Nodes.Count; j++)
                {
                    if (!Nodes[j].visit)  // хотя бы где то не посещено
                    {
                        answer = false;
                        break;
                    }
                }
                Visiter();
            }
            return answer;
        }
        public void Visiter()  // пометить все узлы графа непосещёнными
        {
            for (int i=0;i<Nodes.Count;i++)
            {
                Nodes[i].visit = false;
            }

        }
        private void Obhod(GNode a)   //обойти граф
        {
            if ((a.visit != true))
            {
                a.visit = true;
                for (int i = 0; i < a.Edge.Count; i++)
                {
                    Obhod(a.Edge[i].second);
                    //Obhod(a.Edge[i].first);
                }
            }
        }

    }
}




















//if (i== Result[j].Count-1)
//    a+= Result[i].
//if (i == WaysResult[i].WaysResult[j].Count - 1)
//    a += WayResult[i].name + "->" + WayResult[0].name;
//else
//    a += WayResult[i].name + "->";



//private void FindWay(GNode b, GNode prev, int summ)
//{
//    if (summ >= way)
//        return;
//    if ((b.visit ==true ) && (b == Nodes[0]))
//        throw new Exception("Cycle here.");
//    else
//    {
//        b.visit = true;
//        helper++;
//        for (int i = 0; i < b.Edge.Count; i++)
//        {
//            summ += b.Edge[i].weight;
//            if (b.Edge[i].second == Nodes[0])
//            {
//                FindWay(b.Edge[i].second);
//            }
//            else
//            {
//                if (!b.Edge[i].second.visit)
//                {
//                    FindWay(b.Edge[i].second);
//                }
//            }
//        }
//        if (helper == Nodes.Count)
//            throw new Exception("All Nodes visited, no cycle here.");
//    }
//}
//public void GetWay(int way)
//{
//    this.way = way;
//}


//public void Visiter(int a)
//{
//    Visiter();
//}
//private int WayLength(int index)
//{
//    int way = 0;
//    for (int i = 0;i<Result[index].Count;i++)
//    {
//        way+=Result[index][i].
//    }
//    return way;
//}
//if (summ > N)  // сумма путей превысила заданное
//{
//    a.visit = false;
//    WayResult.Remove(a);
//    return;
//}
/*if ((AllVisited())&&(a==WayResult[0]))
{
    return; // замкнутый цикл
}*/
//prev = a;
/*
                    if (!(a.Edge[i].second == WayResult[0]))
                {
                    if (summ + a.Edge[i].weight <= N)
                    {
                        if (!a.Edge[i].second.visit)
                            FindWay(a.Edge[i].second, a, summ + a.Edge[i].weight, N);
                    }
                    //else
                    //{
                    //    return;
                    //}
                }
                else
                {
                    return;
                }*/

//if (!AllVisited())
//     throw new Exception("No cicle's here.");



//public string ReturnWaysResult()
//{
//    string a = null;
//    if (Way.Count<3)
//        throw new Exception("No ways in this graph");
//    for (int i=0;i<Way.Count;i++)
//    {
//        if (i == Way.Count - 1)
//            a += Way[i].name + "->" + Way[0].name;
//        else
//            a += Way[i].name + "->";
//    }
//    return a;
//}
//Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
//pen.StartCap = LineCap.ArrowAnchor;
//pen.EndCap = LineCap.RoundAnchor;


//g.FillEllipse(Brushes.Violet, GetXYByIndex(i).X, GetXYByIndex(i).Y, 20, 20);
// g.DrawEllipse(Pens.Black, GetXYByIndex(i).X, GetXYByIndex(i).Y, 20, 20);
//Random rnd = new Random();
//n.x = rnd.Next(0, 940);
//n.y = rnd.Next(0, 190);
//n.x = x;
//n.y = y;
//n.name = name;
//n.inf = inf;
//g.DrawEllipse(Pens.Blue,)
//g.FillEllipse(Brushes.Aqua, GetXByName(name), GetYByName(name), 20, 20);
//g.DrawEllipse(Pens.Black, GetXByName(name), GetYByName(name), 20, 20);


/*public int GetXLocationByName(string name)
{
    return (Nodes[GetNodeIndexByName(name)].x);
}

public int GetYLocationByName(string name)
{
    return (Nodes[GetNodeIndexByName(name)].y);
}*/

//public int GetXByName(string name)
//{
//    GNode n = Nodes[GetNodeIndexByName(name)];
//    return n.x;
//}

//public int GetYByName(string name)
//{
//    GNode n = Nodes[GetNodeIndexByName(name)];
//    return n.y;
//}

//n.x = rnd.Next(0, 940);
//n.y = rnd.Next(0, 190);
//n.x = x;
//n.y = y;
//n.name = name;
//n.inf = inf;











/*
            //public GNode[] Nodes = new GNode[0];
            //int l = Nodes.Length;
            //Array.Resize(ref Nodes, ++l);
            //Nodes[l - 1] = new GNode();
            //Nodes[l - 1].name =  (l - 1).ToString()+" node";*/








// try
//{
//GNode from = Nodes[f];
//GNode inn = Nodes[s];

//int i1 = Nodes[f].Edge.Length;
//Array.Resize(ref Nodes[f].Edge, ++i1);
//Nodes[f].Edge[i1 - 1] = new GEdge(Nodes[f], Nodes[s]);
//int i2 = Nodes[s].Edge.Length;
//Array.Resize(ref Nodes[s].Edge, ++i2);
//Nodes[s].Edge[i2 - 1] = new GEdge(Nodes[f], Nodes[s]);
//}
//catch throw new Exception("");








/*
 namespace Graph1
{
        public class Graph         //граф
        {
            const int hx = 50, hy = 10;
            public Bitmap bitmap;
            public GNode[] Nodes = new GNode[0]; // массив узлов
            public static GNode SelectNode;      //выделенный узел
            public static GNode SelectNodeBeg;
            public byte typ_graph = 1;
            public int[,] A;                   // матрица инцидентности


            public bool isConnected()
            {
                MyStack a = new MyStack();
               // int i = 1;
                for (int j=0;j<Nodes.Length;j++)
                {



                }
                return (a.getCount() == Nodes.Length);
            }
        }
        
        public class GNode           //узелок графа
        {
            public string name;  // имя узла
            public GEdge[] Edge; // массив дуг (ребер)
            public bool visit;   // признак "узел посещен"
            public int x0, y0;   // координаты центра узла
            public int numVisit; // № посещения
            public Color color;  // цвет узла
            public int dist;     // минимальное расстояние
        }


        public struct GEdge           //ребро графа
        {
            public int A;            //
            public int numNode;      //
            public int x1c, x2c, yc; //
            public Color color;
            public bool select;
        }
        
    }
*/
