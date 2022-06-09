using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class MenuDrivenCalculater
    {

        static void Main(String[] args)
        {


            char ch;
            do
            {
                Console.WriteLine("Enter num1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Additon \n 2.Substraction \n  3.Multiplication \n 4.Division \n 5.Mod Division");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition = " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("substraction" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("multiplication = " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("division" + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Mod division" + (num1 % num2));
                        break;
                    default:
                        Console.WriteLine("Invaild choice");
                        break;
                }


                Console.WriteLine("Do you want to continue.....");
                ch = Console.ReadLine()[0];


            } while (ch == 'y' || ch == 'Y');




        }
    }
}


