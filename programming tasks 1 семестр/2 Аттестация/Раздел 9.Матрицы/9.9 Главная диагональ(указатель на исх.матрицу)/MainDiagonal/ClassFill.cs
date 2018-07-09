namespace RowsAndCountsWIth_Elements
{
    /* 9.9.Дана вещественная квадратная матрица порядка N. 
          Заменить нулями все ее элементы, расположенные на главной диагонали и выше нее.
    */
    class ClassFill
    {
        public static int[,] FillLRDiagonal(int[,] matrix)
        {
            //int [,] z = new int [,];
            int rc = matrix.GetLength(0);
            int cc = matrix.GetLength(1);
            for (int x=0;x<rc;x++)
            {
                for (int y=x;y<cc;y++)
                {
                    matrix[x,y] = 0;
                }
            }
            return matrix;
        }
        public static int[,] FillRLDiagonal(int[,] matrix)
        {
            int rc = matrix.GetLength(0);
            int cc = matrix.GetLength(1);
            for (int x = 0; x <rc; x++)
            {
                for (int y =0; y <cc-x; y++)
                {
                    matrix[x, y] = 0;
                }
            }
            return matrix;
        }
    }
}
