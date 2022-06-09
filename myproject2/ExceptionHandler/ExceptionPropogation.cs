using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExceptionHandler
{
    class ExceptionPropogation
    {
        static void divide(int a , int b)
        {
            Console.WriteLine("Division" + a / b);
        }
        static void Main(string[] args)
        {
            try
            {
                divide(10  ,0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("An Exception has occured: " +e.Message);
            }
            Console.WriteLine("main ends");
        }
    }
}
 