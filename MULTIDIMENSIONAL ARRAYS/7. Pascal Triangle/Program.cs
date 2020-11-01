using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];
            int cols = 1;
            for (int row = 0; row < n; row++)
            {
                pascal[row] = new long[cols];
                long[] currR = pascal[row];
                currR[0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;
                if (row > 1)
                {
                    for (int col = 1; col < currR.Length - 1; col++)
                    {
                        long[] prevR = pascal[row - 1];
                        long prevRS = prevR[col] + prevR[col - 1];
                        currR[col] = prevRS;
                    }
                }
                cols++;
            }
            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
