using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Greater5OrNot
    {
        static void Main(string[] args)
        {
            // input a number and check wheather it is a greater than 5 or not

            int i;
            Console.WriteLine("Enter number  : ");
            i = Convert.ToInt32(Console.ReadLine());

            if (i >= 5)
            {
                Console.WriteLine("Given number is greater than 5 ");
    
            }
            else
            {
                Console.WriteLine("Given number is not greater than 5");
            }

        }
    }
}
