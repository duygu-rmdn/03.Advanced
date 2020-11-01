using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> nums = new Stack<int>(input);
            string[] command = Console.ReadLine().Split();
            while (true)
            {

                string operation = command[0].ToLower().ToString();
                if (operation == "add")
                {
                    nums.Push(int.Parse(command[1]));
                    nums.Push(int.Parse(command[2]));
                }
                else if (operation == "remove")
                {
                    if (int.Parse(command[1]) <= nums.Count )
                    {
                        int count = int.Parse(command[1]);
                        for (int i = 0; i < count; i++)
                        {
                            nums.Pop();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sum: " + nums.Sum());
                    break;
                }
                command = Console.ReadLine().Split();
            }



        }
    }
}
