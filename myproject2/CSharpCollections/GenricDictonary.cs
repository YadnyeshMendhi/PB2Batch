using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class GenricDictonary
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();

            dd.Add(1, "Abhay");
            dd.Add(2, "Kunal");
            dd.Add(3, "Kunal");
            dd.Add(4, "Ranvijay");

            Console.WriteLine(dd.ContainsKey(1));  //Returns boolean values
            Console.WriteLine(dd.ContainsValue("Kunal"));

            foreach(KeyValuePair<int , string> item in dd)
            {
                Console.WriteLine(item.Key+"---->"+item.Value);
            }
            foreach(int s in dd.Keys)
            {
                Console.WriteLine(s+"-->"+dd[s]);
            }
        }
    }
}
