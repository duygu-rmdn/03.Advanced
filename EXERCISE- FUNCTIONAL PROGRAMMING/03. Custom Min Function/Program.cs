using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> minNum = n =>
            {
                int min = int.MaxValue;
                foreach (var item in nums)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Console.WriteLine(minNum(nums));
        }
    }
}
