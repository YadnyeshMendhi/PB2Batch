using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class Principle
    {

        protected int id = 1;
        protected String name = "Nikhil";

    }
    class Teacher : Principle
    {

        protected String subject = ".Net";

    }


    class Student : Teacher
    {

         int rollno = 101;
         int marks = 98;

        static void Main(String [] args)
        {
            Student s = new Student();
            Console.WriteLine(s.id + " " + s.name + " " + s.subject + " " + s.rollno + " " + s.marks);
        }

    }
}
