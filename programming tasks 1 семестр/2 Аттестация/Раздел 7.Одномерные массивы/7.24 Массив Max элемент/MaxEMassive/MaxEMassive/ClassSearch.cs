namespace MaxEMassive
{
    class Utils
    {
        public static int SearchElementMassive(int[] arr)
        {  
            int max = arr[0];
            for (int o=1; o<arr.Length; o++)
            {
                if (arr[o] > max)
                {
                    max = arr[o];
                }
            }
            return max;
        }
        public static int SearchElementPosition(int[] arr)
        {
            //int max = SearchElementMassive(arr);
            int max = arr[0];
            int k = 0;
            for (int o = 1; o < arr.Length; o++)
            {
                if (arr[o] > max)
                {
                    max = arr[o];
                    k = o;
                }
            }
            return k;
           
        }
    }
}
