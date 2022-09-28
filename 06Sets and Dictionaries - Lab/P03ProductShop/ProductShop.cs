using System;
using System.Collections.Generic;

namespace P03ProductShop
{
    internal class ProductShop
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops =
                new SortedDictionary<string, Dictionary<string, double>>();

            var entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);


            while (entry[0] != "Revision")
            {

                string shop = entry[0];
                string product = entry[1];
                double price = double.Parse(entry[2]);

                if (shops.ContainsKey(shop) == false)
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (shops[shop].ContainsKey(product) == false)
                {
                    shops[shop].Add(product, 0);
                }

                shops[shop][product] = price;

                entry = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var items in item.Value)
                {
                    Console.WriteLine($"Product: {items.Key}, Price: {items.Value}");
                }
            }
        }
    }
}
