using System;
using System.Collections;
using System.Collections.Generic;

namespace STACKS_AND_QUEUES__demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count !=0)
            {
                Console.WriteLine(stack.Pop());
            }



        }
    }
}
