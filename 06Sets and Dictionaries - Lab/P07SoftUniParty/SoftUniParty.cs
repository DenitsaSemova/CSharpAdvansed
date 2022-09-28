using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace P07SoftUniParty
{
    internal class SoftUniParty
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> vips = new HashSet<string>();
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var entry = Console.ReadLine();

            while (entry?.ToLower() != "party")
            {
                if (Char.IsDigit(entry[0]))
                {
                    vips.Add(entry);
                }
                else
                {
                    guests.Add(entry);
                }

                entry = Console.ReadLine();
            }

            entry = Console.ReadLine();

            while (entry?.ToLower() != "end")
            {
                if (Char.IsDigit(entry[0]))
                {
                    vips.Remove(entry);
                }
                else
                {
                    guests.Remove(entry);
                }

                entry = Console.ReadLine();
            }

            Console.WriteLine(guests.Count + vips.Count);

            foreach (var guest in vips)
            {
                Console.WriteLine(guest);

            }

            foreach (var guest in guests)
            {

                Console.WriteLine(guest);    
            }

        }
    }
}
