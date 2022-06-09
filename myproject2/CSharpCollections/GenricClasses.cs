using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class GenricClasses
    {

        static void Main(string[] args)
        {
            //Genric classes 
            // List
            List<int> list = new List<int>();


            list.Add(23);
            list.Add(28);

            Console.WriteLine(list[0]);

            // Array Hashing 

            Dictionary<int, string> al = new Dictionary<int, string>();

            al.Add(23, "Virat");
            al.Add(43, "Dhoni");

            Console.WriteLine(al.ContainsKey(23));
            Console.WriteLine(al.ContainsValue("Viraj"));
            al[23] = "Hardik"; //Replace
            al.Remove(43);

            foreach (KeyValuePair<int , string>item in al)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            
            }
            foreach(int a in al.Keys)
            {
                Console.WriteLine(a + " " + al[a]); ;
            }
        }
    }
}
