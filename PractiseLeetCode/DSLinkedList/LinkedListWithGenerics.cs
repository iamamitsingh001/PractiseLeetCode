using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DSLinkedList
{
    public class LinkedListWithGenerics<T>
    {
        public GenericNode<T> head = null;
        public GenericNode<T> tail = null;
        public void AddLast(T data)
        {
            GenericNode<T> newItem = new GenericNode<T>();
            newItem.data = data;
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
        public void AddFirst(T data)
        {
            GenericNode<T> newItem = new GenericNode<T>();
            newItem.data = data;
            if (head == null)
            {
                head = newItem;
                tail = newItem;
            }
            else
            {
                newItem.Next = head;
                head = newItem;
            }
        }
        public void ReadAll()
        {
            GenericNode<T> currentNode = head;
            while(currentNode.Next != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.Next;
            }
            Console.WriteLine(currentNode.data);
        }
    }
    public class GenericNode<T>
    {
        public T data = default;
        public GenericNode<T> Next = null;
    }
}
