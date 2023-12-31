using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseLeetCode.DSLinkedList
{
    public class LinkedListCaller
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddLast("1");
            linkedList.AddLast("2");
            linkedList.AddLast("3");
            linkedList.AddLast("4");
            linkedList.AddLast("5");
            linkedList.AddLast("6");
            linkedList.AddFirst("First");
            linkedList.ReadAll();
            Console.ReadLine();
        }
    }
}
