using System;
using System.IO;
using System.Text;

namespace WindowSurnameSorter
{
    class Sorter
    {
        public static MyQueue AddSurname(MyQueue que, string f)
        {
            bool answer = true;
            int k = que.Count;
            for (int i = 0; i < k; i++)
            {
                string z = que.Dequeue();
                if ((String.Compare(z,f)>0) && (answer))
                {
                    que.Enqueue(f);
                    answer = false;
                }
                que.Enqueue(z);
            }
            if (answer)
                que.Enqueue(f);
            return que;
        }
        public static MyQueue FormList(string s)
        {
            MyQueue q = new MyQueue();
            Encoding enc = Encoding.GetEncoding(1251);
            FileStream file = new FileStream(s, FileMode.Open);
            StreamReader ReadText = new StreamReader(file,enc);
            string z = ReadText.ReadLine();
            while (z != null)
            {
                q.Enqueue(z);
                z = ReadText.ReadLine();
            }
            ReadText.Close();
            file.Close();
            return q;
        }
    }
}
