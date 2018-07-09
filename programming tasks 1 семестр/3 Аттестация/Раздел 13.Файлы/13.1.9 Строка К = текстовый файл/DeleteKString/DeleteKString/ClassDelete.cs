using System;
using System.IO;
using System.Text;

namespace DeleteKString
{
    /*
     13.1.9 Дано число k и текстовый файл. 
            Удалить из файла строку с номером k (строки нумеруются от 0). 
            Если строки с таким номером нет, то оставить файл без изменений
     */
    class ClassDelete
    {
        public static void DeleteK(string fname, int k)
        {
            Encoding enc = Encoding.GetEncoding(1251);
            string wr_fname = Path.GetTempFileName();
            FileStream resultfile = new FileStream(wr_fname, FileMode.Create);
            FileStream file = new FileStream(fname, FileMode.Open);
            StreamReader ReadText = new StreamReader(file, enc);
            StreamWriter WriteText = new StreamWriter(resultfile);
            string z;
            z = ReadText.ReadLine();
            int counter = 1;
            while (z != null)
            {
                if (counter != k)
                {
                    WriteText.WriteLine(z);
                }
                z = ReadText.ReadLine();
                counter++;
            }
            ReadText.Close();
            WriteText.Close();
            file.Close();
            resultfile.Close();

            File.Delete(fname);
            File.Move(wr_fname, fname);
        }

        public static void Delete(int x, int y) // y - exception string, x - number of all strings in file, x 1 to number)
        {
            //FileStream file = new FileStream("D:\\firsttextfile.txt", FileMode.Open);
            //StreamReader ReadText = new StreamReader(file);
            //FileStream resultfile= new FileStream("D:\\resulttextfile.txt", FileMode.Create);
            //StreamWriter WriteText = new StreamWriter(resultfile);
            //string z = "";
            //for (int j = 0; j < x - 1; j++)
            //{
            //    z = ReadText.ReadLine();
            //    while (z != null && (x >= 0))
            //    {
            //        if (x != y - 1)
            //        {
            //            WriteText.WriteLine(z);
            //        }
            //        x--;
            //    }
            //}
            //WriteText.Close();
            //ReadText.Close();
            //file.Close();
            //resultfile.Close();
        }
    }
}
