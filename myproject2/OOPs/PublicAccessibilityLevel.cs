using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{

    class student
    {
        public int rollno;
        public String name;


        public student(int r, String n)
        {
            rollno = r;
            name = n;
        }

        public int getRollNo()
        {
            return rollno;
        }
        public String getName()
        {

            return name;
        }


    }

    class PublicAccessibilityLevel
    {


        static void Main(string[] args)
        {
            student stu = new student(101 , "Rohan");
            Console.WriteLine("Roll no : " , stu.rollno);
            Console.WriteLine("name : " , stu.name);

            Console.WriteLine(".............................................");

            Console.WriteLine("Roll no : {0}" , stu.getRollNo());
            Console.WriteLine("Name : {0}" , stu.getName());



        }
      

    }
}
