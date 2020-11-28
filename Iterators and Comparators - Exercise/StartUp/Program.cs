using System;
using System.Collections.Generic;
using System.Linq;

namespace StartUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(nums);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
