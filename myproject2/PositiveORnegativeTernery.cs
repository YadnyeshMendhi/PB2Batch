using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PositiveORnegativeTernery
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter number  :");
            num = Convert.ToInt32(Console.ReadLine());

            string result = (num > 0) ? "Positive Number" : (num < 0) ? "Negative number" : "Zero";
            Console.WriteLine("Result : " +result);

        }
    }
}
