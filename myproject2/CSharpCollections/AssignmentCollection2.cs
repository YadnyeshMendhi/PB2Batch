using System;
using System.Collections;
using System.Text;

namespace myproject2.CSharpCollections
{
    class AssignmentCollection2
    {
        static void Main(string[] args)
        {
            /*// WAP to sort the elements of List that contains String objects.Print List.
            List<string> list = new List<string>();

            list.Add("Reginold");
            list.Add("John");
            list.Add("Vidyut");
            list.Add("Rohan");

            list.Sort();

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }*/

            //WAP to create a Queue with some colors(String) using generics.

            /*  Queue colours = new Queue();

              colours.Enqueue("Yellow");
              colours.Enqueue("White");
              colours.Enqueue("Violet");
              colours.Enqueue("Red");
              colours.Enqueue("Blue");

              colours.Dequeue();// first in first out
              foreach (var items in colours)
              {
                  Console.WriteLine(items);
              }*/
            //WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.

            /*  SortedList<int, string> list = new SortedList<int, string>();

              list.Add(1, "Kaushik");
              list.Add(2, "Armaan");
              list.Add(3, "Varun");
              list.Add(4, "Karan");

              list[1] = "Yadnyesh"; //Replace

              Console.WriteLine(list.ContainsKey(1)); //true
              Console.WriteLine(list.ContainsValue("Varu")); // false

              foreach (KeyValuePair<int, string> items in list)
              {
                  Console.WriteLine(items.Key+"--->"+items.Value);
              }
  */

            //WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs.

            /* Dictionary<string, float> list = new Dictionary<string, float>();

             list.Add("Virat", 23.00f);
             list.Add("Hardik", 54.00f);
             list.Add("Yuzvendra", 78.00f);
             list.Add("Dhoni", 89.00f);

             foreach (KeyValuePair<string, float> items in list)
             {
                 Console.WriteLine(items.Key+"---->"+items.Value);
             }*/

            //    7. Make use of such collection that stores moviename such that last entered movie is first
            //deleted and accordingly previous one.

           /* Stack MovieName = new Stack();

            MovieName.Push("KGF");
            MovieName.Push("Saaho");
            MovieName.Push("Bahubali");
            MovieName.Push("Bahubali2");

            MovieName.Pop();// the top most element means the last element will get pop

            foreach(var movieName in MovieName)
            {
                Console.WriteLine(movieName);
            }*/
             
          
        }
    }
}
