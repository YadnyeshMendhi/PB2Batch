using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NumberEvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any Number  :");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.Write("Is an Even Number : " + num);

            }
            else
            {
                Console.Write("is an odd Number: " +num);
            }
        }
    }
}
