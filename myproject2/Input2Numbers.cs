using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Input2Numbers
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());

            if(a == b)
            {
                Console.WriteLine("The numbers are equal");
            }
            else     
            {
                int g = a;
                if (b > g)
                    g = b;
                {
                    Console.WriteLine("The greatest number is b " +b);
                }
            }
           
        }
    }
}
