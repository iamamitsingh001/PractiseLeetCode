using System;

namespace PractiseLeetCode.DSLinkedList
{
    public class LinkedList
    {
        public Node Head = null;
        public void AddLast(object data)
        {
            var newItem = new Node();
            newItem.Data = data;
            if (Head == null)
            {
                Head = newItem;
                Head.Next = null;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newItem;
                newItem.Next = null;
            }
        }
        public void AddFirst(object data) 
        {
            Node newitem = new Node();
            newitem.Data = data;
            if (Head == null)
            {
                Head = newitem;
                Head.Next = null;
            }
            else
            {
                newitem.Next = Head;
                Head = newitem;
            }
            
        }
        public void ReadAll()
        {
            Node currentNode = Head;
            while (currentNode.Next != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
            Console.WriteLine(currentNode.Data);
        }
    }
}
