using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.CSharpCollections
{

    //WAP to create a class Employee with (name, designation ,salary).Now create and add Employee objects elements to List. Print List.

    class Emp
    {

        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }

    }
    class AssignColl2ProgEmp
    {
        static void Main(string[] args)
        {
            //Software Developer/Software Engineer/Programmer/QA engineer.

            Emp e1 = new Emp { Name = "Abhi", Designation = "Software engineer", Salary = 45000 };
            Emp e2 = new Emp { Name = "John", Designation = "Software engineer", Salary = 46000 };
            Emp e3 = new Emp { Name = "John", Designation = "Programmer", Salary = 50000 };
            Emp e4 = new Emp {Name = "John", Designation = "QA engineer", Salary = 35000};

            List<Emp> list = new List<Emp>() { e1,e2,e3,e4 };

            foreach (Emp item in list)
            {
                Console.WriteLine(item.Name+"-->"+item.Designation+"-->"+item.Salary);
                
            }

        }
    }
}
