using System;
using System.Collections.Generic;
using System.Linq;

namespace P06Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var entry = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string color = entry[0];
                string[] items = entry[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();


                foreach (var item in items)
                {

                    if (clothes.ContainsKey(color) == false)
                    {
                        clothes.Add(color, new Dictionary<string, int>());
                    }

                    if (clothes[color].ContainsKey(item) == false)
                    {
                        clothes[color].Add(item, 1);
                    }
                    else if (clothes[color].ContainsKey(item) == true)
                    {
                        clothes[color][item]++;
                    }
                }
            }

            var toLookFor = Console.ReadLine().Split().ToArray();

            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");

                string searchColor = toLookFor[0];
                string searchItem = toLookFor[1];

                bool isEqual = searchColor == item.Key;

                foreach (var value in item.Value)
                {
                    if (isEqual)
                    {
                        if (value.Key == searchItem)
                        {
                            Console.WriteLine($"* {value.Key} - {value.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {value.Key} - {value.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"* {value.Key} - {value.Value}");
                    }
                }
            }
        }
    }
}
