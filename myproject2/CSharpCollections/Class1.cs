using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    class Stud
    {
        int id;
        string name;

        public Stud(int sid , string sname)
        {
            Id = sid;
            Name = sname;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override bool Equals(object obj) // it returns true or false
        {
            Stud stud = (Stud)obj;
            return id == stud.id && name == stud.name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
    

    class Class1
    {

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            /*  ht.Add(new Stud(1, "mohit"), "mohit001@gmail.com");
              ht.Add(new Stud(1, "mohit"), "mohit001@gmail.com");
              ht.Add(new Stud(1, "mohit"), "mohit001@gmail.com");
              ht.Add(new Stud(1, "mohit"), "mohit001@gmail.com");*/

            ht.Add("yadnyesh", 1);
            ht.Add("mohit", 2);
            ht.Add("Rohit", 3);


            foreach (DictionaryEntry item in ht) //
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
