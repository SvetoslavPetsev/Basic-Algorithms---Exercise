
namespace P06.Quicksort
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            QuickSort(input, 0, input.Length - 1);
            Print(input);
        }

        public static void QuickSort<T>(T[] arr, int start, int end)
            where T : IComparable<T>
        {
            int i = start;
            int j = end;
            int pivotIndex = start + (end - start) / 2;
            T pivotValue = arr[pivotIndex];

            while (i <= j)
            {
                while (arr[i].CompareTo(pivotValue) < 0)
                {
                    i++;
                }
                while (arr[j].CompareTo(pivotValue) > 0)
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }
            if (start < j)
            {
                QuickSort(arr, start, j);
            }

            if (i < end)
            {
                QuickSort(arr, i, end);
            }

        }

        public static void Swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }

}
