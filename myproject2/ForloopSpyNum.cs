using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Practice
    {
        static void Main(String[] args)
        {
            
            Console.WriteLine("Enter any number to check spy number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, product = 1;
            for (; num > 0; num = num / 10)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
            }
            Console.WriteLine("The sum of the total digits = " +sum);
            Console.WriteLine("The product of the total digits = " +product);




            if (sum == product)
            {
                Console.WriteLine("Spy number");
            }
            else
            {
                Console.WriteLine( "Not a Spy number");
            }



        }



        
    }
}
            


           
            