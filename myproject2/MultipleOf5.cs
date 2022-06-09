using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class MultipleOf5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());


            if (num % 5 == 0)
            {
                Console.WriteLine("The number is multiple of 5");
            }
            else
            {
                Console.WriteLine("The number is not multiple of 5");
            }
        }
    }
}
