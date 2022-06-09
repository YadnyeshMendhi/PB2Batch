using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class CallbyValueCallbyRef
    {

        public class employee
        {
            public void display(int a, String str)
            {
                Console.WriteLine("the variable value is  " + a);
                Console.WriteLine("the string value is " +str);
            
            }
        }
        public class student
        {
            public void show(ref string str)
            {
                Console.WriteLine("Enter a number");
                String s = Console.ReadLine();
                str = str + s;
                Console.WriteLine("value in str variable is str" +str);

            }
        
        }

        static void Main(string [] args)
        {
            String m = "Sunil";
            employee emp = new employee();
            emp.display(101, m);
            Console.WriteLine("the value in variable m is " + m);

            String msg = "Hello";
            student stu = new student();
            stu.show(ref msg);
            Console.WriteLine("the value in msg is " +msg);

        }


    }
}
