using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYSorter_Solution
{
    class Sorter
    {
        public static Number[] SpecialSort(Number[] a)
        {

            int N = a.Length;
            int[] c = new int[N];           //вспомогательный массив нулей
            Number[] b = new Number[N];      //результирующий массив 
            for (int i = 0; i < N; i++)
            {
                c[i] = 0;
                b[i] = new Number();
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                 if (a[i].key > a[j].key)
                    {
                        c[i] = c[i] + 1;
                    }
                    else
                    {
                        c[j] = c[j] + 1;
                    }
            }
            for (int i = 0; i < N; i++)
            {
                //b[c[i]].key= a[i].key;
                //b[c[i]].ch = a[i].ch;
                b[c[i]] = a[i];
            }
            //for (int i = 0; i < N; i++) //  не меняем массив исходный а
            //{
            //    a[i] = b[i];
            //}
            return b;
        }

        /* 
         В этом варианте помимо входного массива A потребуется два вспомогательных массива — C[0..k - 1] для счётчика и B[0..n - 1] 
для отсортированного массива. Сначала следует заполнить массив C нулями, и для каждого A[i] увеличить C[A[i]] на 1. 
Далее подсчитывается количество элементов меньших или равных {\displaystyle k-1} k-1. 
Для этого каждый C[j], начиная с C[1], увеличивают на C[j - 1]. 
Таким образом в последней ячейке будет находиться количество элементов от {\displaystyle 0} {\displaystyle 0} до {\displaystyle k-1} 
k-1 существующих во входном массиве. На последнем шаге алгоритма читается входной массив с конца, значение C[A[i]] уменьшается на 1 и в 
каждый B[C[A[i]]] записывается A[i]. Алгоритм устойчив.

StableCountingSort
for i = 0 to k - 1
    C[i] = 0;
for i = 0 to n - 1
    C[A[i]] = C[A[i]] + 1;
for j = 1 to k - 1
    C[j] = C[j] + C[j - 1];
for i = n - 1 to 0
    C[A[i]] = C[A[i]] - 1;
    B[C[A[i]]] = A[i];
    */

        
        
    }
}
