using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    public class Student
    {

        int id;
        String name;
        int m1;
        int m2;
        int m3;
        float percentage;

        public void acceptDetails()
        {
            id = 1;
            name = "Sujal";
            m1 = 45;
            m2 = 56;
            m3 = 59;


        }
        public void percentageOfStudent()
        {
            percentage = ((m1 + m2 + m3) / 3.0f);
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + percentage);
        }

        /* public StudentMethod()
         {
             Console.WriteLine("default constructor invoked");
         }

         public StudentMethod(int id , String name , int m1, int m2 , int m3 )
         {

             this.id = id;

             this.name = name;
             this.m1 = m1;
             this.m2 = m2;
             this.m3 = m3;



         }
        }
 */
    }

     class StudentMethod
    { 
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.acceptDetails();
            stu.percentageOfStudent();
            stu.Display();

        }   
    }
}
