using System;
using System.IO;

namespace baynaryRider
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            //StreamReader reader1 = new StreamReader("../../../input.txt");
            //try
            //{
            //    Console.WriteLine(reader1.ReadToEnd());
            //}
            //finally
            //{
            //    reader1.Close;
            //}
        }
    }
}
