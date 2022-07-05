using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class HashTableNonGenricCollections
    {
        static void Main(String[] args)
        {
            // creating HashTable
            //Hashtable uses Hashing technique to store data in table
            Hashtable ht = new Hashtable();

            //Elements
            ht.Add("key1", "value1"); //this is a paired value not a single value
            ht.Add("key2", "value2"); //object key must be different
            ht.Add("xyz", "1234");
            ht.Add("sd;iahd", "Tutorials");
            ht.Add("2key", "point");

            ht.Remove("key1"); // you'll not find key1 in this list
            ht.Contains("key2");

            foreach(DictionaryEntry item in ht) //DictionaryEntry take care of all these paired values
            {
                Console.WriteLine(item.Key +" : "+ item.Value);
            }
            Console.WriteLine(".............................");
            foreach(var k in ht.Keys)
            {
                Console.WriteLine(k+"---->"+ht[k]);
            }
        }
    }
}
        