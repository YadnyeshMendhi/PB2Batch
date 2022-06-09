using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
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

         

            foreach(var i in list)
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
