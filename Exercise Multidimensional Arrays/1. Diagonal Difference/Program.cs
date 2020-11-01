using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = nums[j];
                }
            }
            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        firstSum += matrix[i, j];
                    }
                    if (i + j + 1 == n)
                    {
                        secondSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(firstSum-secondSum));
        }
    }
}
