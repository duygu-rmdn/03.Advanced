﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Generic_Swap_Method_String
{
    public class Box<T>
    {
        public List<T> Values { get; set; } = new List<T>();
        public Box(List<T> values)
        {
            this.Values = values;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T item = this.Values[firstIndex];
            this.Values[firstIndex] = this.Values[secondIndex];
            this.Values[secondIndex] = item;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T value in this.Values)
            {
                sb.AppendLine($"{value.GetType()}: {value}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
