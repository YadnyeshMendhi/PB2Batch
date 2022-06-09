using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForLoopFactorialOfEven
    {
        static void Main(String [] args)
        {
                int  factorial = 1;
                Console.WriteLine("Enter a number ");
                 int num = Convert.ToInt32(Console.ReadLine());
           
               for(int a = 1; a<=num; a++)
                {
                    factorial = factorial * a;
                    Console.WriteLine("factorial of " + num + " is " + factorial);
                }
               

            }
        }  
    }
