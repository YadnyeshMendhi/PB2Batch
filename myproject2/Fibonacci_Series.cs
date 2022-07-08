
using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2
{
    class Fibonacci_Series
    {
        static void Main(string[] args)
        {

            int a = 0, b = 1, c = 0;
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0} {1}",a , b);


            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(" {0} ",c);
                a = b;
                b = c;
            
            }
            Console.ReadLine();
        }
    }
}
