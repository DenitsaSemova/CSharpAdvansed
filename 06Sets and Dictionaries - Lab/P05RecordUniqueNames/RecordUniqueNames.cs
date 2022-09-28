using System;
using System.Collections.Generic;
using System.Linq;

namespace P05RecordUniqueNames
{
    internal class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int namesCoun = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < namesCoun; i++)
            {
                var entry = Console.ReadLine();

                names.Add(entry);
            }

            Console.WriteLine();

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
