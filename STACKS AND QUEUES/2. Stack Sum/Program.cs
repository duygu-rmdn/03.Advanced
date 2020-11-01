using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var vaues = input.Split(' ');  
            var stack = new Stack<string>(vaues.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operatoR = stack.Pop();
                int second = int.Parse(stack.Pop());
                if (operatoR == "+")
                {
                    int result = first + second;
                    stack.Push(result.ToString());
                }
                else
                {
                    int result = first - second;
                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
