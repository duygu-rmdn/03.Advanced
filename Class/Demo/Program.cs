using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("HP");
            //Console.WriteLine(laptop.Name);
            laptop.Print();
            Laptop laptop2 = new Laptop("Asus");
            //Console.WriteLine(laptop.Name);
            laptop2.Print();
        }
    }
}
