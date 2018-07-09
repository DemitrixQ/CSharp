using System;

namespace StringsTask
{
    /*9.   Пусть даны две строки str1 и str2. Необходимо выяснить, 
           можно ли из str1 путём перестановки литер получить строку str2. 
           Напишите подпрограмму, которая решала бы указанную задачу.*/
    class StringUtils
    {
        public static bool Check2(string s1, string s2)
        {
            int i,z;
            //char[] x = s1.ToCharArray();
            //char[] y = s2.ToCharArray();
            
            //if (s1.Length != s2.Length)
             //return false;

            //for (i = 0; i <= s1.Length - 1; i++)
            for (z = 0; z <= s2.Length - 1; z++) 
            {
                for (i = 0; i <= s1.Length - 1; i++)  //axc xacacxd
                {
                    if (s2[z] != s1[i])
                    {
                        break;
                    }
                }

                if (i == s1.Length)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool Check(string s1, string s2)
        {
            int i;
            char[] x = s1.ToCharArray();
            char[] y = s2.ToCharArray();
            Array.Sort(x);
            Array.Sort(y);
            if (s1.Length != s2.Length)
                return false;
            for (i = 0; i <= s1.Length - 1; i++)
            {
                if (x[i] != y[i])
                    return false;
            }
            return true;
            
            
        }
    }
}
