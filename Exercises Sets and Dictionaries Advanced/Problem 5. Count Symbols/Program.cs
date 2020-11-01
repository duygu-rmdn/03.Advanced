using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();

            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char curr = text[i];
                if (!output.ContainsKey(curr))
                {
                    output.Add(curr, 1);
                }
                else
                {
                    output[curr]++;
                }
            }
            output = output.OrderBy(x => x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }


        }
    }
}
