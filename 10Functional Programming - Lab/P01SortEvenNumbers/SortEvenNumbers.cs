using System;
using System.Linq;

namespace P01SortEvenNumbers
{
    internal class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Int32.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)));

            
        }
    }
}
