using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BinaryCheckerTask
{
    /*
   15.39. Создать очередь, информационные поля которой содержат вещественные числа из текстового файла. 
          Для каждого элемента списка определить число отрицательных элементов, следующих за ним.
          Результаты записать в текстовый файл в виде: элемент списка - число последующих отрицательных элементов.
   */
    class ClassListFilling
    {
        public static MyList Fill(string s)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            MyList q = new MyList();
            FileStream file = new FileStream(s, FileMode.Open);
            StreamReader ReadText = new StreamReader(file, enc);
            string z = ReadText.ReadLine();
            while (z != null)
            {
                q.Enqueue(Convert.ToInt32(z));
                z = ReadText.ReadLine();
            }
            ReadText.Close();
            file.Close();
            return q;
        }
        
    }
}
