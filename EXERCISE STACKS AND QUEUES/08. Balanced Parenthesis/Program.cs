using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }
            
            if (queue.Count % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
