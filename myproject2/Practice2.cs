using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Practice2
    {

        static void Main(String[] args)
        {
            // Reverse number & Palindrome number

            Console.WriteLine("Enter a number to reverse");
            int num = Convert.ToInt32(Console.ReadLine());
            int original = num;

            int reverse = 0;

            //using while loop
            //while (num > 0)
            
            //using for loop
            for(; num>0; num  =num / 10)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                //num = num / 10;
            }
            Console.WriteLine(".....................................");
            Console.WriteLine("Reverse of given number =" + reverse);

          if (original.CompareTo(reverse)==0)
                Console.WriteLine(reverse + " is a Palindrome number");
            else
                Console.WriteLine(reverse + "Not a palindrome number" );
         



        }
    }
}
