using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForLoopSumNum
    { 
        static void Main(String [] args)
        {
            Console.Write("Enter any number to check Spy Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, product = 1;

            for(;num > 0; num = num / 10)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
            }
            Console.WriteLine("Sum of total digits = " + sum);
            Console.WriteLine("Product of total digits = " +product);



            if (sum == product)
            {
                Console.WriteLine("Spy number");
            }
            else
            {
                Console.WriteLine("Not a Spy number");
            }


        }
    }
}
