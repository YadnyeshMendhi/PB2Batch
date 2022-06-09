using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class ArrayListNonGenricCollections
    {
        static void Main(String[] args)
        {
            //ArrayList default data structure Growable Array
            //By Default size is 4 after 5th element it get twice
            // Creating ArrayList
            ArrayList list = new ArrayList();

            //ArrayList list = new ArrayList(3) you can add capacity of any particular number Capacity=6
                                                


            //Elements
            list.Add("One");
            list.Add("two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");
            list.Add("Six");
            /*
                        list.Remove("two");
                        list.RemoveAt(3);*/
            // list.RemoveRange(1, 3);
            //list.Sort();
            // list.Reverse();

            int count = list.Count;
            int capacity = list.Capacity;
            Console.WriteLine("Capapcity : " +capacity);

            //when your assure that your not going to add
            // and remove any element from list you can simply 
            //trim them.
            list.TrimToSize();
            capacity = list.Capacity;

            Console.WriteLine("Count : "  +count);
            Console.WriteLine("Capacity : " + capacity);


            foreach(object item in list)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
