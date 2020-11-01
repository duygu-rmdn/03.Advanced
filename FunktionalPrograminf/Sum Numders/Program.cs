using System;
using System.Linq;

namespace Sum_Numders
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> func = n => int.Parse(n); 
            int[] nums = Console.ReadLine()
                .Split(", ")
                .Select(func)
                .ToArray();
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }
    }
}
