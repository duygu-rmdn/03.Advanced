
using System;
using System.IO;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");
            var curr = reader.ReadToEnd();
            Console.WriteLine(curr);
            //while (curr != -1)
            //{
            //    Console.WriteLine((char)curr);
            //    curr = reader.Read();
            //}
            //reader.Close();



            //for (int i = 0; i < 1; i++)
            //{

            //StreamWriter writer = new StreamWriter($"../../../strudents-part-{i+1}.txt");
            //writer.Write("1sudent");
            //writer.WriteLine("2sudent");
            //writer.WriteLine("3sudent");
            //writer.Close();
            //}
        }
    }
}
