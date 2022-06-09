using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class Class2
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            {
                list.Add("mon");
                list.Add("tue");
                list.Add("wed");
                list.Add("fri");


            }
            string s = "Abhishek";
            char[] carr = s.ToCharArray();
            Hashtable ht = new Hashtable();



            foreach (dynamic data in carr)
            {
                if (ht.Contains(data))
                {
                    int value = (int)ht[data];
                    ht[data] = value + 1;
                }
                else
                    ht.Add(data, 1);
            }
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" : "+d.Value);
            }
        }
    }
}
