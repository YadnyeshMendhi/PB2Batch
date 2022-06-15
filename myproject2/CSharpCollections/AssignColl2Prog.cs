using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace myproject2.CSharpCollections
{
    //    8. WAP to create SortedList<Employee,string> where key is of Employee type and value is departmentname(string) he works in. SortedList should maintain data in descending order 
    //of salary.

    class Employee: IComparable<Employee>
    {
        public int sid;
        public string name;
        public int salary;
        
        public Employee(int sid, string name, int salary)
        {
            this.sid = sid;
            this.name = name;
            this.salary = salary;
        }

        /*public int Sid { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }*/

        public int CompareTo(Employee other)
        {
            if (this.salary < other.salary)
                return 1;
            else if (this.salary > other.salary)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return "Id ="+sid+" "+"Name ="+name+" "+"Salary = "+salary +  " Department ";
        }


    }

    /*public class Departmentname
    {
        public string Deptname { get; set; }
    }*/

    class AssignColl2Prog
    {
        static void Main(string[] args)
        {

           /* Employee emp1 = new Employee { Sid = 101, Name = "Abhijit", Salary = 15000 };
            Employee emp2 = new Employee { Sid = 102, Name = "Vikram", Salary = 25000 };
            Employee emp3 = new Employee { Sid = 102, Name = "Aditya", Salary = 30000 };
            Employee emp4 = new Employee { Sid = 102, Name = "Vikram", Salary = 45000 };
*/

           /* Departmentname deptname1 = new Departmentname { Deptname = "HR" };
            Departmentname deptname2 = new Departmentname { Deptname = "Sales" };
            Departmentname deptname3 = new Departmentname { Deptname = "Management" };
            Departmentname deptname4 = new Departmentname { Deptname = "Devolopment" };*/

            SortedList<Employee, string> list = new SortedList<Employee, string>();
            list.Add(new Employee( 101,"Abhijit", 15000), "HR" );
            list.Add(new Employee(102, "Vikram", 25000), "Sales");
            list.Add(new Employee(103, "Aditya", 30000), "Management");
            list.Add(new Employee(104, "Vibhor", 45000), "Devolopment");


            //List<Employee> list = new List<Employee>() { emp1, emp2, emp3, emp4 };

            foreach (KeyValuePair<Employee, string> items in list)
            {
                Console.WriteLine(items.Key + "---->" + items.Value);
            }
            /*foreach(Employee item in list)
              {
                  Console.WriteLine(item.Sid+" "+item.Name+" "+item.Salary);
              }
  */


        }
    }
}
