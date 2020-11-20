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

        public bool Countains(int item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (!IsValidIndex(firstIndex) || !IsValidIndex(secondIndex))
            {
                throw new ArgumentOutOfRangeException();
            }
            int item = this.items[secondIndex];
            this.items[secondIndex] = this.items[firstIndex];
            this.items[firstIndex] = item;
        }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            if (!this.IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            int removeItem = this.items[index];
            this.items[index] = default;
            this.ShiftToLeft(index);
            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            this.Count--;
            return removeItem;
        }

        public void Insert(int index, int item)
        {
            if (!this.IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.ShiftToRight(index);
            this.items[index] = item;
            this.Count++;
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

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        private void ShiftToLeft(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            this.items[this.Count - 1] = default;
            //for (int i = this.Count - 1; i < this.items.Length; i++)
            //{
            //    this.items[i] = default;
            //}
        }

        private void ShiftToRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }
            
        }

        private bool IsValidIndex(int index)
            => index < this.Count;
        // return index < this.Count;
        //{ 
        //    return index < this.Count
        //}
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                if (i == this.Count - 1)
                {
                    sb.Append($"{this.items[i]}");
                }
                else
                {
                    sb.Append($"{this.items[i]}, ");
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
