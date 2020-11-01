using System;
using System.Linq;

namespace Count_Uppercase_word
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> uppercase = n => n[0]== n.ToUpper()[0];

            string[] text = Console.ReadLine().Split()
                .Where(uppercase)
                .ToArray();

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
