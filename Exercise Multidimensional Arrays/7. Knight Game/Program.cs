using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[n, n];
            int rowKiller = 0;
            int colKiller = 0;

            for (int i = 0; i < n; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    chessBoard[i, j] = chars[j];
                }
            }
            int couter = 0;
            while (true)
            {
                int maxAttacks = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char curr = chessBoard[i, j];
                        int attacks = 0;
                        if (curr == 'K')
                        {
                            attacks = GetMethod(chessBoard, i, j, attacks);
                            if (attacks > maxAttacks)
                            {
                                maxAttacks = attacks;
                                rowKiller = i;
                                colKiller = j;
                            }
                        }
                    }
                }
                if (maxAttacks > 0)
                {
                    chessBoard[rowKiller, colKiller] = '0';
                    couter++;
                }
                else
                {
                    Console.WriteLine(couter);
                    break;
                }






                if (maxAttacks <= 0)
                {
                    Console.WriteLine(couter);
                    break;
                }
            }



           
        }

        private static int GetMethod(char[,] chessBoard, int i, int j, int attacks)
        {
            if (IsInside(chessBoard, i - 2, j + 1) && chessBoard[i - 2, j + 1] == 'K')
            {
                attacks++;
            }
            if (IsInside(chessBoard, i - 2, j - 1) && chessBoard[i - 2, j - 1] == 'K')
            {
                attacks++;
            }
            if (IsInside(chessBoard, i + 1, j + 2) && chessBoard[i + 1, j + 2] == 'K')
            {
                attacks++;
            }
            if (IsInside(chessBoard, i + 1, j - 2) && chessBoard[i + 1, j - 2] == 'K')
            {
                attacks++;
            }
            if (IsInside(chessBoard, i - 1, j + 2) && chessBoard[i - 1, j + 2] == 'K')
            {
                attacks++;
            }
            if (IsInside(chessBoard, i - 1, j - 2) && chessBoard[i - 1, j - 2] == 'K')
            {
                attacks++;
            }
            if (IsInside(chessBoard, i + 2, j - 1) && chessBoard[i + 2, j - 1] == 'K')
            {
                attacks++;
            }
            if (IsInside(chessBoard, i + 2, j + 1) && chessBoard[i + 2, j + 1] == 'K')
            {
                attacks++;
            }

            return attacks;
        }

        private static bool IsInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0) && targetCol >= 0 && targetCol < chessBoard.GetLength(0);
        }
    }
}
