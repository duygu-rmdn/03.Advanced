using System;
using System.Linq;

namespace _2.__2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[nums[0], nums[1]];

            for (int i = 0; i < nums[0]; i++)
            {
                char[] num = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int j = 0; j < nums[1]; j++)
                {
                    matrix[i, j] = num[j];
                }
            }
            int counter = 0;
            for (int i = 0; i < nums[0] - 1; i++)
            {
                for (int j = 0; j < nums[1] - 1; j++)
                {
                    char a = matrix[i, j];
                    char b = matrix[i + 1, j];
                    char c = matrix[i, j + 1];
                    char d = matrix[i + 1, j + 1];
                    if (a == b && a == c && a == d && b == c && b == d && c == d)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
