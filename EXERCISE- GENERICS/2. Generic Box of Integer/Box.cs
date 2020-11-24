using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Generic_Box_of_Integer
{
    public class Box<T>
    {
        public T Value { get; set; }
        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {Value}";
        }
    }
}
