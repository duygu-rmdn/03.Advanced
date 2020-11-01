using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] nums = new int[n[0], n[1]];
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                int[] colelements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = colelements[j];

                }

            }
            for (int i = 0; i < nums.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < nums.GetLength(0); j++)
                {
                    sum += nums[j,i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
