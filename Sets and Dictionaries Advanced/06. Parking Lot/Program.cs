using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            HashSet<string> set = new HashSet<string>();
            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    set.Add(input[1]);
                }
                else
                {
                    set.Remove(input[1]);
                }
                input = Console.ReadLine().Split(", ");
            }
            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
