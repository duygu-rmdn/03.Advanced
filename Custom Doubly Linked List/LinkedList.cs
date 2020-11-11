using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Doubly_Linked_List
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void ForEach(Action<Node> action)
        {
            Node curNode = Head;
            while (curNode != null)
            {
                action(curNode);
                curNode = curNode.Next;
            }
        }

        public Node[] ToArray()
        {
            List<Node> list = new List<Node>();
            this.ForEach(node => list.Add(node));
            return list.ToArray();
        }

        public bool Remove(int value)
        {
            Node curNode = Head;
            while (curNode != null)
            {
                if (curNode.Value == value)
                {
                    curNode.Previous.Next = curNode.Next;
                    curNode.Next.Previous = curNode.Previous;
                    return true;
                }
                curNode = curNode.Next;
            }
            return false;
        }

        public void AddHead(Node newHead)
        {
            if (Head == null)
            {
                Head = newHead;
                Tail = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head.Previous = newHead;
                Head = newHead;
            }
        }

        public void AddLast(Node newTail)
        {
            if (Tail == null)
            {
                Tail = newTail;
                Head = newTail;
            }
            else
            {
                newTail.Previous = Tail;
                Tail.Next = newTail;
                Tail = newTail;
            }
        }

        public Node RemoveFirst()
        {
            var oldHead = this.Head;
            this.Head = this.Head.Next;
            Head.Previous = null;
            return oldHead;
        }

        public Node RemoveLast()
        {
            var oldTail = this.Tail;
            Tail = this.Tail.Previous;
            Tail.Next = null;
            return oldTail;
        }

        public int Peek()
        {
            return this.Head.Value;
        }

        public void PrintList()
        {
            this.ForEach(node => Console.WriteLine(node.Value));
            //Node currentNode = Head;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
            //}
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
