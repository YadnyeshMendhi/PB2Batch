using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExceptionHandler
{
    class Example
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter your name");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter your age");

            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Name=" + nm + "Age:" + age);
                Console.WriteLine("Character at 5th position in name is :" + nm[4]);

                try
                {
                    Console.WriteLine("enter 2 numbers");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("division" + a / b);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("An Exception has occured : " +e.Message);
                }
            }
            catch(FormatException ob)
            {
                Console.WriteLine("Age shold be numeric" +ob.Message);
                //Console.WriteLine("om"[4]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("An exception has occured : " +e.Message);
            }
            catch(SystemException e) //universal exception
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
