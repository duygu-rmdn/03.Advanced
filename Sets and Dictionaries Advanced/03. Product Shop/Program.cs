using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            var shops = new Dictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
                input = Console.ReadLine().Split(", ");
            }
            shops = shops.OrderBy(s => s.Key).ToDictionary(s => s.Key, d => d.Value);
            foreach (var item in shops)
            {
                Console.WriteLine(item.Key + "->");
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"Product: {value.Key}, Price: {value.Value}");
                }
            }



        }
    }
}
