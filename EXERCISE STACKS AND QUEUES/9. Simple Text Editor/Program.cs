using System;
using System.Collections.Generic;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            int n = int.Parse(Console.ReadLine());
            char[] text;
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == "2")
                {
                    for (int j = 0; j < int.Parse(command[1]); j++)
                    {
                        stack.Pop();
                    }
                }
                else if (command[0] == "3")
                {
                    string curr = "";
                    for (int j = 0; j < int.Parse(command[1]); j++)
                    {
                        curr = stack.Pop();
                        stack.Push(curr);
                    }
                    Console.WriteLine(curr);
                }
                else if (command[0] == "4")
                {

                }

            }



        }
    }
}

