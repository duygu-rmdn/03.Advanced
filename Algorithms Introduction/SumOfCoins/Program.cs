using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] { 1, 2, 5, 10 };
            int n = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            int change = 0;
            coins = coins.OrderByDescending(c => c).ToArray();
            while (change < n)
            {
                for (int i = 0; i < coins.Length; i++)
                {
                    if (change + coins[i] <= n)
                    {
                        change += coins[i];
                        result.Add(coins[i]);
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
