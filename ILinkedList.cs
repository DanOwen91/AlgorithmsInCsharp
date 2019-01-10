namespace AlgorithmsInCsharp
{
    public interface ILinkedList
    {
        //The head of the linkedlist
        node head { get; }
        // A count to keep track of how many nodes we have in our list
        int Count { get; }
        // Add a node to the start of the list
        void AddToFirst(object value);
        // Add a node to the end of the list
        void AddToLast(object value);
        //Remove all entries of a value from the list
        void RemoveValue(object value);

    }
}