using System;
using System.Collections.Generic;
using System.Text;

namespace IMPLEMENTING_STACK_AND_QUEUE
{
    public class CustomList
    {
        private const int INITIAL_CAPACITY = 2;

        private int[] items;

        public CustomList()
        {
            this.items = new int[INITIAL_CAPACITY];
        }
        public int Count { get; private set; }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int this[int index]
        {
            get 
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (!this.IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.items[index] = value;
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            items = copy;
        }

        private bool IsValidIndex(int index)
            => index < this.Count;
        // return index < this.Count;
        //{ 
        //    return index < this.Count
        //}
    }
}
