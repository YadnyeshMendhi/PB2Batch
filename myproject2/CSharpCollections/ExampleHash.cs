using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class ExampleHash
    {
        static void Main(string[] args)
        {
            // non genric 
            // key value pair
            //keys always shold be unique


            Hashtable ht = new Hashtable();
            ht.Add(1 ,  "Virat");
            ht.Add(2, "Mohit");
            ht.Add(3, "Hardik");
            ht.Add(4, "yuzvendra");
            // ht.Add(new Student(1, "Priya"), "giyfafyyfykk");

            Console.WriteLine(ht[3]);
            ht[3] = "Suresh";
            

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
            Console.WriteLine("............................");
            foreach(var k in ht.Keys)
            {
                Console.WriteLine(k+"--->"+ht[k]);
            }
            
        }
    }
}
