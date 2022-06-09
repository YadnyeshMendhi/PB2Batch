using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class Class3
    {
        static void Main(String[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("Raj", "C#");
            ht.Add("Ram", "java");
            ht.Add("Yash", "php");
            ht.Add("John", "HTML");
            ht.Add(23, "Virat");

            ht[23] = "Yadnyesh";

            ht.Remove("Raj");
            ht.Contains("java");

           
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
            foreach (var k in ht.Keys)
            {
                Console.WriteLine(k + "---->" + ht[k]);
            }
        }
    }
}
