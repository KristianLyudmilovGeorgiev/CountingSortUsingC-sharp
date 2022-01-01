using System;

namespace Counting_Sort
{
    class Program
    {
        static int Min(int[] Array)
        {
            int min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (min > Array[i])
                {
                    min = Array[i];
                }
            }
            return min;
        }

        static int Max(int[] Array)
        {
            int max = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (max < Array[i])
                {
                    max = Array[i];
                }
            }
            return max;
        }
        static void Main()
        {
            int[] NeedsSorting = {5,1,4,2,0,3};
            int[] SortedArray = new int[NeedsSorting.Length];
            int min = Min(NeedsSorting);
            int max = Max(NeedsSorting);
            int[] Counter = new int[max - min + 1];

            for (int i = 0; i < NeedsSorting.Length; i++)
            {
                Counter[NeedsSorting[i] - min]++;
            }
            Counter[0]--;

            for (int j = 1; j < Counter.Length; j++)
            {
                Counter[j] += Counter[j - 1];
            }

            for (int h = NeedsSorting.Length - 1; h >= 0; h--)
            {
                SortedArray[Counter[NeedsSorting[h] - min]--] = NeedsSorting[h];
            }

            Console.WriteLine("Sorted collection using Counting Sort: ");
            foreach (int item in SortedArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
