using System;
using System.Collections.Generic;

namespace P04CitiesByContinentAndCountry
{
    internal class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> atlas =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (atlas.ContainsKey(continent) == false)
                {
                    atlas.Add(continent, new Dictionary<string, List<string>>());
                }

                if (atlas[continent].ContainsKey(country) == false)
                {
                    atlas[continent].Add(country, new List<string>());
                }

                atlas[continent][country].Add(city);

            }

            foreach (var continent in atlas)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var item in continent.Value)
                {
                    Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
