using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SingleDigitDoubleDigit
    {
        static void Main(string[] args)
        {
            /*int num;
            Console.Write("Enter number = ");         
            num = Convert.ToInt32(Console.ReadLine());


            if(num >= 0 && num <= 9)
            {
                Console.WriteLine("The number is Single Digit");
            }
            else if(num >= 10 && num <= 99)
            {
                Console.WriteLine("The number is Double Digit");
            }
            else
            {
                Console.WriteLine("input is wrong");
            }*/

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            String Result = (num >= 0 && num <= 9) ? "Single digit" : (num >= 10 && num <= 99) ? "Double digit" : "input wrong";
            Console.WriteLine("Result : " +Result);
        }
    }
}
