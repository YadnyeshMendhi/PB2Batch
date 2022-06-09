using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class StringPalindrome
    {

        static void Main(string [] args)
        {

            String s = "nitin";
           /* Console.WriteLine("Enter a string");
             s = Console.ReadLine();*/

            String  reverse = " ";

            for(int i=s.Length-1; i>=0; i--)
            {
                reverse =reverse + s[i];
            }

           // Console.WriteLine(revr);
           // Console.WriteLine(reverse.CompareTo(s));

            if (reverse.Equals(s)==true)
            {
                Console.WriteLine("String is a Palindrome = " +reverse);
            }
            else
            {
                Console.WriteLine("String is not Palindrome = "+ reverse);
            }


        }
    }
}
