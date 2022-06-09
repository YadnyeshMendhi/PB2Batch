using System;
using System.Collections.Generic;
using System.Text;

namespace myproject
{
    class ArithmeticOperators
    {

        static void Main(string[] args)
        {
            int num1, num2,sum;
            num1 = 6;
            num2 = 7;
            sum = num1 + num2;
            Console.WriteLine("Addition=" +sum);

            sum = num1 - num2;
            Console.WriteLine("Subtraction=" +sum);


            sum = num1 * num2;
            Console.WriteLine("Multiplication=" +sum);

            sum = num1 / num2;
            Console.WriteLine("Division=" +sum);

            sum = num1 % num2;
            Console.WriteLine("Modulo=" +sum);
        }

     



    }
}
