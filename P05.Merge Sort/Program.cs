namespace P05.Merge_Sort
{
    using System;
    using System.Linq;

    public class MergeSort<T>
        where T : IComparable
    {
        private T[] arr;
        public MergeSort(T[] array)
        {
            this.arr = array;
        }
        public void Sort(T[] arr, int low, int high)

        {
            int partLength = high - low;
            if (partLength <= 1)
            {
                return;
            }

            int mid = low + partLength / 2;

            Sort(arr, low, mid);
            Sort(arr, mid, high);

            T[] aux = new T[partLength];
            int i = low;
            int j = mid;

            for (int k = 0; k < partLength; k++)
            {
                if (i == mid)
                {
                    aux[k] = arr[j++];
                }
                else if (j == high)
                {
                    aux[k] = arr[i++];
                }
                else if (arr[j].CompareTo(arr[i]) < 0)
                {
                    aux[k] = arr[j++];
                }
                else
                { 
                    aux[k] = arr[i++];
                } 
            }

            for (int k = 0; k < partLength; k++)
            {
                arr[low + k] = aux[k];
            }
        }
        public void Print()
        {
            Console.WriteLine(string.Join(" ", this.arr));
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr = new MergeSort<int>(input);
            arr.Sort(input, 0, input.Length);
            arr.Print();
        }
    }
}
