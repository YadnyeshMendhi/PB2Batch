using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class Person
    {

        public int id = 1;
        public String pname = "Amit";

        public void show()
        {
            Console.WriteLine(id+""+pname);
        }
    }
    class Employee : Person
    {
        public int salary = 30000;

        public void display()
        {
            Console.WriteLine(""+salary);
        }

    }
    class Manager : Employee
    {

        public int commition = 20000;


        public void output()
        {
            Console.WriteLine(" "+commition);
        }

    }

    class MultilevelDemo
    {
        static void Main(String [] args)
        {
            Manager m = new Manager();
            m.show();
            m.display();
            m.output();
        }
    }
}
