using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int num = int.Parse(Console.ReadLine());
            input.Reverse();
            Func<int, bool> predicate = x => x % num != 0;
            input = input.Where(predicate).ToList();
            //input = input.Where(n => n % num != 0).ToList();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
