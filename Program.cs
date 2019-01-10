using System;

namespace AlgorithmsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercising a simple linkedList
            SimpleLinkedList linkedList = new SimpleLinkedList();

            //Add a bunch of data to the list
            linkedList.AddToFirst("First");
            linkedList.AddToLast("Middle");
            linkedList.AddToLast("Middle");
            linkedList.AddToLast("Middle");
            linkedList.AddToLast("Middle");
            linkedList.AddToLast("Last");
            System.Console.WriteLine("All the data added to the list: ");
            linkedList.PrintOutAllNodeValues();
            System.Console.WriteLine($"The number items: {linkedList.Count}");
            System.Console.WriteLine("\n\nRemoving \"Middle\"");
            linkedList.RemoveValue("Middle");

            System.Console.WriteLine("\nAll the data added to the list: ");
            linkedList.PrintOutAllNodeValues();
            System.Console.WriteLine($"The number items: {linkedList.Count}");
        }
    }
}
