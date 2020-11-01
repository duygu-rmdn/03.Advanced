using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            HashSet<string> setVip = new HashSet<string>();

            string input = Console.ReadLine();
            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    setVip.Add(input);
                }
                else
                {
                    set.Add(input);
                }
                input = Console.ReadLine();
            }
            while (input != "END")
            {
                if (set.Contains(input))
                {
                    set.Remove(input);
                }
                else if (setVip.Contains(input))
                {
                    setVip.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(set.Count + setVip.Count);
            foreach (var item in setVip)
            {
                Console.WriteLine(item);
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
