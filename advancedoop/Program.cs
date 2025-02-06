namespace advancedoop
{
    internal class Program

    {
        public static void OptimizedBubbleSort(int[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        static void Main(string[] args)
        {
            #region bubble sort
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            OptimizedBubbleSort(array);
            Console.WriteLine("Sorted array: " );
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("//////////////////////////////////////");

            #endregion



            #region range
            Range<int> intRange = new Range<int>(10, 20);
            Console.WriteLine(intRange.IsInRange(15));
            Console.WriteLine(intRange.Length());  
            #endregion


        }
    }
}