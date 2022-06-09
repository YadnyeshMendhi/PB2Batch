using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForloopPrimeorNot
    {
        static void Main(String [] args)
        {

            // int num = 15;

            Console.WriteLine("Enter a number to check prime or not ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Boolean isPrime = true;

            for(int i = 2; i < num; i++)
            {
                if(num%i == 0)
                {
                    isPrime = false;
                }
            }


            if(isPrime == true)
            {
                Console.WriteLine(num+ " is a prime number" );
            }
            else
            {
                Console.WriteLine(num+ " is not a prime number" );
            }



        }
    }
}
