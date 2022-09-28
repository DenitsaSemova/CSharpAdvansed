using System;
using System.Collections.Generic;
using System.Linq;

namespace P03PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            SortedSet<string> chemicalCompounds = new SortedSet<string>();    

            for (int i = 0; i < n; i++)
            {
                string[] entry = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < entry.Length; j++)
                {
                    chemicalCompounds.Add(entry[j]);
                }
            }

            foreach (var compound in chemicalCompounds)
            {
                Console.Write(compound + " ");
            }

            Console.WriteLine();
        }
    }
}
