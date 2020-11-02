using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Array.Sort(nums, (x, y) =>
            {
                int sorted = 0;
                if (x % 2 == 0 && y % 2 !=0)
                {
                    sorted = 1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    sorted = -1;
                }
                else
                {
                    sorted = x - y;
                }
                return sorted;
            });
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
