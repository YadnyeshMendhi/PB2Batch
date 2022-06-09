using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForloopPalindrome
    { 
        static void Main(String [] args)
        {



            int reverse = 0 , original;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            original = num;


            for(; num > 0; num = num / 10)
            {
                int r = num % 10;
                reverse =  reverse * 10 + r;
            }
            Console.WriteLine(reverse);




            if(original == reverse)
            {
                Console.WriteLine("Palindrome number = " +original);
            }
            else
            {
                Console.WriteLine("Not a Palindrome number = " +original);
            }
        }
    }
}
