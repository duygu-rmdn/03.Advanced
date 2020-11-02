using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            names = names.Select(n => $"Sir {n}").ToList();
            Action<List<string>> print = a => 
            Console.WriteLine(string.Join(Environment.NewLine, a));

            print(names);

        }
    }
}
