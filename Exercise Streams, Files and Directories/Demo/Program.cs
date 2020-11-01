using System;
using System.IO;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("../../../text.txt", FileMode.OpenOrCreate);












        //    using (StreamWriter writer = new StreamWriter("../../../text.txt"))
        //    {
        //        writer.WriteLine("Hello");
        //    }
        //    StreamReader reader = new StreamReader("../../../text.txt");
        //   Console.WriteLine(reader.ReadToEnd());
        //   reader.Close();
        //    ////StreamReader reader = new StreamReader("../../../text.txt");
        //    ////Console.WriteLine(reader.ReadToEnd());
        //    ////reader.Close();
        //    //using (StreamReader reader = new StreamReader("../../../text.txt")) 

        }
    }
}
