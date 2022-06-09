using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PerformAllArithOper
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int Add, Sub, Mul, Div, Mod;


            Console.WriteLine("Enter first number : ");
            num1 =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Addition
            Add = num1 + num2;
            Console.WriteLine("Addition =" +Add);

            //Subtraction
            Sub = num1 - num2;
            Console.WriteLine("Subtraction =" +Sub);

            //Multiplication
            Mul = num1 * num2;
            Console.WriteLine("Multiplication =" +Mul);

            //Division
            Div = num1 / num2;
            Console.WriteLine("Division =" + Div);

            //Modulo Division
            Mod = num1 % num2;
            Console.WriteLine("Modulo =" + Mod);


        }
    }
}
