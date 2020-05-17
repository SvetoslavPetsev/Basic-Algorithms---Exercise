namespace _07._Binary_Search
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());
            int index = BinarySearch(input,key, 0, input.Length - 1);
            Console.WriteLine(index);
        }

        public static int BinarySearch<T>(T[] arr, T key, int start, int end)
            where T : IComparable<T>
        {
            while (start <= end)
            {
                int midIndex = start + (end - start) / 2;
                T mid = arr[midIndex];

                if (mid.CompareTo(key) < 0)
                {
                    start = midIndex + 1;
                }
                else if (mid.CompareTo(key) > 0)
                {
                    end = midIndex - 1;
                }
                else
                {
                    return midIndex;
                }
            }
            return -1;
        }
    }
}
