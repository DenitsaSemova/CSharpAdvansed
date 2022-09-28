using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03CustomMinFunction
{
    internal class CustomMinFunction
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> minFunc = n => n.Min();
            Action<int> print = p => Console.WriteLine(p);

            var number = minFunc(numbers);

            print(number);

            //Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Min());
            
        }
    }
}