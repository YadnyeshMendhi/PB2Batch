using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Sum10Natural
    {
        static void Main(string[] args)
        {

            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;

               
            }
            Console.Write("Sum of 10 natural numbers is : " + sum);



        }
    }
}
