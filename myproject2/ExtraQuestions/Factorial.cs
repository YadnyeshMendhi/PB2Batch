using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.ExtraQuestions
{
    class Factorial
    {
        // factorial means the product of all positive integers 
        //starting with n and counting backwards to 1 

        public static double factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * factorial(n - 1);//Recursive call
        }

        static void Main(string [] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            double ans = factorial(number);
            Console.WriteLine("Factorial of "+number+" is "+" = "+ans);

            //Interpolation

            String msg = "welcome to india ";

            String mymsg = $"Hello {msg}";
            Console.WriteLine(mymsg);

        }
    }
}
