using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                queue.Enqueue(input);
            }
            int tank = 0;
            for (int i = 0; i < n; i++)
            {
                string curr = queue.Dequeue();
                int[] info = curr.Split().Select(int.Parse).ToArray();

                int fuel = info[0];
                int dictance = info[1];
                tank += fuel;
                if ( tank >= dictance)
                {
                    tank -= dictance ;
                }
                else
                {
                    i = -1;
                    tank = 0;
                }
                    queue.Enqueue(curr);
            }
            string[] best = queue.Dequeue().Split().ToArray();
            Console.WriteLine(best[2]);
        }
    }
}
