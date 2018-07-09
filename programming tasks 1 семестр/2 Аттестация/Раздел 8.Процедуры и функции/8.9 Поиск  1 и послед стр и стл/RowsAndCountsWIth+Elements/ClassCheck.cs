using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsAndCountsWIth_Elements
{
    /*8.9.Дана матрица размера n * m. 
          Вывести номер ее первой1|последней2 строки3|столбца4, 
          содержащего только положительные элементы. Если таких строк3|столбцов4 нет, то вывести 0.
     */
    class ClassCheck
    {
        public static int FindFirstRow(int[,] matrix)
        {
            int rc = matrix.GetLength(0);
            int cc = matrix.GetLength(1);
            bool flag;
            for (int x=0;x<rc;x++)
            {
                flag = true;
                for (int y = 0; y < cc; y++)
                {
                    if (matrix[x,y]<0)
                    {
                        flag = false;
                        break;
                    } 
                }

                if (flag)
                {
                    return x+1;
                }
            }
            return 0;
        }
        public static int FindFirstColumn(int[,] matrix)
        {
            int rc = matrix.GetLength(0);
            int cc = matrix.GetLength(1);
            bool flag;
            for (int y = 0; y < cc; y++)
            {
                flag = true;
                for (int x = 0; x < rc; x++)
                {
                    if (matrix[x, y] < 0)
                    {
                        flag = false;
                        break;
                    }
                }
                    if (flag)
                    {
                        return y+1;
                    }
            }
             return 0; 
        }
        
        public static int FindLastRow(int[,] matrix)
        {
            int rc = matrix.GetLength(0);
            int cc = matrix.GetLength(1);
            bool flag;
            for (int x = rc-1; x >= 0; x--)
            {
                flag = true;
                for (int y = 0; y < cc; y++)
                {
                    if (matrix[x, y] < 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    return x+1;
                }
            }
            return 0;
        }
        public static int FindLastColumn(int[,] matrix)
        {

            int rc = matrix.GetLength(0);
            int cc = matrix.GetLength(1);
            bool flag;
            for (int y = cc-1; y >=0; y--)
            {
                flag = true;
                for (int x = 0; x < rc; x++)
                {
                    if (matrix[x, y] < 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    return y+1;
                }
            }
            return 0;
        }
    }
}
