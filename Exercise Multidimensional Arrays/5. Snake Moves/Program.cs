using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[n[0], n[1]];
            string text = Console.ReadLine();
            int curr = 0;
            for (int i = 0; i < n[0]; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n[1]; j++)
                    {
                        matrix[i, j] = text[curr];
                        curr++;
                        if (curr == text.Length)
                        {
                            curr = 0;
                        }
                    }
                }
                else
                {
                    for (int j = n[1] - 1; j >= 0; j--)
                    {
                        matrix[i, j] = text[curr];
                        curr++;
                        if (curr == text.Length)
                        {
                            curr = 0;
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
