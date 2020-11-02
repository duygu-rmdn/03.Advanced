using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, bool> predicate = n => n.Length <= num;
            names = names.Where(predicate).ToList();
            Console.WriteLine(string.Join(Environment.NewLine , names));
        }
    }
}
