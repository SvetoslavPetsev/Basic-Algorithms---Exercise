namespace P01.RecursiveArraySum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = GetSumFromArray(arr, 0);
            Console.WriteLine(sum);
        }
        static int GetSumFromArray(int[] arr, int index)
        {

            if (index == arr.Length)
            {
              return 0; 
            }

            int firstNumber = arr[index];

            index++;

            int otherSum = GetSumFromArray(arr,index);

            int result = firstNumber + otherSum;

            return result;
        }
    }
}
