using System;

namespace StringElementSearch
{
     //24.Дана строка. Найти слова, которые имеют четную длину и начинаются с заданного символа.
     
    class Utils
    {
       public static string Search(string s1, string s2, int value)
        {
            int j = 0;
            int k = 0;
            string s3 = "";
            string word;
            for (j=0; j<s1.Length;j++)
            {
                if ((s1[j] != Convert.ToChar(s2)))
                {
                    do
                    {
                        ++j;
                    }
                    while (j<s1.Length && s1[j] != ' '); 
                }
                else
                {
                    word = "";
                    while (j < s1.Length && s1[j] != ' ')
                    {
                        word +=s1[j];
                        ++j;
                    }
                    if (word.Length%2==0)
                    {
                        s3+=word+" ";
                        k = k + 1;
                    }
                }
            }
            
            if (s3 == "")
            {
                return s3 = "Program cant find targeted Elements";
            }
            else
            {
                return s3;
            }

        }
    }
}