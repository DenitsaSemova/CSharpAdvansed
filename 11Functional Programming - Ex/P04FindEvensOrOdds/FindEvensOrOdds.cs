using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace P04FindEvensOrOdds
{
    internal class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            //1 10
            //odd

            Action<List<int>> print = r => Console.WriteLine(String.Join(" ", r));
            Predicate<int> evensOrOdds = n => n % 2 == 0;
            List<int> result = new List<int>();

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            int start = range[0];
            int end = range[1];

            if (command == "even")
            {
                for (int i = start; i <= end; i++)
                {
                    if (evensOrOdds(i) == true)
                    {
                        result.Add(i);
                    }
                }
            }
            else if (command == "odd")
            {
                for (int i = start; i <= end; i++)
                {
                    if (evensOrOdds(i) == false)
                    {
                        result.Add(i);
                    }
                }
            }

            print(result);

        }
    }
}
