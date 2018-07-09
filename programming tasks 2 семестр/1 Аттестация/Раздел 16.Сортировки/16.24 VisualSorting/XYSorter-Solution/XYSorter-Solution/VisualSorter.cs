using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace XYSorter_Solution
{
    class VisualSorter
    { 
        public static Pen q = Pens.Black;
        public static void Compare(Graphics g, Number[] a)
        {
            int lct = 0;
            //int c1 = 0, c2 = 0;
            int[] c = new int[a.Length];
            for (int j = 0; j < a.Length; j++)
            {
                Number f = a[j];
                g.DrawString("Comparing " + (j + 1) + " element : ", new Font("Times", 11), Brushes.Black, 0, 7);
                //
                g.DrawEllipse(q, 200, 27, 37, 37);
                g.FillEllipse(Brushes.White, 200, 27, 37, 37);          // белый круг
                g.DrawString("c[" + (j+1) + "]", new Font("Times", 15), Brushes.Black, 198, 34); // счетчик 1 левый элемент
                //  
                if (j!=a.Length-1)
                { 
                g.DrawEllipse(q, 200, 64, 37, 37);
                g.DrawString("c[" + (j + 2) + "]", new Font("Times", 15), Brushes.Black, 198, 70);
                }// счетчик 2 правый элемент
                g.DrawEllipse(q, 237, 27, 37, 37); 
                // счетчик 1 правый число
                if (j != a.Length - 1)
                {
                    g.DrawEllipse(q, 237, 64, 37, 37); 
                }//счетчик 2 правый число
                for (int i = j + 1; i < a.Length; i++)
                {
                    Number s = a[i];
                    g.FillEllipse(Brushes.White, 200, 64, 37, 37);      // белый круг
                    g.DrawString("c[" + (i+1) + "]", new Font("Times", 15), Brushes.Black, 198, 70); //перепись второй ячейки
                    //
                    g.DrawEllipse(q, 0, (i - lct) * 27, 25, 25);
                    g.DrawString(f.ch.ToString(), new Font("Times", 15), Brushes.Black, 5, (i - lct) * 27); //левая ячейка f чар
                    //
                    g.DrawEllipse(q, 27, (i - lct) * 27, 25, 25);
                    g.DrawString(f.key.ToString(), new Font("Times", 15), Brushes.Black, 27, (i - lct) * 27);//левая ячейка f число
                    //
                    g.DrawEllipse(q, 72, (i - lct) * 27, 25, 25);
                    g.DrawString(s.ch.ToString(), new Font("Times", 15), Brushes.Black, 77, (i - lct) * 27); //правая ячейка s чар
                    //
                    g.DrawEllipse(q, 97, (i - lct) * 27, 25, 25);
                    g.DrawString(s.key.ToString(), new Font("Times", 15), Brushes.Black, 97, (i - lct) * 27);//правая ячейка s число
                    //
                    g.FillEllipse(Brushes.White, 237, 27, 37, 37);          // белый круг
                    //g.DrawString(c1.ToString(), new Font("Times", 15), Brushes.Red, 247, 34); // ноль счетчика 1
                    g.DrawString(c[j].ToString(), new Font("Times", 15), Brushes.Red, 247, 34); // ноль счетчика 1
                    //
                    g.FillEllipse(Brushes.White, 237, 64, 37, 37);          // белый круг
                    //g.DrawString(c2.ToString(), new Font("Times", 15), Brushes.Red, 247, 71); // ноль счетчика 2
                    g.DrawString(c[i].ToString(), new Font("Times", 15), Brushes.Red, 247, 71); // ноль счетчика 2
                    //
                    Thread.Sleep(700);
                    if (f.key == s.key)
                    {
                        g.DrawString("=", new Font("Times", 15), Brushes.Blue, 55, (i - lct) * 27);
                        Thread.Sleep(700);
                    }
                    if (f.key > s.key)
                    {
                        //c1++;
                        c[j]++;//!!!!!!
                        g.DrawString(">", new Font("Times", 15), Brushes.Purple, 55, (i - lct) * 27);
                        g.FillEllipse(Brushes.White, 237, 27, 37, 37);          // белый круг
                        //g.DrawString(c1.ToString(), new Font("Times", 15), Brushes.Red, 247, 34);
                        g.DrawString(c[j].ToString(), new Font("Times", 15), Brushes.Red, 247, 34);
                        Thread.Sleep(700);
                    }
                    if (f.key < s.key)
                    {
                        //c2++;
                        c[i]++;
                        g.DrawString("<", new Font("Times", 15), Brushes.Red, 55, (i - lct) * 27);
                        g.FillEllipse(Brushes.White, 237, 64, 37, 37);       // белый круг
                        // g.DrawString(c2.ToString(), new Font("Times", 15), Brushes.Red, 247, 71);
                        g.DrawString(c[i].ToString(), new Font("Times", 15), Brushes.Red, 247, 71);
                        Thread.Sleep(700);
                    }
                    Thread.Sleep(1500);
                }
                if (j == a.Length-1)
                {// c1
                    g.DrawString(c[j].ToString(), new Font("Times", 15), Brushes.Red, 247, 34);
                }
                Thread.Sleep(1500);
                lct++;
                g.Clear(Color.White);
            }
        }
        public static void VisualPrinter(Graphics g, Number[] a)
        {
            g.Clear(Color.White);
            Pen q = Pens.Black;
            for (int i = 0; i < a.Length; i++)
            {
                g.DrawEllipse(q, 27, i * 30, 25, 25);
                g.DrawString(a[i].key.ToString(), new Font("Times", 15), Brushes.Black, 27, i * 30);
                g.DrawEllipse(q, 0, i * 30, 25, 25);
                g.DrawString(a[i].ch.ToString(), new Font("Times", 15), Brushes.Black, 0, i * 30);
                Thread.Sleep(500);
            }
        }
    }
}
