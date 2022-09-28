using System;
using System.Linq;

namespace P02SumNumbers
{
    internal class SumNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Parse)
                .ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }

        //public static Func<string, int> Parse = n => int.Parse(n);

        public static Func<string, int> Parse = n =>
        {
            int result = 0;

            if (int.TryParse(n, out result))
            {
                return result;
            }

            return 0;
        };
    }
}
