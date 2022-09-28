using System;
using System.Collections.Generic;

namespace P01UniqueUsernames
{
    internal class UniqueUsernames
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string username = Console.ReadLine();

            HashSet<string> uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                uniqueUsernames.Add(username);

                username = Console.ReadLine();
            }

            foreach (var name in uniqueUsernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
