using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class MenuDrivenProgram000
    {
        static void Main(String[] args)
        {
            char ch;
            do
            {

               
                Console.WriteLine("Enter a first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("..........................................");

                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {

                    case 1:
                        Console.WriteLine("Addition = " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("subtraction  ="+ (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("multiplication  ="+ (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("division = "+ (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }

                Console.WriteLine("Do you want to continue");
                ch = Console.ReadLine()[0];

            } while(ch == 'y' || ch == 'Y');
        }
    }
}
