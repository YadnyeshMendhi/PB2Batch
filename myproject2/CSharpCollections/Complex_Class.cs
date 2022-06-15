using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.CSharpCollections
{
    class stud : IComparable<stud>
    {

        private int id;
        private string name;
        private int percentage;


        public stud(int sid , string name , int percentage)
        {
            this.Id = sid;
            this.Name = name;
            this.Percentage = percentage;

        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Percentage { get => percentage; set => percentage = value; }


        public int CompareTo(stud other)
        {
            if (this.percentage < other.percentage)
                return -1;
            else if (this.percentage > other.percentage)
                return 1;
            else
                return 0;
        }

        public override string ToString()
        {
            return "Id ="+id+ " " + "Name="+name+ " " + "Percentage=" + percentage;
        }
        public override bool Equals(object obj)
        {
            stud s1 = (stud)obj;
            return this.id == s1.id && this.name == s1.name;

        }
    }
    class Complex_Class
    {
        static void Main(string[] args)
        {

            SortedList<stud, string> ll = new SortedList<stud, string>();
            ll.Add(new stud(101, "Uddhav", 89), "Java");
            ll.Add(new stud(103, "Uddhav", 67), "Java");
            ll.Add(new stud(105, "Anuj", 90), "Java");
            ll.Add(new stud(102, "Sujal", 56), "Java");

            foreach(KeyValuePair<stud , string> item in ll)
            {
                Console.WriteLine(item.Key+"-->"+item.Value);
            }
        }
    }
}
