using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                first.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                second.Add(num);
            }
            int max = 0;
            if (n > m)
            {
                max = n;
            }
            else
            {
                max = m;
            }
            HashSet<int> set = new HashSet<int>();

            foreach (var item in first)
            {
                foreach (var item1 in second)
                {
                    if (item == item1)
                    {
                        Console.Write(item + " ");
                    }
                }
            }


        }
    }
}
