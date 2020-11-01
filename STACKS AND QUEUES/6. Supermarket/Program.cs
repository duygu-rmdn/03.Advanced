using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> peoples = new Queue<string>();
            while (name != "End")
            {
                if (name == "Paid")
                {
                    while (peoples.Count > 0)
                    {
                        Console.WriteLine(peoples.Dequeue());
                    }
                }
                else
                {
                    peoples.Enqueue(name);
                }
                name = Console.ReadLine();
            }
           
            Console.WriteLine($"{peoples.Count} people remaining.");
        }
    }
}
