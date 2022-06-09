using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class DisplayHello
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter any value :");
            num = Convert.ToInt32(Console.ReadLine());


            if(num > 3 && num <10)
            {
                Console.WriteLine("Hello");


            }
            else
            {
                Console.WriteLine("Hii Hello : ");
            }
        }
    }
}
