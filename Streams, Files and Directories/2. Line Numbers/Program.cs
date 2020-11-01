using System;
using System.IO;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {

                string line = reader.ReadLine();
                int index = 1;
                while (line != null)
                {
                    Console.WriteLine(index + ". " + line);
                    index++;
                    line = reader.ReadLine();
                }
            }



        }
    }
}
