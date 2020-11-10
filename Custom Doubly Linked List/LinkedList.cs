using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Doubly_Linked_List
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void AddHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
        }

        public Node Pop()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            return oldHead;
        }
        public int Peek()
        {
            return this.Head.Value;
        }

        public void PrintList()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public void ReversePrintList()
        {
            Node currNode = Tail;
            while (currNode != null)
            {
                Console.WriteLine(currNode.Value);
                currNode = currNode.Previous;
            }
        }
    }
}
