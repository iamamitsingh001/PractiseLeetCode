using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DSLinkedList
{
    public class LinkedListWithTailNode
    {
        Node head = null;
        Node tail = null;
        public void AddLast(object data)
        {
            Node newItem = new Node();
            newItem.Data = data;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                tail.Next = newItem;
                tail = newItem;
            }
        }
        public void AddFirst(object data)
        {
            Node newItem = new Node();
            newItem.Data = data;
            if (head == null)
            {
                head = newItem;
                tail = head;
            }
            else
            {
                newItem.Next = head;
                head = newItem;
            }
        }

        public void ReadAll()
        {
            Node current = head;
            while (current.Next != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
            Console.WriteLine(current.Data);
        }
    }
}
