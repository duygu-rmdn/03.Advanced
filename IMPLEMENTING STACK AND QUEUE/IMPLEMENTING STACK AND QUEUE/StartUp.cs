using System;

namespace IMPLEMENTING_STACK_AND_QUEUE
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CustomStack myCustomStack = new CustomStack();

            for (int i = 1; i <= 5; i++)
            {
                myCustomStack.Push(i);
                Console.WriteLine(myCustomStack.Peek());
            }
            Console.WriteLine("------------------");
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(myCustomStack.Pop()); 
            //}
            //Console.WriteLine("-------");
            //myCustomStack.ForEach(e=>
            //{
            //    Console.WriteLine(e);
            //});
            myCustomStack.ForEach(Console.WriteLine);
            //myCustomStack.Peek();


            //-------------------------------------------


            //CustomList myCustomList = new CustomList();

            //for (int i = 1; i <= 4; i++)
            //{
            //    myCustomList.Add(i);
            //}
            //myCustomList.Insert(1, 18);
            //myCustomList.RemoveAt(2);
            //Console.WriteLine(myCustomList.Countains(18));
            //Console.WriteLine(myCustomList.Countains(180));

            //for (int i = 0; i < myCustomList.Count; i++)
            //{
            //    Console.WriteLine(myCustomList[i]);
            //}
            //Console.WriteLine("---------------");
            //myCustomList.Swap(1, 2);
            //for (int i = 0; i < myCustomList.Count; i++)
            //{
            //    Console.WriteLine(myCustomList[i]);
            //}
            //Console.WriteLine(myCustomList);
        }
    }
}
