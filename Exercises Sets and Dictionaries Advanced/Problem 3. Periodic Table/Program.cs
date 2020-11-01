using System;
using System.Collections.Generic;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> set = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                foreach (var item in elements)
                {
                    set.Add(item);
                }
            }
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }

        }
    }
}
