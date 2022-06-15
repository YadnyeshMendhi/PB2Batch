using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.CSharpCollections
{
    class Stud
    {
        int sid;
        string name;

        public override int GetHashCode()
        {
            return sid;
        }
        public override bool Equals(object obj)
        {

            Stud stud = (Stud)obj;
            return this.sid == stud.sid && this.name == stud.name;
        }
    }

    class Hashset_Genric_Coll
    {
        static void Main(string[] args)
        {
            //Hashset dulplicates elements not allow
            // Hashing technique

            HashSet< string> hs = new HashSet<string>();
            hs.Add("Vikram");
            hs.Add("Anuj");
            hs.Add("Sujal");
            hs.Add("Vir");
            hs.Add(null);

            HashSet<string> hs2 = new HashSet<string>();
            hs2.Add("Vikram");
            hs2.Add("Anuj");
            hs2.Add("Sujal");
            hs2.Add("Virat");

            Console.WriteLine(hs2.IsProperSubsetOf(hs));
            Console.WriteLine(hs.IsProperSupersetOf(hs2));

            foreach (string item in hs)
            {
                Console.WriteLine(item);
            }

            foreach (string item in hs2)
            {
                Console.WriteLine(item);
            }


        }
    }
}
