namespace AlgorithmsInCsharp
{
    /// <summary>
    /// A simple linked list.
    /// Only capable of forward Item navigation
    /// </summary>
    public class SimpleLinkedList
    {
        //The head of the linkedlist - if null then our list is empty
        private node head = null;

        /// <summary>
        /// Add a node to the end of the list
        /// </summary>
        public void AddToFirst(object value)
        {
            node nodeFirst = new node();
            nodeFirst.element = value;
            nodeFirst.next = head;

            head = nodeFirst;
        }
        public void AddToLast(object value)
        {
            node nodeLast = new node();
            nodeLast.element = value;

            //If the head is null, the list is empty. Add to the start
            if(head == null)
            {
                nodeLast.next = null;
                head = nodeLast;
            }
            else
            {
                //ToDo: Fix this loop so the last node isn't overwritten
                node lastNode = head;
                for (node currentNode = head; currentNode.next != null; currentNode = currentNode.next)
                {
                    lastNode = currentNode;
                }
                lastNode.next = nodeLast;
                    
            } 
        }
        public void PrintOutAllNodeValues()
        {
            for (node currentNode = head; currentNode != null; currentNode = currentNode.next)
            {
                System.Console.WriteLine($"{currentNode.element}");
            }                
        }
    }
    /// <summary>
    /// Our node class that defines characteristice of a node
    /// </summary>
    public class node
    {
        //Element our value is placed
        internal object element;
        //The next node in the list
        internal node next = null;     
    }
}