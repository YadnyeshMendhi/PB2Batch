using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class WhilePowerExponent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent");
            int expo = Convert.ToInt32(Console.ReadLine());


            int power = 1;
            int i = 1;
            while (i <= expo)
            {
                power = power * number;
                i++;
            }
            Console.WriteLine(power);
        }
    }
}
