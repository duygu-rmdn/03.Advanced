using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> peoples = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, int> getSum = p => p.Select(c => (int)c).Sum();
            Func<List<string>, int, Func<string, int>, string> predicate = (peoples, n, func) => peoples.FirstOrDefault(p => func(p) >= n);
            string result = predicate(peoples, n, getSum);
            Console.WriteLine(result);
        }
        
    }
}
