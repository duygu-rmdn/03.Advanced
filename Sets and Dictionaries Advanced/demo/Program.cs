using System;
using System.Collections.Generic;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, double> fruits = new SortedDictionary<string, double>();

            fruits["banana"] = 1.52;
            fruits["apple"] = 2.20;
            fruits.Add("kiwi", 4.89);
            fruits.Remove("kiwi");
            Console.WriteLine(fruits.ContainsKey("banana"));
            foreach (var item in fruits)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }


            var grades = new Dictionary<string, List<int>>();
            grades["Peter"] = new List<int>();
            grades["Peter"].Add(5);
            grades["Kiril"] = new List<int>() { 1, 2, 3, 4, 55 };
            foreach (var item in grades)
            {
                Console.WriteLine(item.Key + " " + string.Join(" ", item.Value));
            }
            SortedSet<string> set = new SortedSet<string>();
            set.Add("Pesho");
            set.Add("Pesho");
            set.Add("gosho");
            Console.WriteLine(string.Join(", ", set));
            Console.WriteLine(set.Contains("alabala"));
            Console.WriteLine(set.Contains("Pesho"));
            set.Remove("Pesho");
            Console.WriteLine(set.Count);
        }
    }
}
