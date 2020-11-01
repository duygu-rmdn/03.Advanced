using System;
using System.Linq;

namespace _4._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[n[0], n[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] curr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = curr[j];
                }
            }
            int max = int.MinValue;
            int sum = 0;
            int best1 = 0;
            int best2 = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j + 1] + matrix[i + 1, j] > max)
                    {
                        max = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j + 1] + matrix[i + 1, j];
                        best1 = i;
                        best2 = j;
                    }
                }
            }
            Console.WriteLine(matrix[best1, best2] + " " + matrix[best1, best2 + 1]);
            Console.WriteLine(matrix[best1 + 1, best2] + " " + matrix[best1 + 1, best2 + 1]);
            Console.WriteLine(max);
        }
    }
}
