﻿using System;

namespace _2._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        private static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int factorial = n * Factorial(n - 1);
            return factorial;
        }
    }
}
