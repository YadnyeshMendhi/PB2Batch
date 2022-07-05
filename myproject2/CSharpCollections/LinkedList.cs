using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.CSharpCollections
{
    class LinkedList
    {

        //A LinkedList is a linear data structure which stores element in the non-contiguous location.
        //The elements in a linked list are linked with each other using pointers. 


        static void Main(string[] args)
        {
            // Doubly Linked List
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(10);
            ll.AddLast(90);
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


            LinkedListNode<int> n2 = ll.Find(10);
            ll.AddAfter(n2, new LinkedListNode<int>(900));

            // ll.RemoveFirst();
            //Node---> variable which can store data+address element in it
            foreach (int d in ll)
            {
                Console.WriteLine(d);
            }
/*
            LinkedListNode<int> n2 = ll.Find(10);
            ll.AddAfter(n2, new LinkedListNode<int>(900));*/
        }
    }
}
