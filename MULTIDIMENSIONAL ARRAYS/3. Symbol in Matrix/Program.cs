using System;

namespace _3._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chars = new char[n,n];
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                for (int j = 0; j < text.Length; j++)
                {
                    chars[i, j] = text[j];
                }
            }
            char toFind = char.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (chars[i, j] == toFind)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{toFind} does not occur in the matrix");
        }
    }
}
