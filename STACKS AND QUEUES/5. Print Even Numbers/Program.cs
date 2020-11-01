using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> evenNums = new Queue<int>();
            for (int i = 0; i < input.Length; i++)
            {
                int curr = input[i];
                if (curr % 2 == 0)
                {
                    evenNums.Enqueue(curr);
                }

            }
            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
