using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class TeenagerOrNot
    {
        static void Main(string[] args)
        {
            int age ;
            Console.Write("Input your age : ");
            age = Convert.ToInt32(Console.ReadLine());


            if(age>=13 && age <= 19)
            {
                Console.WriteLine("you are teenager");
            }
            else
            {
                Console.WriteLine("you are not teenager");
            }
        }
    }
}
