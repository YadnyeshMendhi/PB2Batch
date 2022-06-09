using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Mock
    {

        static void Main(String [] args)
        {
            int reverse = 0, original;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            original = num;

            for (; num > 0; num = num / 10)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;

            }

            if (original == num)
            {
                Console.WriteLine("palindrome number" + original);
            }
            else
            {
                Console.WriteLine("Not palindrome number" + original);
            }






        }
    }
}
