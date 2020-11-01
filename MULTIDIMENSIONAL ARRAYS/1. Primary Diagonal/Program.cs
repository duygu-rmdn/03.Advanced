using System;
using System.Linq;

namespace _1._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] nums = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int[] colelements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    nums[i, j] = colelements[j];

                }

            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum += nums[j, i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
