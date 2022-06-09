using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class SortedList
    {
        static void Main(String[] args)
        {
            //Sorted list - Key value pairs
            //Key should be unique
            //Data automatically internally is sorted according to 
            //Sorted oredr of keys

            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("ketki", 90);
            ss.Add("Aditya", 90);
            ss.Add("Sonam", 90);
            ss.Add("Amit", 90);

            
            foreach(KeyValuePair<string,int> k in ss)
                Console.WriteLine(k.Key+"---->"+k.Value);
        }
    }
}
