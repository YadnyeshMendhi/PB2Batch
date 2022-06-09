using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ConstructorDemo2
    {


        int id;
        String name;
        int marks;

        public ConstructorDemo2(int sid, String sname, int mk)
        {
            id = sid;
            name = sname;
            marks = mk;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + marks);
        }

        static void Main(String[] args)
        {
            ConstructorDemo2 c = new ConstructorDemo2(101, "amit", 89);
            c.display();
        }
    }
}


   

