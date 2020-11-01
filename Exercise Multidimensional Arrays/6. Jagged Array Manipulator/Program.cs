using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            if (n == 0)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arr[i] = new int[num.Length];
                for (int j = 0; j < num.Length; j++)
                {
                    if (i == 0)
                    {
                        arr[i][j] = num[j] * 2;
                    }
                    else if (i == n - 1)
                    {
                        arr[i][j] = num[j] / 2;
                    }
                    else
                    {
                        arr[i][j] = num[j];
                    }
                }
            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                if (command[0] == "Add" && command.Length == 4)
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row >= 0 && col >= 0 && row <= n - 1 && col <= arr[row].Length - 1)
                    {
                        arr[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract" && command.Length == 4)
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row >= 0 && col >= 0 && row <= n)
                    {
                        arr[row][col] -= value;
                    }
                }

                command = Console.ReadLine().Split();
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
