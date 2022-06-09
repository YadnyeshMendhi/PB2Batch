using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SwitchDisWeek
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());


            switch(num)
            {
                case 1: Console.WriteLine("monday");
                    break;

                case 2: Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wed");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:  Console.WriteLine("Invaild input");
                    break;
            }

            
            
        }
    }
}
