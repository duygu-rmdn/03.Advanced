using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addFunc = x => x + 1;
            Func<int, int> subtracFunc = x => x - 1;
            Func<int, int> multiplayFunc = x => x * 2;
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Action<List<int>> print = n => Console.WriteLine(string.Join(" ", n));
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    input = input.Select(addFunc).ToList();
                }
                else if (command == "multiply")
                {
                    input = input.Select(multiplayFunc).ToList();
                }
                else if (command == "subtract")
                {
                    input = input.Select(subtracFunc).ToList();
                }
                else
                {
                    print(input);
                }
                command = Console.ReadLine();
            }
        }
    }
}
