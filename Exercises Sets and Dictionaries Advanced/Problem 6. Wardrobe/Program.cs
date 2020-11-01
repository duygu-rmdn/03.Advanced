using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> output = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clotches = input[1].Split(",");
                if (!output.ContainsKey(color))
                {
                    output.Add(color, new Dictionary<string, int>());
                }
                foreach (var item in clotches)
                {
                    if (!output[color].ContainsKey(item))
                    {
                        output[color].Add(item, 1);
                    }
                    else
                    {
                        output[color][item]++;
                    }
                }
            }
            string[] toFound = Console.ReadLine().Split();
            string colorToFound = toFound[0];
            string clotchesToFound = toFound[1];

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item1 in item.Value)
                {
                    Console.Write($"* {item1.Key} - {item1.Value} ");
                    if (item.Key == colorToFound && item1.Key == clotchesToFound)
                    {
                        Console.WriteLine("(found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
