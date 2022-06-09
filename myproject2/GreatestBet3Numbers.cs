using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class GreatestBet3Numbers
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Enter first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());


            String Result = (num1 > num2 && num1 > num3) ? "num1 is greater" : (num2 > num1 && num2 > num3) ? "num2 is greater" : "num 3 is greater";
            Console.WriteLine("Result = " + Result);
        }
    }
}
