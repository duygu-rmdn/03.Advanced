using System;

namespace Custom_Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
           

            LinkedList list = new LinkedList();
            for (int i = 0; i < 5; i++)
            {
                list.AddHead(new Node(i));
            }
            list.Remove(2);
            //for (int i = 0; i < 5; i++)
            //{
            //    list.AddLast(new Node(i));
            //}

            //list.RemoveFirst();
            //list.RemoveFirst();
            //list.RemoveFirst();

            //list.RemoveLast();
            //list.RemoveLast();
            //list.RemoveLast();

            list.PrintList();

            Console.WriteLine(list.ToArray().Length);
            








            //LinkedList list = new LinkedList();

            //for (int i = 0; i < 10; i++)
            //{
            //    list.AddHead(new Node(i));
            //}
            //list.PrintList();
            ////Console.WriteLine($"Poped: {list.Pop().Value}");
            ////Console.WriteLine($"Poped: {list.Pop().Value}");
            ////Console.WriteLine($"Poped: {list.Pop().Value}");
            ////Console.WriteLine($"Poped: {list.Pop().Value}");
            //list.ReversePrintList();
        }
    }
}
