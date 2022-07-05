using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class GenricStack
    {
        static void Main(string[] args)
        {
            //genric stack
            Stack<int> list = new Stack<int>();

            list.Push(23);
            list.Push(45);
            list.Push(76);

            // 76 , 45 , 23

            Console.WriteLine(list.Pop());
            Console.WriteLine(list.Peek());

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
