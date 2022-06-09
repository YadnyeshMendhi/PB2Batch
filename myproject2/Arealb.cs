using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Arealb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length  : ");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth : ");
            int Breadth = Convert.ToInt32(Console.ReadLine());

            // Calculate Lenth * Breadth

            int Area = Length * Breadth;

            Console.WriteLine("Area of rectangle is = " +Area);

        }
    }
}
