using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Laptop
    {
        public Laptop(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine(this.Name);
        }
    }
}
