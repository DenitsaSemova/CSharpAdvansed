using System;
using System.Collections.Generic;

namespace P05CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> occurrences = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (occurrences.ContainsKey(text[i]) == false)
                {
                    occurrences.Add(text[i], 1);
                }
                else
                {
                    occurrences[text[i]]++;
                }
            }

            foreach (var chars in occurrences)
            {
                Console.WriteLine($"{chars.Key}: {chars.Value} time/s");
            }
        }
    }
}
