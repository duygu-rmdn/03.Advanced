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
            //Array.Sort(nums, (x, y) =>
            //{
            //    int sorted = 0;
            //    if (x % 2 == 0 && y % 2 !=0)
            //    {
            //        sorted = -1;
            //    }
            //    else if (x % 2 != 0 && y % 2 == 0)
            //    {
            //        sorted = 1;
            //    }
            //    else
            //    {
            //        sorted = x - y;
            //    }
            //    return sorted;
            //});
            Array.Sort(nums, (x, y) => x % 2 == 0 && y % 2 != 0 ? -1 : x % 2 != 0 && y % 2 == 0 ? 1 : x.CompareTo(y));

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
