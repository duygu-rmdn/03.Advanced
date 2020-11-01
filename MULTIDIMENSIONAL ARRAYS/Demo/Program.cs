using System;
using System.Linq;

namespace Demo
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            int[,] a = new int[2, 3];
            double[,] b = new double[4, 7];
            string[,,] c = new string[2, 3, 12];
            int[,] matrix = {
                { 1,2,3,4,5 },
            { 4,5,6,7,8} };
            int element1 = matrix[1, 1];
            Console.WriteLine(element1);
            int[,] num = new int[3, 4];
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = i + j;
                }
            }
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            foreach (var item in matrix)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] curr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = curr[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            //int[][] jagged = new int[3][];
            //jagged[0] = new int[3];
            //jagged[1] = new int[56];
            //jagged[3] = new int[24];

            int[][] jagged = new int[5][];

            for (int i = 0; i < jagged.Length; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                jagged[i] = new int[input.Length];
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = int.Parse(input[j]);
                }
            }
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
