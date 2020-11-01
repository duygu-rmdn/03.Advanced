using System;
using System.Collections;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!songs.Contains(input[i]))
                {
                    songs.Enqueue(input[i]);
                }
            }
            string command = Console.ReadLine();
            while (songs.Count > 0)
            {
                string[] splited = command.Split();
                if (splited[0] == "Add")
                {
                    string song = "";
                    for (int i = 4; i < command.Length; i++)
                    {
                        song += command[i];
                    }
                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }


                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
