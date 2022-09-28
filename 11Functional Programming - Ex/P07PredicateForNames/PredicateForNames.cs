using System;
using System.Collections.Generic;
using System.Linq;

namespace P07PredicateForNames
{
    internal class PredicateForNames
    {
        static void Main(string[] args)
        {
            //4
            //Kurnelia Qnaki Geo Muk Ivan

            Action<List<string>> print = p => Console.WriteLine(string.Join("\n", p));

            int length = int.Parse(Console.ReadLine());

            string[] inputNames = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Predicate<string> namesLenght = name => name.Length <= length;
            List<string> result = new List<string>();

            foreach (var name in inputNames)
            {
                if (namesLenght(name))
                {
                    result.Add(name);
                }
            }            

            print(result);
        }
    }
}
