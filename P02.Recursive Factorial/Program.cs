using System;

namespace P02.Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(number));
        }
        public static int Factoriel(int number)
        {

            if (number == 0)
            {
                return 1;
            }

            int result = number * Factoriel(--number);  
            
            return result;
        }
    }
}
