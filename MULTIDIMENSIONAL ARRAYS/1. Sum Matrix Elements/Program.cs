using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] nums = new int[n[0], n[1]];
            int sum = 0;
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                int[] colelements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    nums[i, j] = colelements[j];

                }

            }
            foreach (var item in nums)
            {
                sum += item;
            }
            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);
            Console.WriteLine(sum);
        }
    }
}
