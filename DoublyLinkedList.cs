namespace AlgorithmsInCsharp
{
    public class DoublyLinkedList : ILinkedList
    {
        //Head node 
        public node head { get; private set; } 
        //Count
        public int Count { get; private set; } 

        /// <summary>
        /// Add a node to the start of the list
        /// </summary>
        public void AddToFirst(object value)
        {
            node nodeFirst = new node();
            nodeFirst.element = value;
            nodeFirst.next = head;

            head = nodeFirst;
            Count++;
        }
        /// <summary>
        /// Add a node to the end of the list
        /// </summary>
        /// <param name="value"></param>
        public void AddToLast(object value)
        {
            node nodeLast = new node();
            nodeLast.element = value;
            Count++;

            //If the head is null, the list is empty. Add to the start
            if(head == null)
            {
                nodeLast.next = null;
                head = nodeLast;
            }
            else
            {
                node lastNode = FindLastNode(head);
                             
                lastNode.next = nodeLast;
            } 
        }

        /// <summary>
        /// Use recursion to find the last node in the list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        private node FindLastNode(node head, object value = null)
        {
            node lastNode = head;
            if(head.next != value)
            {
                lastNode = FindLastNode(lastNode.next);
            }
            return lastNode;
        }
        
        /// <summary>
        /// A Method for removing all values specified
        /// </summary>
        /// <param name="value"></param>
        public void RemoveValue(object value)
        {
            node lastNode = head;
            while(lastNode.next != null)
            {
                if(lastNode.next.element == value)
                {
                    lastNode.next = lastNode.next.next;
                    Count--;
                }
                else
                {
                    lastNode = lastNode.next;
                }
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
}