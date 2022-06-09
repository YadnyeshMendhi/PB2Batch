using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{ 
    class Father
    {
        public String fathername()
        {
            return "Ravi";

        }
        static void Main(String[] args)
        {


            ChildFirst c1 = new ChildFirst();
            Console.WriteLine("My name is "+ c1.childfirst() + ".My father name is " + c1.fathername());
            ChildSecond c2 = new ChildSecond();
            Console.WriteLine("My name is "+ c2.childsecond() + ".My father nam is " + c2.fathername());

        }

    }
    class ChildFirst : Father
    {
        public String childfirst()
        {
            return "Abhay";
        }


    }
    class ChildSecond : Father
    {

        public String childsecond()
        {
            return "Ashwin";
        }
    }

   
   


}   

