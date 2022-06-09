using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForloopReverseNum
    { static void Main(String [] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());


            // 567 765 
            int reverse = 0;
            while(num > 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine("The Reverse of given is = " +reverse);

        }
    }
}
