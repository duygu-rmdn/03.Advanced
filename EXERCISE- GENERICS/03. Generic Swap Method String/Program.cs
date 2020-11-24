using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Generic_Swap_Method_String
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> values = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string currValue = Console.ReadLine();
                values.Add(currValue);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];
            Box<string> box = new Box<string>(values);
            box.Swap(firstIndex, secondIndex);
            Console.WriteLine(box);
        }
    }
}
