namespace P05.Merge_Sort
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class MergeSort<T> : IEnumerable<T>
        where T : IComparable
    {
        private T[] arr;
        public MergeSort()
        {
            this.arr = new T[0];
        }
        public MergeSort(T[] arr) : this()
        {
            this.arr = arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.arr)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Sort()
        {
            var newArr = new T[this.arr.Length];
            bool chek = true;
            while (chek)
            {
                chek = false;

                for (int i = 0; i < this.arr.Length - 1; i++)
                {
                    var current = this.arr[i];
                    var next = this.arr[i + 1];

                    newArr[i] = current;
                    newArr[i + 1] = next;

                    if (current.CompareTo(next) == 1)
                    {
                        newArr[i] = next;
                        newArr[i + 1] = current;
                        chek = true;
                        i++;
                    }

                    if (i + 1 == this.arr.Length - 1)
                    {
                        newArr[arr.Length - 1] = this.arr[arr.Length - 1];
                        continue;
                    }
                }
                this.arr = newArr;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr = new MergeSort<int>(input);

            arr.Sort();

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
