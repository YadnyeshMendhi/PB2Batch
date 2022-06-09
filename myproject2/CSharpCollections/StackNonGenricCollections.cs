using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class StackNonGenricCollections
    {
        static void Main(String[] args)
        {
            // creating a stack
            // it is a LIFO ( list in first out) structure 
            Stack stack = new Stack();

            //Elements
            //we use push word to add elements in stack
            stack.Push("one");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");
            stack.Push("five");

            stack.Pop();// which helps us to remove elements from stack
                        //the top most element means last element will get pop 

           /* string d = (string)stack.Pop();
            Console.WriteLine("Removed"+"--------->"+d);*/

            object top = stack.Peek();//it shows top most element without 
            Console.WriteLine("Top Most Element=" +top);  // removeing it

            Console.WriteLine(top.ToString());

            foreach(object item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
