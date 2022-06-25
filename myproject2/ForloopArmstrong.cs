using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForloopArmstrong
    {
        static void Main(String [] args)
        {

            int  original , remainder , result = 0;
            Console.Write("Enter three digit number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            original = num;


            for (; original != 0; original = original / 10)
            {
                 remainder = original % 10;
                result = result + remainder * remainder * remainder;
            }
            

            if (original == result)
            {
                Console.WriteLine($"{num} is a Armstrong number" );
            }
            else
            {
                Console.WriteLine($"{num}is Not a  Armstrong number");
            }
        }
    }
}
