using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExtraQuestions
{
    class Factorial
    {
        // factorial means the product of all positive integers 
        //starting with n and counting backwards to 1 

        static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * factorial(n - 1);
        }

        static void Main(string [] args)
        {
            int ans = factorial(3);
            Console.WriteLine(ans);

            //Interpolation

            String msg = "welcome to india ";

            String mymsg = $"Hello {msg}";
            Console.WriteLine(mymsg);

        }
    }
}
