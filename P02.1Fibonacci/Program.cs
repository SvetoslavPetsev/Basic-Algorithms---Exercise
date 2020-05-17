using System;
using System.Collections.Generic;
using System.Numerics;

namespace P02._1Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(n, new Dictionary<int, BigInteger>()));
        }

        public static BigInteger Fibonacci(int number, Dictionary<int, BigInteger> map)
        {

            if(number <= 0)
            {
                return 0;
            }

            else if (number == 1 || number == 2)
            {
                return 1;
            }

            if (map.ContainsKey(number))
            {
                return map[number];
            }

            BigInteger result = Fibonacci(number - 1, map) + Fibonacci(number - 2, map);
            map.Add(number, result);
            return result;
        }
    }
}
