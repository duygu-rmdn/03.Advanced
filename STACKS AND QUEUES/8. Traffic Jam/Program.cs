using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();
            int counter = 0;
            int passedCounter = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    if (counter >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine(queue.Dequeue() + " passed!");
                            passedCounter++;
                            counter--;
                        }
                    }
                    else
                    {
                        int curr = counter;
                        for (int i = 0; i < curr; i++)
                        {
                            Console.WriteLine(queue.Dequeue() + " passed!");
                            passedCounter++;
                            counter--;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                    counter++;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{passedCounter} cars passed the crossroads.");
        }
    }
}
