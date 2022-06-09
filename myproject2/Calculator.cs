using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operater");
            op = Console.ReadLine()[0];

            char ch;
            do
            {
                switch (op)
                {
                    case '+':
                        Console.WriteLine("Addition of number is : " + (num1 + num2));
                        break;
                    case '-':
                        Console.WriteLine("Substraction of number is : " + (num1 - num2));
                        break;
                    case '*':
                        Console.WriteLine("multiplication of number is : " + (num1 * num2));
                        break;
                    case '/':
                        Console.WriteLine("Division of number is : " + (num1 / num2));
                        break;
                    case '%':
                        Console.WriteLine("Modulo of number is : " + (num1 % num2));
                        break;
                    default:
                        Console.WriteLine("invaild operater");
                        break;
                }
                Console.WriteLine("Do you want to continue......");
                ch = Console.ReadLine()[0];


            } while (ch =='y' || ch == 'Y');
        }
    }
}
