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

            SortedList<string,int> ss = new SortedList<string,int> ();
            ss.Add("ketki", 90);
            ss.Add("Aditya", 78);
            ss.Add("Sonam", 67);
            ss.Add("Amit", 56);

            //This method determines whether the SortedList<TKey, TValue> contains a specific key.
            Console.WriteLine(ss.ContainsKey("ketki"));//true

            //This method determines whether the SortedList<TKey, TValue> contains a specific value
            Console.WriteLine(ss.ContainsValue(89));//false

            foreach (KeyValuePair<string,int> k in ss)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            
            }


                
        }
    }
}
