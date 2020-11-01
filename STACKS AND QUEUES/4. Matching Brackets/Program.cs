using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];
                if (curr == '(')
                {
                    stack.Push(i);
                }
                else if (curr == ')')
                {
                    int start = stack.Pop();
                    string contest = input.Substring(start, i - start + 1);
                    Console.WriteLine(contest);
                }
            }



        }
    }
}
