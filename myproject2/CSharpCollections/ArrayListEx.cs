using System;
using System.Collections;
using System.Text;

namespace myproject2.CSharpCollections
{
    class ArrayListEx
    {
        static void Main(String[] args)
        {

            //creating ArrayList
            ArrayList list = new ArrayList();

            //Elements
            list.Add(200);
            list.Add(300);
            list.Add("Pushpendra");
            list.Add(6.8);
            list.Add(400);
            //Date and Time
            DateTime d = DateTime.Parse("7-2-2022");
            list.Add(d);

            //Replace
            list[0] = 3000;

           /* list.Remove("Pushpendra");
            list.RemoveAt(1);*/
            list.RemoveRange(1, 3);
            list.Insert(1, "Yadnyesh");

            int count = list.Count;
            int capacity = list.Capacity;
            Console.WriteLine("Count = " +count);
            Console.WriteLine("Capacity = " +capacity);

         
            //it executes each and every item that exist in the arraylist object.
            //Each time loop rotates and read item from the arraylist and assignes to the variable.
            foreach(object i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("....................................");

            for(int i = 0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
