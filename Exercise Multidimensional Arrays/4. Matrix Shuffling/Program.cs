using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[n[0], n[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] nums = Console.ReadLine().Split();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = nums[j];
                }
            }
            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                if (command[0] == "swap" && command.Length == 5)
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    if (row1 > -1 && row1 < matrix.GetLength(0) && row2 > -1 && row2 < matrix.GetLength(0) && col1 > -1 && col1 < matrix.GetLength(1) && col2 > -1 && col2 < matrix.GetLength(1))
                    {
                        string a = matrix[row1, col1];
                        string b = matrix[row2, col2];
                        matrix[row1, col1] = b;
                        matrix[row2, col2] = a;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split();
            }


        }
    }
}
