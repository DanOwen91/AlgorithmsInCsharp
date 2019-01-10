namespace AlgorithmsInCsharp
{
    /// <summary>
    /// Our node class that defines characteristice of a node
    /// </summary>
    public class node
    {
        //Element our value is placed
        internal object element;
        //The next node in the list
        internal node next = null;     
        //The previous node in the list allowing for a doubly linkedlist
        internal node previous = null;
    }
}