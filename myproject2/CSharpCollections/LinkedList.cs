using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            // Doubly Linked List
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(45);
            ll.AddLast(65);
            ll.AddLast(20);

            foreach(int d in ll)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("...........................................");

           ll.RemoveFirst();
           // ll.Remove(90);
            LinkedListNode<int> n1 = ll.Find(90);
            ll.AddAfter(n1, new LinkedListNode<int>(900));

           // ll.RemoveFirst();
            //Node---> variable which can store data+address element in it
            foreach(int d in ll)
            {
                Console.WriteLine(d);
            }
        }
    }
}
