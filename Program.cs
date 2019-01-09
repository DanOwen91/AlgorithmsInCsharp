using System;

namespace AlgorithmsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercising a simple linkedList
            SimpleLinkedList linkedList = new SimpleLinkedList();
            linkedList.AddToFirst("First");
            linkedList.AddToLast("Middle");
            linkedList.AddToLast("Last");
            linkedList.PrintOutAllNodeValues();

        }
    }
}
