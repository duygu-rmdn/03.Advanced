using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> counts = new Dictionary<double, int>();
            foreach (var item in nums)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine(item.Key + " - " + item.Value + " times");
            }




        }
    }
}
