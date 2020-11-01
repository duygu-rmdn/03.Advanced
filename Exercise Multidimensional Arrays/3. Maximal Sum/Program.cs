using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();
            int[,] matrix = new int[n[0], n[1]];
            if (n[0] > 2 && n[0] > 2)
            {

                for (int i = 0; i < n[0]; i++)
                {
                    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int j = 0; j < n[1]; j++)
                    {
                        matrix[i, j] = nums[j];
                    }
                }
                int max = int.MinValue;
                int best1 = 0;
                int best2 = 0;
                int sum = 0;
                for (int i = 0; i < n[0] - 2; i++)
                {
                    for (int j = 0; j < n[1] - 2; j++)
                    {
                        sum += matrix[i, j];
                        sum += matrix[i + 1, j];
                        sum += matrix[i, j + 1];
                        sum += matrix[i + 1, j + 1];
                        sum += matrix[i + 1, j + 2];
                        sum += matrix[i + 2, j + 1];
                        sum += matrix[i + 2, j + 2];
                        sum += matrix[i + 2, j];
                        sum += matrix[i, j + 2];
                        if (sum > max)
                        {
                            max = sum;
                            best1 = i;
                            best2 = j;
                        }
                        sum = 0;
                    }
                }
                Console.WriteLine("Sum = " + max);
                for (int i = best1; i < best1 + 3; i++)
                {
                    for (int j = best2; j < best2 + 3; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
