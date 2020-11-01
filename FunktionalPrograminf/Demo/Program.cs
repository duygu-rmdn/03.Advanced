using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, string> func = n => n.ToString();
            Print("jdbdkasbjs");
            Action<string> print = messege => Console.WriteLine(messege);
            print("xcdfc");
            func(123121);
            Console.WriteLine(func(5625) + 2);
        }
        static void Print(string messege)
        { Console.WriteLine(messege); }
    }
}
