using System;
using System.Linq;

namespace Vat
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(", ")
                .Select(double
                .Parse)
                .Select(x => x  * 1.20)
                .ToArray();
            foreach (var item in nums)
            {
                Console.WriteLine($"{item:f2}");
            }

        }
    }
}
