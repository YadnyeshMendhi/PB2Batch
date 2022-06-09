using System;
using System.Collections;
using System.Text;

namespace MyProject1.CSharpCollections
{
    // (int id,String name,ArrayList hobbies).
    //Create 2 student object  using constructor and properties.

    class constructor
    {

        int id;
        String name;
        public constructor(int sid , String sname)
        {
            id = sid;
            name = sname;
        }
        public void display()
        {
            Console.WriteLine(id +" "+name);
        }
       

    }
    class Property
    {  
        private int stuid;
        private String stuname;

        public int Id
        {
            set { stuid = value; }
            get { return stuid; }
        }
        public String Name
        {
            set { stuname = value; }
            get { return stuname; }
        }

    }


    class AssignmentCollecProg
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Student Id" +" , "+ "Student Name");
            Console.WriteLine(".................................");

            constructor obj1 = new constructor(101, "Virat");
            obj1.display();

            Property obj2 = new Property();
            Console.Write(obj2.Id = 102);
            Console.Write(obj2.Name = " Mohit ");
            Console.WriteLine();

            Console.WriteLine("...................................");

            Console.WriteLine("HOBBIES");
            // Createing ArrayList
            ArrayList list = new ArrayList();

            list.Add("Reading books" + " , " + "Photography");
            list.Add("Travel" + " , " + "Learning languages");

            foreach(object items in list)
            {
                Console.WriteLine(items);
            }
        }
    }
}
