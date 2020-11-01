using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                var countries = input[1];
                string town = input[2];
                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continents[continent].ContainsKey(countries))
                {
                    continents[continent][countries] = new List<string>();
                }
                continents[continent][countries].Add(town);
            }
            foreach (var item in continents)
            {
                Console.WriteLine(item.Key + ":");
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"  {value.Key} -> {string.Join(", ",value.Value)}");
                }
            }
        }
    }
}
