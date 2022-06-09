using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class EvenOddTernery
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            if(num1%2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }


            String result = (num1 % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("result" +result);
            

        }
    }
}
