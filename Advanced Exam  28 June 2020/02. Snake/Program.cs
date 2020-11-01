using System;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            int snakeRow = -1;
            int snakeCol = -1;
            int firstBRow = -1;
            int firstBCol = -1;
            int secondBRow = -1;
            int secondBCol = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                    if (matrix[i, j] == 'S')
                    {
                        snakeRow = i;
                        snakeCol = j;
                    }
                    if (matrix[i, j] == 'B')
                    {
                        if (firstBRow == -1)
                        {
                            firstBRow = i;
                            firstBCol = j;
                        }
                        else
                        {
                            secondBRow = i;
                            secondBCol = j;
                        }
                    }
                }
            }


            matrix[snakeRow, snakeCol] = '.';
            int food = 0;
            while (true)
            {
                if (food >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    matrix[snakeRow, snakeCol] = 'S';
                    break;
                }
                string command = Console.ReadLine();

                if (command == "up")
                {
                    snakeRow--;
                }
                else if (command == "down")
                {
                    snakeRow++;
                }
                else if (command == "left")
                {
                    snakeCol--;
                }
                else if (command == "right")
                {
                    snakeCol++;
                }
                if (!IsSafe(matrix, snakeRow, snakeCol))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (matrix[snakeRow, snakeCol] == '*')
                {
                    food++;
                }
                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (firstBRow == snakeRow && firstBCol == snakeCol)
                    {
                        snakeRow = secondBRow;
                        snakeCol = secondBCol;
                    }
                    else
                    {
                        snakeRow = firstBRow;
                        snakeCol = firstBCol;
                    }
                }
                matrix[snakeRow, snakeCol] = '.';

            }

            Console.WriteLine($"Food eaten: {food}");
            Print(matrix);

        }

        private static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static bool IsSafe(char[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }
            if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }
    }
}
