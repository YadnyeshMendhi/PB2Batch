using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.ExtraQuestions
{
    class Commanfactors
    {

        static void Main(String [] args)
        {
            //int a = 6;//1,2,3,6
            // int b = 8;//1,2,4,8
            //1,2
            Console.WriteLine("Enter 1st Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = Convert.ToInt32(Console.ReadLine());


           // int min = a < b ? a : b;

            //comman factors

            for (int divisor = 1; divisor <= num1 && divisor <= num2; divisor++)
            {
                if(num1%divisor==0 && num2 % divisor == 0)
                {
                    Console.WriteLine($"CommanFactors of {num1} {num2} is {divisor}");
                   // Console.WriteLine(divisor);
                }
            }

        }
    }
}
