using System;

namespace Custom_Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            for (int i = 0; i < 20; i++)
            {
                list.AddHead(new Node(i));
            }
            list.PrintList();
        }
    }
}
