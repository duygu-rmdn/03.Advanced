using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);
            int counter = 0;
            int sum = 0;
            while (stack.Count > 0)
            {
                var curr = stack.Peek();
                if (sum + curr > capacity)
                {
                    counter++;
                    sum = 0;
                }
                else
                {
                    sum += stack.Pop();
                }

            }
            counter++;
            Console.WriteLine(counter);
        }
    }
}
